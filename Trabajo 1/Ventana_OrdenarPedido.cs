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
    public partial class Ventana_OrdenarPedido : Form
    {
        //Objetos de la cola productos 
        Cola_Productos Prod_por_Defecto = new Cola_Productos(); //Uno para los productos de la tienda por defecto
        Cola_Productos Productos = new Cola_Productos(); //Uno para guardar la lista de productos que el cliente quiere en su pedido

        //Campos utilizados en el programa
        private int codigoCliente, codigoProducto;
        private string nombreCliente, descripcion;
        double precio, Suma, Iva, Total;

        //PROGRAMACION DE INICIALIZACION DEL PROGRAMA
        public Ventana_OrdenarPedido()
        {
            InitializeComponent();
        }
        private void Ventana_OrdenarPedido_Load(object sender, EventArgs e)
        {
            CargarProductos();
            LbCodigoCliente.Text = codigoCliente.ToString();
            LbNombreCliente.Text = nombreCliente;
        }

        //PROGRAMACION DE BOTONES
        //Combo box que se accione cada vez que el usario seleccione un producto
        private void CbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto producto = Prod_por_Defecto.ObtenerProducto(CbProductos.Text);

            precio = producto.PrecioUnidad;
            codigoProducto = producto.CodigoProducto;
            descripcion = producto.Descripcion;

            LbPrecioProducto.Text = "$" + precio.ToString();
            LbDescripcionProducto.Text = descripcion;
        }
        //Combo box que se accionara cada vez que el usuario asigne las unidades del producto que escogio
        private void CbUnidades_ValueChanged(object sender, EventArgs e)
        {
            LbPrecioProducto.Text = "$" + (precio * (int)CbUnidades.Value).ToString();
        }
        //Boton que ingresara los datos del producto que el usario decide ingresar el pedido
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.CodigoProducto = codigoProducto;
            producto.NombreProducto = CbProductos.SelectedItem.ToString();
            producto.Unidades = (int)CbUnidades.Value;
            producto.PrecioUnidad = Math.Round(precio * (int)CbUnidades.Value, 2);
            producto.Descripcion = descripcion;

            Productos.InsertarF(producto);
            ImprimirProductos();
        }
        //Boton para sacar el ultimo producto que se encuentra en cola
        private void BtnElimarProducto_Click(object sender, EventArgs e)
        {
            Productos.EliminarF();
            ImprimirProductos();
        }
        //Boton para ingresar todos los datos del pedido
        private void BtnConfirmarPedido_Click(object sender, EventArgs e)
        {
            if (Productos.ColaVacia())
            {
                MessageBox.Show("Debe escoger al menos un producto para realizar un pedido");
            }
            else
            {
                Pedido pedido = new Pedido();
                pedido.CodigoCliente = codigoCliente;
                pedido.Cola_Productos = Productos;
                pedido.PrecioTotal = Math.Round(Suma, 2);
                pedido.Iva = Math.Round(Iva, 2);
                pedido.PrecioFinal = Math.Round(Total,2);
                pedido.FechaPedido = DateTime.Now;

                UCP.cola_Pedidos.IngresarPedido(pedido);

                MessageBox.Show("Su pedido a sido guardado exitosamente");
                this.Close();
            }
        }

        //PROGRAMACION DE EVENTOS
        private void Ventana_OrdenarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 ventanaInicial = new Form1();
            ventanaInicial.Show();
        }

        //METODOS UTILIZADOS POR EL PROGRAMA
        //Metodo para cargar los combo box con los datos de los productos disponibles en la tienda
        private void CargarProductos()
        {
            Producto producto1 = new Producto { CodigoProducto = 1, NombreProducto = "Smartphone Samsung Galaxy S22", Unidades = 1, Descripcion = "Potente smartphone con cámara de alta resolución y rendimiento excepcional.", PrecioUnidad = 899.99 };
            Prod_por_Defecto.InsertarF(producto1);
            Producto producto2 = new Producto { CodigoProducto = 2, NombreProducto = "Laptop Lenovo ThinkPad X1 Carbon", Unidades = 1, Descripcion = "Laptop ultradelgada y ultraligera con pantalla táctil de alta resolución y procesador de última generación.", PrecioUnidad = 1499.99 };
            Prod_por_Defecto.InsertarF(producto2);
            Producto producto3 = new Producto { CodigoProducto = 3, NombreProducto = "TV Samsung QLED 4K 65 pulgadas", Unidades = 1, Descripcion = "Televisor QLED con resolución 4K, tecnología HDR y sistema de sonido envolvente.", PrecioUnidad = 1299.99 };
            Prod_por_Defecto.InsertarF(producto3);
            Producto producto4 = new Producto { CodigoProducto = 4, NombreProducto = "Cámara Canon EOS R5", Unidades = 1, Descripcion = "Cámara mirrorless de alta gama con sensor de imagen de alta resolución y grabación de video 8K.", PrecioUnidad = 3499.99 };
            Prod_por_Defecto.InsertarF(producto4);
            Producto producto5 = new Producto { CodigoProducto = 5, NombreProducto = "Tablet Apple iPad Pro", Unidades = 1, Descripcion = "Tablet con pantalla Liquid Retina, potente chip M1 y compatibilidad con Apple Pencil y Magic Keyboard.", PrecioUnidad = 999.99 };
            Prod_por_Defecto.InsertarF(producto5);
            Producto producto6 = new Producto { CodigoProducto = 6, NombreProducto = "Auriculares Sony WH-1000XM4", Unidades = 1, Descripcion = "Auriculares inalámbricos con cancelación de ruido y calidad de sonido excepcional.", PrecioUnidad = 349.99 };
            Prod_por_Defecto.InsertarF(producto6);

            Prod_por_Defecto.LlenarComboBox(CbProductos);
            CbProductos.SelectedIndex = 0;
            CbUnidades.Value = 1;
        }
        //Metodo para imprimir la lista
        private void ImprimirProductos()
        {
            DgvProductosOrdenados.DataSource = null;
            DgvProductosOrdenados.DataSource = Productos.informacionProductos();

            Suma = Productos.PrecioTotalProductos();
            Iva = Math.Round(Productos.PrecioTotalProductos() * 0.13, 2);
            Total = Suma + Iva;

            LbSumaTotal.Text = "$" + Suma.ToString();
            lbIva.Text = "$" + Iva.ToString();
            LbPagoTotal.Text = "$" + Total.ToString();
        }
        //Metodos para cargar los datos del cliente
        public void SetDatos(int cod, string nom)
        {
            this.codigoCliente = cod;
            this.nombreCliente = nom;
        }
    }


}
