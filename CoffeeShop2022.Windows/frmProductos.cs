using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Entidades.Enum;
using CoffeeShop2022.Servicios.Servicios;
using CoffeeShop2022.Servicios.Servicios.Facades;
using CoffeeShop2022.Windows.Classes;
using CoffeeShop2022.Windows.Helpers;
using FontAwesome.Sharp;

namespace CoffeeShop2022.Windows
{
    public partial class frmProductos : Form
    {
        private IconButton botonOrdenActual;
        public frmProductos(IServicioProductos servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
        }
        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IServicioProductos servicio;
        private List<Producto> lista;
        private void frmProductos_Load(object sender, EventArgs e)
        {
            //servicio=new ServicioProductos();
            RecargarGrilla(Orden.BD);
        }

        private void RecargarGrilla(Orden orden)
        {
            try
            {
                lista = servicio.GetLista(null,orden);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                //MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }


        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmProductoAE frm=new frmProductoAE(){Text = "Agregar Producto"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Producto producto = frm.GetProducto();
                if (!servicio.Existe(producto))
                {
                    servicio.Guardar(producto);
                    RecargarGrilla(Orden.BD);
                    //DataGridViewRow r = HelperGrid.ConstruirFila(DatosDataGridView);
                    //HelperGrid.SetearFila(r, producto);
                    //HelperGrid.AgregarFila(DatosDataGridView, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK,"Registro agregado", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro repetido!!", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Producto p = (Producto) r.Tag;
            DialogResult dr = HelperMensaje.Mensaje($"¿Desea borrar el producto {p.Descripcion}?",
                "Confirmar Borrado");
            if (dr==DialogResult.No)
            {
                return;
            }

            try
            {
                if (!servicio.EstaRelacionado(p))
                {
                    servicio.Borrar(p.ProductoId);
                    HelperGrid.BorrarFila(DatosDataGridView,r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Registro eliminado",
                        "Mensaje");
                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Registro relacionado"+Environment.NewLine+"Baja denegada!!!",
                        "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message,
                    "Error");
            }
        }

        private void FiltrariconButton_Click(object sender, EventArgs e)
        {
            if (FiltrariconButton.BackColor==Color.Transparent)
            {
                frmBuscarPorTipoDeProducto frm = new frmBuscarPorTipoDeProducto() { Text = "Seleccione un tipo de producto" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    TipoProducto tp = frm.GetTipo();
                    lista = servicio.GetLista(tp,Orden.BD);
                    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                    FiltrariconButton.BackColor = Color.OrangeRed;
                }
                catch (Exception exception)
                {
                    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
                }

            }
            else
            {
                lista = servicio.GetLista(null,Orden.BD);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView,lista);
                FiltrariconButton.BackColor = Color.Transparent;
            }
        }

        private void OredenarAZPorProductoiconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual!=(IconButton)sender)
            {
                RecargarGrilla(Orden.AZ);
            }
            else
            {
                RecargarGrilla(Orden.BD);
            }
            ManejarColorBotonOrden((IconButton)sender);
            //try
            //{
            //    lista = servicio.GetLista(null, Orden.AZ);
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView,lista);
            //}
            //catch (Exception exception)
            //{
            //    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}
        }

        private void ManejarColorBotonOrden(IconButton sender)
        {
            if (botonOrdenActual==null)
            {
                botonOrdenActual = sender;
                botonOrdenActual.BackColor = Color.OrangeRed;
            }
            else
            {
                if (botonOrdenActual==sender)
                {
                    botonOrdenActual = null;
                    sender.BackColor = Color.Transparent;
                }
                else
                {
                    botonOrdenActual.BackColor = Color.Transparent;
                    botonOrdenActual = sender;
                    botonOrdenActual.BackColor = Color.OrangeRed;
                }
            }
        }

        private void OrdenarZAPorProductoiconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual!=(IconButton)sender)
            {
                RecargarGrilla(Orden.ZA);

            }
            else
            {
                RecargarGrilla(Orden.BD);
            }
            ManejarColorBotonOrden((IconButton)sender);
            //try
            //{
            //    lista = servicio.GetLista(null, Orden.ZA);
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //}
            //catch (Exception exception)
            //{
            //    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}

        }

        private void OrdenarPrecioAsciIconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual!=(IconButton)sender)
            {
                RecargarGrilla(Orden.ASC);

            }
            else
            {
                RecargarGrilla(Orden.BD);
            }

            ManejarColorBotonOrden((IconButton)sender);


            //try
            //{
            //    lista = servicio.GetLista(null, Orden.ASC);
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //}
            //catch (Exception exception)
            //{
            //    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}

        }

        private void PrecioDescIconButton_Click(object sender, EventArgs e)
        {
            if (botonOrdenActual!=(IconButton)sender)
            {
                RecargarGrilla(Orden.DESC);

            }
            else
            {
                RecargarGrilla(Orden.BD);
            }

            ManejarColorBotonOrden((IconButton)sender);


            //try
            //{
            //    lista = servicio.GetLista(null, Orden.DESC);
            //    HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //}
            //catch (Exception exception)
            //{
            //    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}

        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }
            var r = DatosDataGridView.SelectedRows[0];
            Producto p = (Producto) r.Tag;
            Producto pAuxiliar =(Producto) p.Clone();

            try
            {
                frmProductoAE frm = new frmProductoAE() {Text = "Editar un Producto"};
                frm.SetProducto(p);
                DialogResult dr = frm.ShowDialog(this);
                if (dr==DialogResult.Cancel)
                {
                    return;
                }

                p = frm.GetProducto();
                if (!servicio.Existe(p))
                {
                    servicio.Guardar(p);
                    HelperGrid.SetearFila(r,p);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Producto editado", "Mensaje");
                }
                else
                {
                    HelperGrid.SetearFila(r,pAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.Error, "Producto existente..", "Error");
                }

            }
            catch (Exception exception)
            {
                HelperGrid.SetearFila(r, pAuxiliar);

                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }
    }
}
