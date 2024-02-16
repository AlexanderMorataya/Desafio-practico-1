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
    public partial class Ventana_Cliente : Form
    {
        //PROGRAMACION DE INICIALIZACION DEL PROGRAMA
        private int pos, codigo, telefono;
        private string nombre, direccion, correo;        
        public int casoEscogido, casoPrevio;
        public Ventana_Cliente(int Caso)
        {
            InitializeComponent();
            this.casoEscogido = Caso;
        }
        private void Ventana_Cliente_Load(object sender, EventArgs e)
        {
            if (casoEscogido == 0)
            {
                BtnConfirmarCliente.Visible = false;
                BtnModificarCliente.Enabled = false;
            }
            if(casoEscogido == 1)
            {
                BtnModificarCliente.Visible = false;
                BtnConfirmarCliente.Enabled = false;
            }
        }

        //PROGRAMACION DE BOTONES
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigoCliente.Text))
            {
                MessageBox.Show("Debe ingresar un codigo para poder buscar al cliente");
            }
            else
            {
                pos = ULC.lista_Clientes.BuscarP(Convert.ToInt32(TxtCodigoCliente.Text));

                if (pos > 0)
                {
                    Cliente datosCliente = ULC.lista_Clientes.buscarCliente(pos);
                    codigo = datosCliente.CodigoCliente;
                    nombre = datosCliente.NombreCliente;
                    direccion = datosCliente.Direccion;
                    correo = datosCliente.Correo;
                    telefono = datosCliente.Telefono;

                    LbCodigo.Text = "Codigo: " + codigo;
                    LbNombre.Text = "Nombre: " + nombre;
                    LbDireccion.Text = "Direccion: " + direccion;
                    LbTelefono.Text = "Telefono: " + telefono;
                    LbEmail.Text = "Email: " + correo;

                    if (casoEscogido == 0)
                    {
                        BtnModificarCliente.Enabled = true;
                    }
                    if (casoEscogido == 1)
                    {
                        BtnConfirmarCliente.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se ha encontrado ningun cliente asociado a ese codigo");
                }
            }
        }
        private void BtnConfirmarCliente_Click(object sender, EventArgs e)
        {
            casoEscogido = 2;
            this.Close();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            casoEscogido = 3;
            this.Close();
        }

        //PROGRAMACION DE EVENTOS
        private void Ventana_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Si abre desde ventana principal
            if(casoEscogido == 0)
            {
                Form1 ventanaPrincipal = new Form1();
                ventanaPrincipal.Show();                
            }
            //Si abre desde iniciar pedido
            if(casoEscogido == 1)
            {
                Ventana_IniciarPedido iniciarPedido = new Ventana_IniciarPedido();
                iniciarPedido.Show();
            }
            //Si confirma la informacion cliente
            if (casoEscogido == 2)
            {
                Ventana_OrdenarPedido ordenarPedido = new Ventana_OrdenarPedido();
                ordenarPedido.Show();
            }
            //Si decide modificar cliente
            if (casoEscogido == 3)
            {
                Ventana_EditarCliente editarCliente = new Ventana_EditarCliente(1);
                editarCliente.SetDatos(pos, codigo, nombre, direccion, correo, telefono);
                editarCliente.Show();
            }
        }

        


    }
}
