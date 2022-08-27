using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop2022.Windows.Helpers;

namespace CoffeeShop2022.Windows
{
    public partial class frmTarjetaDeCredito : Form
    {
        public frmTarjetaDeCredito()
        {
            InitializeComponent();
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboMeses(ref MesComboBox);
            HelperCombos.CargarDatosComboAnios(ref AnioComboBox);
            
        }
    }
}
