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
        //PROGRAMACION DE INICIALIZACION DEL PROGRAMA
        public int casoEscogido;
        public Ventana_IniciarPedido()
        {
            InitializeComponent();
            casoEscogido = 0;
        }
        
        //PROGRAMACION DE BOTONES
        private void BtnCodigoCliente_Click(object sender, EventArgs e)
        {
            casoEscogido = 1;
            this.Close();
        }
        //PROGRAMACION DE EVENTOS
        private void Ventana_IniciarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(casoEscogido == 0)
            {
                Form1 ventanaPrincipal = new Form1();
                ventanaPrincipal.Show();
            }
            if(casoEscogido == 1)
            {
                Ventana_Cliente buscarCliente = new Ventana_Cliente(1);
                buscarCliente.Show();
            }
        }
    }
}
