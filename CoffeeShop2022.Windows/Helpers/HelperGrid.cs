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
                    r.Cells[0].Value = ((TipoProducto) obj).Descripcion;
                    break;
                case Producto p:
                    r.Cells[0].Value = ((Producto)obj).Descripcion;
                    r.Cells[1].Value = ((Producto)obj).TipoProducto.Descripcion;
                    r.Cells[2].Value = ((Producto)obj).PrecioVenta.ToString("C");
                    r.Cells[3].Value = ((Producto)obj).Stock;
                    break;
                case ItemCarrito item:
                    r.Cells[0].Value = ((ItemCarrito)obj).Descripcion;
                    r.Cells[1].Value = ((ItemCarrito)obj).Precio;
                    r.Cells[2].Value = ((ItemCarrito)obj).Cantidad;
                    r.Cells[3].Value = ((ItemCarrito)obj).SubTotal.ToString("C");
                    break;
                case Venta venta:
                    r.Cells[0].Value = ((Venta)obj).VentaId;
                    r.Cells[1].Value = ((Venta)obj).FechaVenta.ToShortDateString();
                    r.Cells[2].Value = ((Venta)obj).Total.ToString("C");
                    break;

            }

            r.Tag = obj;

        }
    }
}
