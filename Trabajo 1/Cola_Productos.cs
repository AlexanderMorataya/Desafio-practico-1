using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_1
{
    //CLASE NODO QUE ALMACENARA LOS DATOS DE CADA PRODUCTO
    public class NodoPro
    {
        public Producto producto;
        public NodoPro siguiente;
        public NodoPro(Producto valor)
        {
            producto = valor;
            siguiente = null;
        }
    }

    //CLASE QUE ALMACENARA A TODOS LOS PRODUCTOS
    public class Cola_Productos
    {
        NodoPro inicio;
        public Cola_Productos()
        {
            inicio = null;
        }

        //METODOS UTILIZADOS PARA MANIPULAR LA COLA PRODUCTOS
        //Metodo para insertar producto al final de la cola
        public void InsertarF(Producto item)
        {
            NodoPro auxiliar = new NodoPro(item);
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                NodoPro puntero;
                puntero = inicio;

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
        }
        //Metodo para eliminar producto al final de la cola
        public void EliminarF()
        {
            NodoPro productoAnt;
            NodoPro productoPost;

            if (inicio == null)
            {
                MessageBox.Show("En esto momento no hay productos almacenados");
            }
            else
            {
                productoAnt = inicio;
                productoPost = inicio;

                while (productoPost.siguiente != null)
                {
                    productoAnt = productoPost;
                    productoPost = productoPost.siguiente;
                }

                if (productoAnt == productoPost)
                {
                    inicio = null;
                }
                else
                {
                    productoAnt.siguiente = null;
                }
            }
        }
        //Metodo para mostrar la lista de clientes
        public DataTable informacionProductos()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Codigo de producto", typeof(int));
            dataTable.Columns.Add("Producto", typeof(string));
            dataTable.Columns.Add("Unidades", typeof(int));
            dataTable.Columns.Add("Precio por unidad", typeof(double));
            dataTable.Columns.Add("Descripcion", typeof(string));

            NodoPro puntero = inicio;
            while (puntero != null)
            {
                Producto producto = puntero.producto;
                dataTable.Rows.Add(producto.CodigoProducto, producto.NombreProducto, producto.Unidades, producto.PrecioUnidad, producto.Descripcion);
                puntero = puntero.siguiente;
            }

            return dataTable;
        }
        //Metodo para los combo box con la informacion de los productos de la tienda
        public void LlenarComboBox(ComboBox comboBox)
        {
            NodoPro actual = inicio;
            while (actual != null)
            {
                comboBox.Items.Add(actual.producto.NombreProducto);
                actual = actual.siguiente;
            }
        }
        //Metodo para obtener los productos a traves de su nombre
        public Producto ObtenerProducto(string nombre)
        {
            NodoPro actual = inicio;
            while (actual != null)
            {
                if (actual.producto.NombreProducto == nombre)
                {
                    return actual.producto;
                }
                actual = actual.siguiente;
            }
            return null;
        }
        //Metodo para sumar la cantidad a pagar por todos los productos en la lista
        public double PrecioTotalProductos()
        {
            double total = 0;
            NodoPro actual = inicio;
            while (actual != null)
            {
                total += actual.producto.PrecioUnidad;
                actual = actual.siguiente;
            }
            return total;
        }
        //Metodo para revisar si la cola productos esta vacia
        public bool ColaVacia()
        {
            return inicio == null;
        }
    }


}
