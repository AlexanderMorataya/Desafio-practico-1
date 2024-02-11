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
    public partial class Ventana_OrdenarPedido : Form
    {
        public Ventana_OrdenarPedido()
        {
            InitializeComponent();
        }

        private void Ventana_OrdenarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 ventanaInicial = new Form1();
            ventanaInicial.Show();
        }
    }
}
