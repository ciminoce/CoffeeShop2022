using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Servicios.Servicios.Facades;
using CoffeeShop2022.Windows.Classes;

namespace CoffeeShop2022.Windows
{
    public partial class frmProductosPorTipo : Form
    {
        public frmProductosPorTipo(IServicioTipoProducto servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private IServicioTipoProducto servicio;
        private List<IGrouping<int, Producto>> lista;
        public void SetLista(List<IGrouping<int, Producto>> lista)
        {
            this.lista = lista;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            foreach (var grupo in lista)
            {
                var r = HelperGrid.ConstruirFila(DetalleDataGridView);
                SetearFila(r, grupo);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            DetalleDataGridView.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, IGrouping<int, Producto> grupo)
        {
            var tipo=servicio.GetTipoPorId(grupo.Key);
            r.Cells[colTipo.Index].Value = tipo.Descripcion;
            r.Cells[colCantidad.Index].Value = grupo.Count();
        }
    }
}
