using System;
using System.Collections.Generic;

namespace CoffeeShop2022.Entidades.Entidades
{
    public class Producto : ICloneable

    {
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int TipoProductoId { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public byte[] Imagen { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
