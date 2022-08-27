using System;
using System.Windows.Forms;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Servicios.Servicios.Facades;
using CoffeeShop2022.Windows.Ninject;

namespace CoffeeShop2022.Windows.Helpers
{
    public static class HelperCombos
    {
        public static void CargarDatosComboTipos(ref ComboBox combo)
        {
            IServicioTipoProducto servicio = DI.Create<IServicioTipoProducto>();
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

        public static void CargarDatosComboMeses(ref ComboBox combo)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                combo.Items.Add(mes.ToString().PadLeft(2,'0'));
            }

            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboAnios(ref ComboBox combo)
        {
            var anioActual = DateTime.Now.Year;
            for (int i = 0; i <= 12; i++)
            {
                combo.Items.Add(anioActual + i);
            }

            combo.SelectedIndex = 0;
        }
    }
}
