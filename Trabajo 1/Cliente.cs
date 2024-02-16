using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1
{
    public class Cliente
    {
        int codigoCliente;
        public int CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

        string nombreCliente;
        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        string direccion;
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        int telefono;
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
    }
}
