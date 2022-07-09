using System;
using CoffeeShop2022.Datos.Repositorios.Facades;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.Repositorios
{
    public class RepositorioDetalleVentas:IRepositorioDetalleVentas
    {
        private readonly CoffeShop2022DbContext context;

        public RepositorioDetalleVentas()
        {
            context=new CoffeShop2022DbContext();
            
        }

        public RepositorioDetalleVentas(CoffeShop2022DbContext context)
        {
            this.context = context;
        }

        public void Guardar(DetalleVenta detalleVenta)
        {
            try
            {
                context.DetalleVentas.Add(detalleVenta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
