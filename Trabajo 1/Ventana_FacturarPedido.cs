using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_1
{
    public partial class Ventana_FacturarPedido : Form
    {
        //PROGRAMACION PARA INICIALIZAR EL PROGRAMA
        private int CodigoCliente;
        NodoPed ultimo = UCP.cola_Pedidos.DevolverPrimerPedido();       
        
        public Ventana_FacturarPedido()
        {
            InitializeComponent();
        }
        private void Ventana_FacturarPedido_Load(object sender, EventArgs e)
        {
            CargarCliente();
            CargarProductos();
            CargarPrecios();
        }

        //PROGRAMACION DE BOTONES
        private void BtnEliminarPedido_Click(object sender, EventArgs e)
        {
            UCP.cola_Pedidos.SacarPedido();
            MessageBox.Show("Este pedido ha sido eliminado de la cola");
            this.Close();
        }

        private void BtnCompletarPedido_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtEfectivo.Text))
            {
                MessageBox.Show("Debe ingresar la cantidad con la que pagara para despachar el pedido");
            }
            else
            {
                double cambio = Convert.ToInt32(TxtEfectivo.Text) - ultimo.pedido.PrecioFinal;
                if (cambio < 0)
                {
                    MessageBox.Show("Efectivo insuficiente");
                }
                else
                {
                    UCP.cola_Pedidos.SacarPedido();
                    MessageBox.Show("El cambio para el cliente es: $" + Math.Round(cambio, 2));
                    this.Close();
                }                
            }            
        }

        //PROGRAMACION DE EVENTOS
        private void Ventana_FacturarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 ventanaPrincipal = new Form1();
            ventanaPrincipal.Show();
        }

        //METODOS UTILIZADOS POR EL PROGRAMA
        private void CargarCliente()
        {
            CodigoCliente = ultimo.pedido.CodigoCliente;

            int pos = ULC.lista_Clientes.BuscarP(CodigoCliente);
            Cliente cliente = ULC.lista_Clientes.buscarCliente(pos);

            LbCodigoCliente.Text = cliente.CodigoCliente.ToString();
            LbNombreCliente.Text = cliente.NombreCliente;
            LbDireccion.Text = cliente.Direccion;
            LbEmail.Text = cliente.Correo;
            LbTelefono.Text = cliente.Telefono.ToString();
        }
        private void CargarProductos()
        {
            Cola_Productos ColaProductos;
            ColaProductos = ultimo.pedido.Cola_Productos;

            DgvProductosOrdenados.DataSource = null;
            DgvProductosOrdenados.DataSource = ColaProductos.informacionProductos();
        }
        private void CargarPrecios()
        {
            LbSumaTotal.Text = "$" + ultimo.pedido.PrecioTotal.ToString();
            LbIva.Text = "$" + ultimo.pedido.Iva.ToString();
            LbPagoTotal.Text = "$" + ultimo.pedido.PrecioFinal.ToString();
        }
            
    }
}
