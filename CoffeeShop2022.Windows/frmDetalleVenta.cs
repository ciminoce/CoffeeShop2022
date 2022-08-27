using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Windows.Classes;

namespace CoffeeShop2022.Windows
{
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private Venta venta;
        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetVenta(Venta venta)
        {
            this.venta = venta;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (venta!=null)
            {
                MostrarVenta();
            }
        }

        private void MostrarVenta()
        {
            VentaLabel.Text = venta.VentaId.ToString();
            FechaLabel.Text = venta.FechaVenta.ToShortDateString();
            EstadoLabel.Text = venta.Estado.ToString();
            foreach (var detalle in venta.DetalleVentas)
            {
                var r = HelperGrid.ConstruirFila(CarritoDataGridView);
                HelperGrid.SetearFila(r,detalle);
                HelperGrid.AgregarFila(CarritoDataGridView,r);
            }

            CantidadLabel.Text = venta.DetalleVentas.Sum(dt => dt.Cantidad).ToString();
            TotalLabel.Text = venta.Total.ToString();
        }
    }
}
