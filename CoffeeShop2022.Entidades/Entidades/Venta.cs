using System;
using System.Collections.Generic;

namespace CoffeeShop2022.Entidades.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }

        public List<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();
    }
}
