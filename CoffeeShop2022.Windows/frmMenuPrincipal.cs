using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop2022.Windows
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TipoProductosButton_Click(object sender, EventArgs e)
        {
            frmTipoProductos frm=new frmTipoProductos();
            frm.ShowDialog(this);

        }

        private void ProductosButton_Click(object sender, EventArgs e)
        {
            frmProductos frm=new frmProductos();
            frm.ShowDialog(this);
        }

        private void VentasButton_Click(object sender, EventArgs e)
        {
            frmVentas frm = new frmVentas();
            frm.ShowDialog(this);
        }
    }
}
