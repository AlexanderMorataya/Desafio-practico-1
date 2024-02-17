using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1
{
    //CLASE PARA COMPARTIR LA INSTANCIA/OBJETO DE LA LISTA CLIENTE
    public static class UCP
    {
        public static Cola_Pedidos cola_Pedidos { get; set; } = new Cola_Pedidos();
    }
    //CLASE NODO QUE ALMACENARA LOS DATOS DE CADA PEDIDO
    public class NodoPed
    {
        public Pedido pedido;
        public NodoPed siguiente;
        public NodoPed(Pedido valor)
        {
            pedido = valor;
            siguiente = null;
        }
    }
    //CLASE QUE ALMACENARA A TODOS LOS PEDIDOS
    public class Cola_Pedidos
    {
        NodoPed primero;
        NodoPed ultimo;
        int totnodos;
        public Cola_Pedidos()
        {
            primero = ultimo = null;
            totnodos = 0;
        }

        //METODOS UTILIZADOS PARA MANIPULAR LA COLA PEDIDOS
        //Metodo que revisa si la cola esta vacia
        public bool ColaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Metodo que ingresa un pedido a la cola
        public void IngresarPedido(Pedido item)
        {
            NodoPed auxiliar = new NodoPed(item);
            if (ColaVacia())
            {
                auxiliar.pedido.CodigoPedido = 1;
                primero = ultimo = auxiliar;
            }
            else
            {
                auxiliar.pedido.CodigoPedido = ultimo.pedido.CodigoPedido + 1;
                ultimo.siguiente = auxiliar;
                ultimo = auxiliar;
            }
            totnodos++;
        }
        //Metodo que saca al pedido que se encuentra el la primera posicion
        public void SacarPedido()
        {
            if (!ColaVacia())
            {
                primero = primero.siguiente;
                totnodos--;
            }
        }
        //Metodo que saca al pedido que se encuentra el la primera posicion
        public NodoPed DevolverPrimerPedido()
        {
            NodoPed auxiliar;
            if (!ColaVacia())
            {
                auxiliar = primero;
            }
            else
            {
                auxiliar = null;
            }
            return auxiliar;
        }
        //Metodo pra imprimir los datos de la cola Pedidos
        public DataTable informacionPedidos()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Codigo de pedido", typeof(int));
            dataTable.Columns.Add("Codigo de cliente", typeof(int));
            dataTable.Columns.Add("Precio", typeof(double));
            dataTable.Columns.Add("Iva", typeof(double));
            dataTable.Columns.Add("Precio total", typeof(double));
            dataTable.Columns.Add("Fecha", typeof(DateTime));

            NodoPed puntero = primero;
            while (puntero != null)
            {
                Pedido pedido = puntero.pedido;
                dataTable.Rows.Add(pedido.CodigoPedido, pedido.CodigoCliente, pedido.PrecioTotal, pedido.Iva, pedido.PrecioFinal, pedido.FechaPedido);
                puntero = puntero.siguiente;
            }
            return dataTable;
        }
    }
}
