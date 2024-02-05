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
    public partial class Ventana_IniciarPedido : Form
    {
        public Ventana_IniciarPedido()
        {
            InitializeComponent();
        }

        private void Ventana_IniciarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {            
            Form1 ventanaPrincipal = new Form1();
            ventanaPrincipal.Show();
            this.Dispose();
        }

        private void BtnCodigoCliente_Click(object sender, EventArgs e)
        {
            Ventana_Cliente buscarCliente = new Ventana_Cliente(1);
            buscarCliente.Show();
            this.Dispose();
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            Ventana_EditarCliente crearCliente = new Ventana_EditarCliente(1);
            crearCliente.Show();
            this.Dispose();
        }
    }
}
