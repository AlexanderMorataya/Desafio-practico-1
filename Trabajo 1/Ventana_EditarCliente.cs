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
    public partial class Ventana_EditarCliente : Form
    {
        //PROGRAMACION DE INICIALIZACION DEL PROGRAMA
        private int pos;
        private int casoEscogido;
        public Ventana_EditarCliente(int Caso)
        {
            InitializeComponent();
            this.casoEscogido = Caso;
        }
        private void Ventana_EditarCliente_Load(object sender, EventArgs e)
        {
            if (casoEscogido == 0)
            {
                BtnEliminarCliente.Visible = false;
                LbTitulo.Visible = false;
            }
        }

        //PROGRAMACION DE BOTONES
        //Boton para crear o modificar un cliente, dependiendo del caso escogido que reciba
        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if(casoEscogido == 0)
            {
                if(string.IsNullOrEmpty(TxtNombreCliente.Text) || string.IsNullOrEmpty(TxtEmailCliente.Text) || string.IsNullOrEmpty(TxtDireccionCliente.Text) || string.IsNullOrEmpty(TxtTelefonoCliente.Text))
                {
                    MessageBox.Show("No puede dejar ningun campo vacio");
                }
                else
                {
                    int codigo;

                    Cliente nuevoCliente = new Cliente();
                    nuevoCliente.NombreCliente = TxtNombreCliente.Text;
                    nuevoCliente.Correo = TxtEmailCliente.Text;
                    nuevoCliente.Direccion = TxtDireccionCliente.Text;
                    nuevoCliente.Telefono = Convert.ToInt32(TxtTelefonoCliente.Text);

                    codigo = ULC.lista_Clientes.InsertarF(nuevoCliente);

                    MessageBox.Show("Datos ingresados, su codigo de cliente es " + codigo.ToString() + ", importante no olvidar este numero");

                    this.Close();
                }
            }
            else
            {
                if (pos < 0)
                {
                    MessageBox.Show("No se ha escogido ningun cliente a modificar");
                }
                else
                {
                    if (string.IsNullOrEmpty(TxtNombreCliente.Text) || string.IsNullOrEmpty(TxtEmailCliente.Text) || string.IsNullOrEmpty(TxtDireccionCliente.Text) || string.IsNullOrEmpty(TxtTelefonoCliente.Text))
                    {
                        MessageBox.Show("No puede dejar ninguno de los campos en blanco");
                    }
                    else
                    {
                        Cliente nuevoCliente = new Cliente { CodigoCliente = Convert.ToInt32(LbCodigoCliente.Text), NombreCliente = TxtNombreCliente.Text, Correo = TxtEmailCliente.Text, Direccion = TxtDireccionCliente.Text, Telefono = Convert.ToInt32(TxtTelefonoCliente.Text) };
                        ULC.lista_Clientes.ModificarCliente(pos, nuevoCliente);
                        MessageBox.Show("El cliente ha sido modificado exitosamente");
                        this.Close();
                    }
                }
            }
            
        }
        //Boton para eliminar un cliente
        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (pos <= 0)
            {
                MessageBox.Show("No se ha escogido ningun cliente a modificar");
            }
            else
            {
                ULC.lista_Clientes.EliminarP(pos);
                MessageBox.Show("El cliente ha sido eliminado exitosamente");
                this.Close();
            }
        }

        //PROGRAMACION DE EVENTOS
        private void Ventana_EditarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            pos = -1;
            Form1 ventanaPrincipal = new Form1();
            ventanaPrincipal.Show();                                                  
        }

        //METODOS URILIZADOS POR EL PROGRAMA
        //Metodo para guardar la posicion en caso de que el cliente busque modificar a un cliente
        public void SetDatos(int posicion, int codigo, string nombre, string direccion, string correo, int telefono)
        {
            this.pos = posicion;
            LbCodigoCliente.Text = codigo.ToString();
            TxtNombreCliente.Text = nombre;
            TxtDireccionCliente.Text = direccion;
            TxtEmailCliente.Text = correo;
            TxtTelefonoCliente.Text = telefono.ToString();
        }

        
    }
}
