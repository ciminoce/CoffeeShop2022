using System;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Windows
{
    public partial class frmTipoProductoAE : Form
    {
        public frmTipoProductoAE()
        {
            InitializeComponent();
        }

        private TipoProducto tipoProducto;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoProducto!=null)
            {
                TipoProductoTextBox.Text = tipoProducto.Descripcion;
            }
        }

        public TipoProducto GetTipo()
        {
            return tipoProducto;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoProducto == null)
                {
                    tipoProducto = new TipoProducto();
                }

                tipoProducto.Descripcion = TipoProductoTextBox.Text;

                DialogResult = DialogResult.OK;

            }

        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(TipoProductoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(TipoProductoTextBox,"El tipo de producto es requerido");
            }

            return valido;
        }

        public void SetTipo(TipoProducto tipoProducto)
        {
            this.tipoProducto = tipoProducto;
        }
    }
}
