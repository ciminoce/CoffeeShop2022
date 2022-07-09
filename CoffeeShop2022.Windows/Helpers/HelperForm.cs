using System.Collections.Generic;
using System.Windows.Forms;
using CoffeeShop2022.Windows.Classes;

namespace CoffeeShop2022.Windows.Helpers
{
    public static class HelperForm
    {
        public static  void MostrarDatosEnGrilla<T>(DataGridView dataGridView,List<T> objList)
        {
            //DatosDataGridView.Rows.Clear();
            HelperGrid.LimpiarGrilla(dataGridView);
            foreach (var obj in objList)
            {
                //var r = ConstruirFila();
                var r = HelperGrid.ConstruirFila(dataGridView);
                HelperGrid.SetearFila(r, obj);
                HelperGrid.AgregarFila(dataGridView, r);
            }
        }

    }
}
