using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoffeeShop2022.Windows.UserControls
{
    public partial class ucProducto : UserControl
    {
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imagenes\ImagenNoDisponible.jfif";

        public ucProducto()
        {
            InitializeComponent();
        }

        public int ProductoId { get; set; }

        public string Descripcion
        {
            set { DescripcionLabel.Text = value; }
        }

        public string Precio
        {
            set { PrecioLabel.Text = value; }
        }

        public byte[] Imagen
        {
            set
            {
                if (value == null)
                {
                    ImagenPictureBox.Image = Image.FromFile(imagenNoDisponible);
                }
                else
                {
                    MemoryStream ms = new MemoryStream(value);
                    Bitmap bmp = new Bitmap(ms);
                    ImagenPictureBox.Image = bmp;
                }

            }
        }

        private void ucProducto_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ucProducto_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
