using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Entidades.Enum;
using CoffeeShop2022.Servicios.Servicios.Facades;
using CoffeeShop2022.Windows.Classes;
using CoffeeShop2022.Windows.Helpers;
using CoffeeShop2022.Windows.Ninject;

namespace CoffeeShop2022.Windows
{
    public partial class frmVentas : Form
    {
        public frmVentas(IServicioVentas servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private IServicioVentas servicio;
        private List<Venta> lista;
        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmVentasAE frm = new frmVentasAE(DI.Create<IServicioProductos>()) {Text = "Nueva Venta"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Venta venta = frm.GetVenta();
                servicio.Guardar(venta);
                var r = HelperGrid.ConstruirFila(DatosDataGridView);
                HelperGrid.SetearFila(r,venta);
                HelperGrid.AgregarFila(DatosDataGridView,r);
                HelperMensaje.Mensaje(TipoMensaje.OK, "Venta Registrada", "Mensaje");

            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            //servicio=new ServicioVentas();
            try
            {
                lista = servicio.GetVentas();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView,lista);
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void AnularIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            var venta = (Venta)r.Tag;
            if (venta.Estado==EstadoVenta.Anulada || venta.Estado==EstadoVenta.Pagada)
            {
                return;
            }

            try
            {
                venta.Estado = EstadoVenta.Anulada;
                servicio.CambiarEstado(venta);
                HelperGrid.SetearFila(r,venta);
                HelperMensaje.Mensaje(TipoMensaje.OK, "Venta anulada!!!", "Mensaje");
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void DetalleIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            var venta = (Venta)r.Tag;
            try
            {
                venta.DetalleVentas = servicio.GetDetalleVenta(venta.VentaId);
                frmDetalleVenta frm = new frmDetalleVenta() { Text = "Detalle de la Venta" };
                frm.SetVenta(venta);
                frm.ShowDialog(this);
            }
            catch(Exception ex)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }

        private void CobrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            var venta = (Venta)r.Tag;
            frmCobro frm = new frmCobro() { Text = "Seleccionar método de cobro" };
            frm.SetMonto(venta.Total);
            DialogResult dr = frm.ShowDialog(this);
            try
            {
                venta.Estado = EstadoVenta.Pagada;
                servicio.CambiarEstado(venta);
                HelperGrid.SetearFila(r,venta);
                HelperMensaje.Mensaje(TipoMensaje.OK, "Venta Pagada!!!", "Mensaje");
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }

        }
    }
}
