using CoffeeShop2022.Datos;
using CoffeeShop2022.Datos.Repositorios;
using CoffeeShop2022.Datos.Repositorios.Facades;
using CoffeeShop2022.Servicios.Servicios;
using CoffeeShop2022.Servicios.Servicios.Facades;
using Ninject.Modules;

namespace CoffeeShop2022.Windows.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<CoffeShop2022DbContext>().ToSelf().InSingletonScope();
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<IRepositorioTipoProductos>().To<RepositorioTipoProductos>();
            Bind<IServicioTipoProducto>().To<ServicioTipoProductos>();

            Bind<IRepositorioProductos>().To<RepositorioProductos>();
            Bind<IServicioProductos>().To<ServicioProductos>();

            Bind<IRepositorioVentas>().To<RepositorioVentas>();
            Bind<IRepositorioDetalleVentas>().To<RepositorioDetalleVentas>();

            Bind<IServicioVentas>().To<ServicioVentas>();


        }
    }
}
