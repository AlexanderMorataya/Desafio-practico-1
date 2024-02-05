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
        public int casoEscogido;
        public Ventana_EditarCliente(int Caso)
        {
            InitializeComponent();
            this.casoEscogido = Caso;
        }

        private void Ventana_EditarCliente_Load(object sender, EventArgs e)
        {
            if(casoEscogido == 0)
            {
                BtnEliminarCliente.Visible = false;
            }            
        }

        private void Ventana_EditarCliente_FormClosed(object sender, FormClosedEventArgs e)
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
            if(casoEscogido == 2)
            {
                Ventana_Cliente confirmarCliente = new Ventana_Cliente(0);
                confirmarCliente.Show();
            }
            if(casoEscogido == 3)
            {
                Ventana_OrdenarPedido ordenarPedido = new Ventana_OrdenarPedido();
                ordenarPedido.Show();
            }
            this.Dispose();
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if(casoEscogido == 1)
            {
                casoEscogido = 3;                
            }
            this.Close();
        }
        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
