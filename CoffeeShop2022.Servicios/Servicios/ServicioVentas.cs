using System;
using System.Collections.Generic;
using System.Transactions;
using CoffeeShop2022.Datos;
using CoffeeShop2022.Datos.Repositorios;
using CoffeeShop2022.Datos.Repositorios.Facades;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Servicios.Servicios.Facades;

namespace CoffeeShop2022.Servicios.Servicios
{
    public class ServicioVentas:IServicioVentas
    {
        private readonly CoffeShop2022DbContext context;
        private readonly IRepositorioVentas repoVentas;
        private readonly IRepositorioDetalleVentas repoDetalle;

        public ServicioVentas()
        {
            context=new CoffeShop2022DbContext();
            repoVentas=new RepositorioVentas(context);
            repoDetalle=new RepositorioDetalleVentas(context);
        }
        public List<Venta> GetVentas()
        {
            try
            {
                return repoVentas.GetVentas();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Venta venta)
        {
            try
            {
                using (var scope=new TransactionScope(TransactionScopeOption.Required))
                {
                    repoVentas.Guardar(venta);
                    context.SaveChanges();
                    foreach (var item in venta.DetalleVentas)
                    {
                        item.VentaId = venta.VentaId;
                        repoDetalle.Guardar(item);

                    }

                    context.SaveChanges();
                    scope.Complete();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
