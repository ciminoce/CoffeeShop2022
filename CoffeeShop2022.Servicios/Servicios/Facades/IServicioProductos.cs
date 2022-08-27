using System.Collections.Generic;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Entidades.Enum;

namespace CoffeeShop2022.Servicios.Servicios.Facades
{
    public interface IServicioProductos
    {
        void Guardar(Producto producto);
        void Borrar(int productoId);
        Producto GetProductoPorId(int id);
        bool Existe(Producto producto);
        bool EstaRelacionado(Producto producto);

        List<Producto> GetLista(TipoProducto tp, Orden orden);
    }
}
