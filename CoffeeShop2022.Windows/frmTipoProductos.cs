using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Servicios.Servicios;
using CoffeeShop2022.Servicios.Servicios.Facades;
using CoffeeShop2022.Windows.Classes;
using CoffeeShop2022.Windows.Helpers;
using CoffeeShop2022.Windows.Ninject;

namespace CoffeeShop2022.Windows
{
    public partial class frmTipoProductos : Form
    {
        public frmTipoProductos(IServicioTipoProducto servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }

        private IServicioTipoProducto servicio;
        private List<TipoProducto> lista;
        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTipoProductos_Load(object sender, EventArgs e)
        {
            //servicio=new ServicioTipoProductos();
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView,lista);
            }
            catch (Exception exception)
            {
                throw new Exception( exception.Message);
            }
        }

        //private void MostrarDatosEnGrilla()
        //{
        //    //DatosDataGridView.Rows.Clear();
        //    HelperGrid.LimpiarGrilla(DatosDataGridView);
        //    foreach (var tipoProducto in lista)
        //    {
        //        //var r = ConstruirFila();
        //        var r = HelperGrid.ConstruirFila(DatosDataGridView);
        //        HelperGrid.SetearFila(r, tipoProducto);
        //        HelperGrid.AgregarFila(DatosDataGridView,r);
        //    }
        //}

        //private void SetearFila(DataGridViewRow r, TipoProducto tipoProducto)
        //{
        //    r.Cells[colTipo.Index].Value = tipoProducto.Descripcion;

        //    r.Tag = tipoProducto;
        //}

        //private DataGridViewRow ConstruirFila()
        //{
        //    var r=new DataGridViewRow();
        //    r.CreateCells(DatosDataGridView);
        //    return r;
        //}

        //private void AgregarFila(DataGridViewRow r)
        //{
        //    DatosDataGridView.Rows.Add(r);
        //}

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmTipoProductoAE frm = new frmTipoProductoAE() {Text = "Agregar tipo de producto"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                TipoProducto t = frm.GetTipo();

                if (!servicio.Existe(t))
                {
                    servicio.Guardar(t);
                    //var r = ConstruirFila();
                    var r = HelperGrid.ConstruirFila(DatosDataGridView);
                    HelperGrid.SetearFila(r, t);
                    HelperGrid.AgregarFila(DatosDataGridView,r);
                    //MessageBox.Show("Registro agregado", "Mensaje",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HelperMensaje.Mensaje(TipoMensaje.OK,"Registro agregado","Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro existente!!!", "Error");
                      
                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            TipoProducto t = (TipoProducto) r.Tag;
            TipoProducto tAuxiliar =(TipoProducto) t.Clone();
            frmTipoProductoAE frm = new frmTipoProductoAE() {Text = "Editar tipo de Producto"};
            frm.SetTipo(t);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                t = frm.GetTipo();
                if (!servicio.Existe(t))
                {
                    servicio.Guardar(t);
                    HelperGrid.SetearFila(r, t);
                    MessageBox.Show("Registro modificado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    HelperGrid.SetearFila(r,tAuxiliar);
                    MessageBox.Show("Registro existente!!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r,tAuxiliar);
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            try
            {
                var r = DatosDataGridView.SelectedRows[0];
                TipoProducto t = (TipoProducto) r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr==DialogResult.No)
                {
                    return;
                }
                if (!servicio.EstaRelacionado(t))
                {
                    servicio.Borrar(t.TipoProductoId);
                    //DatosDataGridView.Rows.Remove(r);
                    HelperGrid.BorrarFila(DatosDataGridView,r);
                    HelperMensaje.Mensaje(TipoMensaje.OK,"Registro Borrado!!!","Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error,"Registro relacionado..."+Environment.NewLine+
                        "Baja Denegada", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");

            }
        }

        private void ConsultaIconButton_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = servicio.GetProductosPorTipo();
                frmProductosPorTipo frm = new frmProductosPorTipo(DI.Create<IServicioTipoProducto>()) { Text = "Cantidad por Tipo" };
                frm.SetLista(lista);
                frm.ShowDialog(this);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
