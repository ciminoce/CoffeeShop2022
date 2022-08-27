using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoffeeShop2022.Datos.Repositorios.Facades;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Entidades.Enum;
using CoffeeShop2022.Servicios.Servicios;
using CoffeeShop2022.Servicios.Servicios.Facades;
using CoffeeShop2022.Windows.Clases;
using CoffeeShop2022.Windows.Classes;
using CoffeeShop2022.Windows.Helpers;
using CoffeeShop2022.Windows.UserControls;

namespace CoffeeShop2022.Windows
{
    public partial class frmVentasAE : Form
    {
        public frmVentasAE(IServicioProductos servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }


        private IServicioProductos servicio;
        private List<Producto> lista;
        private void frmVentasAE_Load(object sender, EventArgs e)
        {
            //servicio=new ServicioProductos();
            
            HelperCombos.CargarDatosComboTipos(ref TipoProductosComboBox);
            lista = servicio.GetLista(null, Orden.BD);
            MostrarListaEnLayout();
        }

        private void MostrarListaEnLayout()
        {
            ProductosFlowLayoutPanel.Controls.Clear();
            foreach (var producto in lista)
            {
                ucProducto ucProducto = new ucProducto
                {
                    ProductoId = producto.ProductoId,
                    Descripcion = producto.Descripcion,
                    Precio = producto.PrecioVenta.ToString("C"),
                    Imagen = producto.Imagen,
                    
                };
                ucProducto.AgregarIconButton.Tag = ucProducto.ProductoId;
                ucProducto.AgregarIconButton.Click += AgregarProducto;
                ProductosFlowLayoutPanel.Controls.Add(ucProducto);

            }
        }

        private void AgregarProducto(object sender, EventArgs e)
        {
            var productoId=(int)((Button) sender).Tag;
            var producto = servicio.GetProductoPorId(productoId);

            ItemCarrito item = new ItemCarrito()
            {
                ProductoId = producto.ProductoId,
                Descripcion = producto.Descripcion,
                Precio = producto.PrecioVenta,
                Cantidad = 1
            };

            Carrito.GetInstancia().Agregar(item);
            HelperForm.MostrarDatosEnGrilla(CarritoDataGridView, Carrito.GetInstancia().listaItems);
            ActualizarTotales(Carrito.GetInstancia().GetCantidad(),
                Carrito.GetInstancia().GetTotal());
        }

        private void ActualizarTotales(int cantidad, decimal total)
        {
            CantidadLabel.Text = cantidad.ToString();
            TotalLabel.Text = total.ToString("C");
        }

        private TipoProducto tipoProducto;
        private void TipoProductosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoProductosComboBox.SelectedIndex>0)
            {
                tipoProducto = (TipoProducto) TipoProductosComboBox.SelectedItem;
            }
            else
            {
                tipoProducto = null;
            }

            lista = servicio.GetLista(tipoProducto, Orden.BD);
            MostrarListaEnLayout();
        }

        private void CarritoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var r = CarritoDataGridView.SelectedRows[0];
            var item = (ItemCarrito) r.Tag;
            if (e.ColumnIndex==4)
            {
                Carrito.GetInstancia().Agregar(item);
            }

            if (e.ColumnIndex==5)
            {
                Carrito.GetInstancia().QuitarUno(item);

            }
            HelperForm.MostrarDatosEnGrilla(CarritoDataGridView, Carrito.GetInstancia().listaItems);
            ActualizarTotales(Carrito.GetInstancia().GetCantidad(),
                Carrito.GetInstancia().GetTotal());
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = HelperMensaje.Mensaje("¿Desea cancelar la orden?", "Confirmar");
            if (dr==DialogResult.No)
            {
                return;
            }
            Carrito.GetInstancia().VaciarCarrito();
            HelperGrid.LimpiarGrilla(CarritoDataGridView);
            ActualizarTotales(0,0);
        }

        private Venta venta;
        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (Carrito.GetInstancia().GetCantidad()==0)
            {
                return;
            }

            venta = new Venta
            {
                FechaVenta = DateTime.Now,
                Total = Carrito.GetInstancia().GetTotal(),
                Estado = EstadoVenta.Proceso,
                DetalleVentas = ConstruirDetallesVenta(Carrito.GetInstancia().GetItems)
            };
            DialogResult = DialogResult.OK;
        }

        private List<DetalleVenta> ConstruirDetallesVenta(List<ItemCarrito> items)
        {
            var lista=new List<DetalleVenta>();
            foreach (var item in items)
            {
                DetalleVenta dv = ConstruirDetalleVenta(item);
                lista.Add(dv);
            }

            return lista;

        }

        private DetalleVenta ConstruirDetalleVenta(ItemCarrito item)
        {
            return new DetalleVenta
            {
                ProductoId = item.ProductoId,
                PrecioVenta = item.Precio,
                Cantidad = item.Cantidad
            };
        }

        public Venta GetVenta()
        {
            return venta;
        }
    }
}
