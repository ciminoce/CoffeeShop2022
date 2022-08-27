using System.Collections.Generic;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Servicios.Servicios.Facades
{
    public interface IServicioVentas
    {
        List<Venta> GetVentas();
        void Guardar(Venta venta);

        void CambiarEstado(Venta venta);
        List<DetalleVenta> GetDetalleVenta(int ventaVentaId);
    }
}