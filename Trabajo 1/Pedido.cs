using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1
{
    public class Pedido
    {
        int codigoPedido;
        public int CodigoPedido
        {
            get { return codigoPedido; }
            set { codigoPedido = value; }
        }

        int codigoCliente;
        public int CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

        Cola_Productos colaProducto;
        public Cola_Productos Cola_Productos
        {
            get { return colaProducto; }
            set { colaProducto = value; } 
        }

        double precioTotal;
        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }

        double iva;
        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        double precioFinal;
        public double PrecioFinal
        {
            get { return precioFinal; }
            set { precioFinal = value; }
        }

        DateTime fechaPedido;
        public DateTime FechaPedido
        {
            get { return fechaPedido; }
            set { fechaPedido = value; }
        }
    }
}
