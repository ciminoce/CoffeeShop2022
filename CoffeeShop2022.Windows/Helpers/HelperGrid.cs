using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Windows.Clases;

namespace CoffeeShop2022.Windows.Classes
{
    public static class HelperGrid
    {
        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }
        public static void AgregarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Add(r);
        }
        public static void LimpiarGrilla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dataGridView)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridView);
            return r;

        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case TipoProducto tp:
                    r.Cells[0].Value = tp.Descripcion;
                    break;
                case Producto p:
                    r.Cells[0].Value = p.Descripcion;
                    r.Cells[1].Value = p.TipoProducto.Descripcion;
                    r.Cells[2].Value = p.PrecioVenta.ToString("C");
                    r.Cells[3].Value = p.Stock;
                    break;
                case ItemCarrito item:
                    r.Cells[0].Value = item.Descripcion;
                    r.Cells[1].Value = item.Precio;
                    r.Cells[2].Value = item.Cantidad;
                    r.Cells[3].Value = item.SubTotal.ToString("C");
                    break;
                case Venta venta:
                    r.Cells[0].Value = venta.VentaId;
                    r.Cells[1].Value = venta.FechaVenta.ToShortDateString();
                    r.Cells[2].Value = venta.Total.ToString("C");
                    r.Cells[3].Value = venta.Estado.ToString();
                    break;
                case DetalleVenta dt:
                    r.Cells[0].Value = dt.Producto.Descripcion;
                    r.Cells[1].Value = dt.PrecioVenta;
                    r.Cells[2].Value = dt.Cantidad;
                    r.Cells[3].Value = dt.Cantidad*dt.PrecioVenta;
                    break;

            }

            r.Tag = obj;

        }
    }
}
