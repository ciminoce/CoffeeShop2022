using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.Repositorios.Facades
{
    public interface IRepositorioDetalleVentas
    {
        void Guardar(DetalleVenta detalleVenta);
    }
}