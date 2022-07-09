using System.Data.Entity.ModelConfiguration;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.EntityTypeConfiguration
{
    public class TipoProductoEntityTypeConfiguration:EntityTypeConfiguration<TipoProducto>
    {
        public TipoProductoEntityTypeConfiguration()
        {
            ToTable("TipoProductos");
        }
    }
}
