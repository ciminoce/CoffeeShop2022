using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeShop2022.Windows.Clases
{
    public class Carrito
    {
        public List<ItemCarrito> listaItems { get; set; }

        private Carrito()
        {
            listaItems=new List<ItemCarrito>();
        }

        public static Carrito instancia = null;

        public static Carrito GetInstancia()
        {
            if (instancia==null)
            {
                instancia=new Carrito();
            }

            return instancia;
        }

        public List<ItemCarrito> GetItems => listaItems;

        public void Agregar(ItemCarrito item)
        {
            var itemInCarrito = listaItems
                .SingleOrDefault(i => i.ProductoId == item.ProductoId);
            if (itemInCarrito==null)
            {
                listaItems.Add(item);
                
            }
            else
            {
                itemInCarrito.Cantidad++;
            }
        }

        public void Eliminar(ItemCarrito item)
        {
            listaItems.Remove(item);
        }

        public int GetCantidad()
        {
            return listaItems.Sum(i => i.Cantidad);
        }

        public decimal GetTotal() => listaItems.Sum(i => i.SubTotal);

        public void VaciarCarrito()
        {
            listaItems.Clear();
        }

        public void QuitarUno(ItemCarrito item)
        {
            var itemInCarrito = listaItems.SingleOrDefault(i => i.ProductoId == item.ProductoId);
            itemInCarrito.Cantidad--;
            if (itemInCarrito.Cantidad==0)
            {
                this.Eliminar(item);
            }
        }
    }
}
