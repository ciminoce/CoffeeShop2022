using System.Collections.Generic;
using System.Linq;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Servicios.Servicios.Facades
{
    public interface IServicioTipoProducto
    {
        void Guardar(TipoProducto tipoProducto);
        List<TipoProducto> GetLista();
        void Borrar(int tipoProductoId);
        TipoProducto GetTipoPorId(int id);

        bool Existe(TipoProducto tipoProducto);
        bool EstaRelacionado(TipoProducto tipoProducto);
        List<IGrouping<int, Producto>> GetProductosPorTipo();
    }
}
