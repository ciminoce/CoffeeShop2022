using Microsoft.VisualBasic;
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
    public partial class frmCobro : Form
    {
        public frmCobro()
        {
            InitializeComponent();
        }

        private decimal monto;
        public void SetMonto(decimal monto)
        {
            this.monto = monto;
        }

        private void frmCobro_Load(object sender, EventArgs e)
        {
            ImporteLabel.Text = monto.ToString("N2");
        }

        private void EfectivoButton_Click(object sender, EventArgs e)
        {
            var importeText = Interaction.InputBox("Ingrese el importe", "Pago en Efectivo", "0",800,400);
            decimal importeRecibido;
            if (!decimal.TryParse(importeText, out importeRecibido))
            {
                return;
            }else if (importeRecibido<=0 || importeRecibido<monto)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, "Importe inferior a lo que se debe pagar", "Error");
                return;
            }

            ImporteRecibidoLabel.Text = importeRecibido.ToString("N2");
            VueltoLabel.Text = (importeRecibido - monto).ToString("N2");
        }

        private void VisaButton_Click(object sender, EventArgs e)
        {
            frmTarjetaDeCredito frm = new frmTarjetaDeCredito();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
        }
    }
}
