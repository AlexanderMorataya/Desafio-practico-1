using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_1    
{
    //CLASE PARA COMPARTIR LA INSTANCIA/OBJETO DE LA LISTA CLIENTE
    public static class ULC
    {
        public static Lista_Clientes lista_Clientes { get; set; } = new Lista_Clientes();
    }

    //CLASE NODO QUE ALMACENARA LOS DATOS DE CADA CLIENTE
    public class Nodo
    {
        public Cliente cliente;
        public Nodo siguiente;
        public Nodo(Cliente valor)
        {
            cliente = valor;
            siguiente = null;
        }
    }

    //CLASE QUE ALMACENARA A TODOS LOS CLIENTES
    public class Lista_Clientes
    {
        public Nodo inicio;
        int totalnodos;
        public Lista_Clientes()
        {
            inicio = null;
        }

        //METODOS UTILIZADOS PARA MANIPULAR LA LISTA CLIENTES
        //Metodo para insertar cliente
        public int InsertarF(Cliente item)
        {
            Nodo auxiliar = new Nodo(item);
            if (inicio == null)
            {
                auxiliar.cliente.CodigoCliente = 1;
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;

                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }

                auxiliar.cliente.CodigoCliente = puntero.cliente.CodigoCliente + 1;
                puntero.siguiente = auxiliar;
            }
            this.totalnodos++;
            return auxiliar.cliente.CodigoCliente;
        }
        //Metodo para eliminar cliente
        public void EliminarP(int pos)
        {
            Nodo clientePos, clienteAnt;

            int i = 1;
            if (pos > 0 && pos <= totalnodos)
            {
                clientePos = inicio;
                clienteAnt = null;

                for (i = 1; i < pos; i++)
                {
                    clienteAnt = clientePos;
                    clientePos = clientePos.siguiente;
                }

                if (pos == 1)
                {
                    inicio = inicio.siguiente;
                }
                else
                {
                    clienteAnt.siguiente = clientePos.siguiente;
                }
                this.totalnodos--;
            }
        }
        //Metodo para modificar cliente
        public void ModificarCliente(int pos, Cliente nuevoCliente)
        {
            Nodo puntero = inicio;
            int posicionActual = 1;

            while (puntero != null && posicionActual != pos)
            {
                puntero = puntero.siguiente;
                posicionActual++;
            }

            if (puntero != null)
            {
                puntero.cliente = nuevoCliente;
            }
        }
        //Metodo para buscar la posicion de un cliente a traves de su codigo
        public int BuscarP(int codigo)
        {
            Nodo puntero;
            puntero = inicio;
            int posicion = 1;
            while (puntero != null)
            {
                if (puntero.cliente.CodigoCliente == codigo)
                {
                    return posicion;
                }
                puntero = puntero.siguiente;
                posicion++;
            }
            return 0;
        }
        //Metodo para buscar los datos de los clientes
        public Cliente buscarCliente(int pos)
        {
            Nodo puntero = inicio;
            int posicionActual = 1;

            while (puntero != null && posicionActual != pos)
            {
                puntero = puntero.siguiente;
                posicionActual++;
            }

            if (puntero != null)
            {
                return puntero.cliente;
            }
            else
            {
                return null;
            }
        }
        //Metodo para mostrar la lista de clientes
        public DataTable informacionClientes()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CodigoCliente", typeof(int));
            dataTable.Columns.Add("NombreCliente", typeof(string));
            dataTable.Columns.Add("Direccion", typeof(string));
            dataTable.Columns.Add("Telefono", typeof(int));
            dataTable.Columns.Add("Correo", typeof(string));

            Nodo puntero = inicio;
            while (puntero != null)
            {
                Cliente cliente = puntero.cliente;
                dataTable.Rows.Add(cliente.CodigoCliente, cliente.NombreCliente, cliente.Direccion, cliente.Telefono, cliente.Correo);
                puntero = puntero.siguiente;
            }

            return dataTable;
        }
    }
}
