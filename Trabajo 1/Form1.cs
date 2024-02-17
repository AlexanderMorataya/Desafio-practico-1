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
    public partial class Form1 : Form
    {
        //PROGRAMACION DE INICIALIZACION DEL PROGRAMA
        public Form1()
        {
            InitializeComponent();
            Cliente cliente1 = new Cliente { NombreCliente = "Cliente 1", Direccion = "Dirección 1", Telefono = 123456789, Correo = "cliente1@example.com" };
            Cliente cliente2 = new Cliente { NombreCliente = "Cliente 2", Direccion = "Dirección 2", Telefono = 987654321, Correo = "cliente2@example.com" };
            Cliente cliente3 = new Cliente { NombreCliente = "Cliente 3", Direccion = "Dirección 3", Telefono = 555555555, Correo = "cliente3@example.com" };
            Cliente cliente4 = new Cliente { NombreCliente = "Cliente 4", Direccion = "Dirección 4", Telefono = 111111111, Correo = "cliente4@example.com" };
            Cliente cliente5 = new Cliente { NombreCliente = "Cliente 5", Direccion = "Dirección 5", Telefono = 999999999, Correo = "cliente5@example.com" };
            Cliente cliente6 = new Cliente { NombreCliente = "Cliente 6", Direccion = "Dirección 6", Telefono = 222222222, Correo = "cliente6@example.com" };
            ULC.lista_Clientes.InsertarF(cliente1);
            ULC.lista_Clientes.InsertarF(cliente2);
            ULC.lista_Clientes.InsertarF(cliente3);
            ULC.lista_Clientes.InsertarF(cliente4);
            ULC.lista_Clientes.InsertarF(cliente5);
            ULC.lista_Clientes.InsertarF(cliente6);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ImprimirPedidos();
        }

        //PROGRAMACION DE BOTONES
        private void BtnRealizarPedido_Click(object sender, EventArgs e)
        {
            Ventana_IniciarPedido iniciarPedido = new Ventana_IniciarPedido();
            iniciarPedido.Show();
            this.Hide();
        }
        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            Ventana_EditarCliente editarCliente = new Ventana_EditarCliente(0);
            editarCliente.Show();
            this.Hide();
        }
        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            Ventana_Cliente buscarCliente = new Ventana_Cliente(0);
            buscarCliente.Show();
            this.Hide();
        }
        private void BtnFacturarPedido_Click(object sender, EventArgs e)
        {
            if (UCP.cola_Pedidos.ColaVacia())
            {
                MessageBox.Show("No hay ningun pedido en cola");
            }
            else
            {
                Ventana_FacturarPedido facturarPedido = new Ventana_FacturarPedido();
                facturarPedido.Show();
                this.Hide();
            }            
        }

        //METODOS UTILIZADOS POR EL PROGRAMA
        private void ImprimirPedidos()
        {
            DgvInformacionPedidos.DataSource = null;
            DgvInformacionPedidos.DataSource = UCP.cola_Pedidos.informacionPedidos();
        }

        //PROGRAMACION DE EVENTOS
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
