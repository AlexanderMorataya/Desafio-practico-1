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
        public Ventana_FacturarPedido()
        {
            InitializeComponent();
        }
        private void Ventana_FacturarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 ventanaPrincipal = new Form1();
            ventanaPrincipal.Show();
        }

        private void BtnEliminarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCompletarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
