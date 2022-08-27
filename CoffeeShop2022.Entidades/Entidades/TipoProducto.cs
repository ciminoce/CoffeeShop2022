using System;
using System.Collections.Generic;

namespace CoffeeShop2022.Entidades.Entidades
{
    public class TipoProducto:ICloneable
    {
        public int TipoProductoId { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Producto> Productos { get; set; }=new List<Producto>();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
