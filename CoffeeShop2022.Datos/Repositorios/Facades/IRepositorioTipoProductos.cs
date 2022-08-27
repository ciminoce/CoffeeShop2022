using System.Collections.Generic;
using System.Linq;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.Repositorios.Facades
{
    public interface IRepositorioTipoProductos
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
