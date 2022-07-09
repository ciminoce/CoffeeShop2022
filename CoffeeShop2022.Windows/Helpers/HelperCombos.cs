using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Servicios.Servicios;
using CoffeeShop2022.Servicios.Servicios.Facades;

namespace CoffeeShop2022.Windows.Helpers
{
    public static class HelperCombos
    {
        public static void CargarDatosComboTipos(ref ComboBox combo)
        {
            IServicioTipoProducto servicio=new ServicioTipoProductos();
            var lista = servicio.GetLista();
            TipoProducto tpDefault = new TipoProducto()
            {
                TipoProductoId = 0,
                Descripcion = "Seleccione Tipo Producto"
            };
            lista.Insert(0, tpDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoProductoId";
            combo.SelectedIndex = 0;
        }

    }
}
