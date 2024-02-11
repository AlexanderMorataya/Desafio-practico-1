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

        //PROGRAMACION DE BOTONES
        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //PROGRAMACION DE EVENTOS
        private void Ventana_EditarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 ventanaPrincipal = new Form1();
            ventanaPrincipal.Show();                                                  
        }

        
    }
}
