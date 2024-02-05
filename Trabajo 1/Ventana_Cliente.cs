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
        public int casoEscogido;
        public Ventana_Cliente(int Caso)
        {
            InitializeComponent();
            this.casoEscogido = Caso;
        }

        private void Ventana_Cliente_Load(object sender, EventArgs e)
        {
            if(casoEscogido == 0)
            {
                BtnConfirmarCliente.Visible = false;
            }
        }

        private void Ventana_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(casoEscogido == 0)
            {
                Form1 ventanaPrincipal = new Form1();
                ventanaPrincipal.Show();                
            }
            if(casoEscogido == 1)
            {
                Ventana_IniciarPedido iniciarPedido = new Ventana_IniciarPedido();
                iniciarPedido.Show();
            }
            this.Dispose();
        }

        private void BtnConfirmarCliente_Click(object sender, EventArgs e)
        {
            Ventana_OrdenarPedido ordenarPedido = new Ventana_OrdenarPedido();
            ordenarPedido.Show();
            this.Dispose();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            Ventana_EditarCliente editarCliente = new Ventana_EditarCliente(2);
            editarCliente.Show();
            this.Dispose();
        }


    }
}
