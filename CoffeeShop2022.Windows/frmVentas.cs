using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Servicios.Servicios;
using CoffeeShop2022.Servicios.Servicios.Facades;
using CoffeeShop2022.Windows.Classes;
using CoffeeShop2022.Windows.Helpers;

namespace CoffeeShop2022.Windows
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private IServicioVentas servicio;
        private List<Venta> lista;
        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmVentasAE frm = new frmVentasAE() {Text = "Nueva Venta"};
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
            servicio=new ServicioVentas();
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
    }
}
