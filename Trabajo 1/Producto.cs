using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1
{
    public class Producto
    {
        int codigoProducto;
        public int CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }

        string nombreProducto;
        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }

        int unidades;
        public int Unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }

        double precioUnidad;
        public double PrecioUnidad
        {
            get { return precioUnidad; }
            set { precioUnidad = value; }
        }

        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
