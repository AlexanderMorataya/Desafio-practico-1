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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            Ventana_FacturarPedido facturarPedido = new Ventana_FacturarPedido();
            facturarPedido.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
