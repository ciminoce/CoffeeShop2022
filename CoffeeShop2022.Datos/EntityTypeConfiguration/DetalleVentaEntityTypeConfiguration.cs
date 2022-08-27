using System.Data.Entity.ModelConfiguration;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.EntityTypeConfiguration
{
    public class DetalleVentaEntityTypeConfiguration:EntityTypeConfiguration<DetalleVenta>
    {
        public DetalleVentaEntityTypeConfiguration()
        {
            ToTable("DetalleVentas");
            Property(d => d.PrecioVenta).HasColumnName("Precio");
        }
    }
}
