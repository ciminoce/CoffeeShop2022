using CoffeeShop2022.Servicios.Servicios.Facades;
using CoffeeShop2022.Windows.Ninject;
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
            frmTipoProductos frm=new frmTipoProductos(DI.Create<IServicioTipoProducto>());
            frm.ShowDialog(this);

        }

        private void ProductosButton_Click(object sender, EventArgs e)
        {
            frmProductos frm=new frmProductos(DI.Create<IServicioProductos>());
            frm.ShowDialog(this);
        }
        
        private void VentasButton_Click(object sender, EventArgs e)
        {
            frmVentas frm = new frmVentas(DI.Create<IServicioVentas>());
            frm.ShowDialog(this);
        }
    }
}
