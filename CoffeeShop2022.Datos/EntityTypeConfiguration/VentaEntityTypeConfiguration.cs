using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.EntityTypeConfiguration
{
    public class VentaEntityTypeConfiguration:EntityTypeConfiguration<Venta>
    {
        public VentaEntityTypeConfiguration()
        {
            ToTable("Ventas");
            Property(v => v.Estado).HasColumnName("EstadoVenta");
        }
    }
}
