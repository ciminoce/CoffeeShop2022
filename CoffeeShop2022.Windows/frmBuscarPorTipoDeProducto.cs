using System;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Windows.Helpers;

namespace CoffeeShop2022.Windows
{
    public partial class frmBuscarPorTipoDeProducto : Form
    {
        public frmBuscarPorTipoDeProducto()
        {
            InitializeComponent();
        }

        private TipoProducto tipoProducto;
        private void frmBuscarPorTipoDeProducto_Load(object sender, EventArgs e)
        {
            HelperCombos.CargarDatosComboTipos(ref TipoProductosComboBox );
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (TipoProductosComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(TipoProductosComboBox,"Debe seleccionar un tipo de producto");
            }

            return valido;
        }

        private void TipoProductosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoProductosComboBox.SelectedIndex>0)
            {
                tipoProducto = (TipoProducto) TipoProductosComboBox.SelectedItem;
            }
            else
            {
                tipoProducto = null;
            }
        }

        public TipoProducto GetTipo()
        {
            return tipoProducto;
        }
    }
}
