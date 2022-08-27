using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Servicios.Servicios;
using CoffeeShop2022.Servicios.Servicios.Facades;
using CoffeeShop2022.Windows.Helpers;

namespace CoffeeShop2022.Windows
{
    public partial class frmProductoAE : Form
    {
        private byte[] miImagen = null;
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imagenes\ImagenNoDisponible.jfif";
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //servicio=new ServicioTipoProductos();
            HelperCombos.CargarDatosComboTipos(ref TipoProductosComboBox);
            if (producto!=null)
            {
                ProductoTextBox.Text = producto.Descripcion;
                PrecioVtaTextBox.Text = producto.PrecioVenta.ToString();
                StockNumericUpDown.Value = producto.Stock;
                TipoProductosComboBox.SelectedValue = producto.TipoProductoId;
                //Si la imagen es distinta de null
                if (producto.Imagen!=null)
                {
                    //Muestro la imagen
                    MemoryStream ms = new MemoryStream(producto.Imagen);
                    Bitmap bmp = new Bitmap(ms);

                    ImagenPictureBox.Image = bmp;
                }
                else
                {
                    ImagenPictureBox.Image = Image.FromFile(imagenNoDisponible);
                }
            }
        }

        public frmProductoAE()
        {
            InitializeComponent();
        }

        private Producto producto;
        public Producto GetProducto()
        {
            return producto;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto==null)
                {
                    producto=new Producto();
                }

                producto.Descripcion = ProductoTextBox.Text;
                producto.TipoProductoId = ((TipoProducto) TipoProductosComboBox.SelectedItem).TipoProductoId;
                producto.PrecioVenta = decimal.Parse(PrecioVtaTextBox.Text);
                //producto.TipoProducto = (TipoProducto) TipoProductosComboBox.SelectedItem;
                producto.Stock =(int) StockNumericUpDown.Value;
                if (miImagen!=null)
                {
                    producto.Imagen = miImagen;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ProductoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ProductoTextBox,"La descripción es requerida");
            }

            if (!decimal.TryParse(PrecioVtaTextBox.Text, out decimal precioResult))
            {
                valido = false;
                errorProvider1.SetError(PrecioVtaTextBox,"Precio mal ingresado");
            }else if (precioResult<=0 || precioResult>decimal.MaxValue)
            {
                valido = false;
                errorProvider1.SetError(PrecioVtaTextBox,"Precio fuera del rango permitido");
            }

            if (TipoProductosComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(TipoProductosComboBox,"Debe seleccionar un tipo de producto");
            }

            return valido;
        }

        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }

        private void BuscarIconButton_Click(object sender, EventArgs e)
        {
            //Seteo del openFileDialog
            openFileDialog1.InitialDirectory=Environment.CurrentDirectory+@"\Imagenes\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png|Archivos jfif (*.jfif)|*.jfif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult dr = openFileDialog1.ShowDialog(this);//muestro el openFileDialog

            if (dr==DialogResult.OK)
            {
                //Veo si tengo algun imagen seleccionada
                if (openFileDialog1.FileName==null)
                {
                    return;//sino me voy
                }

                Stream miStream = openFileDialog1.OpenFile();
                using (MemoryStream ms=new MemoryStream())
                {
                    miStream.CopyTo(ms);//copio al memorystream
                    miImagen = ms.ToArray();//convierto a byte[]

                    Bitmap bmp = new Bitmap(ms);//convierto a bitmap
                    ImagenPictureBox.Image = bmp;//lo asigno la picture box
                }

            }
        }
    }
}
