using System.Collections.Generic;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.Repositorios.Facades
{
    public interface IRepositorioVentas
    {
        List<Venta> GetVentas();
        void Guardar(Venta venta);
        void AnularVenta(Venta venta);
    }
}