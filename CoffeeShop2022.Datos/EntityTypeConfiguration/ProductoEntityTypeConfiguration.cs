using System.Data.Entity.ModelConfiguration;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.EntityTypeConfiguration
{
    public class ProductoEntityTypeConfiguration:EntityTypeConfiguration<Producto>
    {
        public ProductoEntityTypeConfiguration()
        {
            ToTable("Productos");
            Property(p => p.PrecioVenta).HasColumnName("Precio");
        }
    }
}
