using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeShop2022.Datos;
using CoffeeShop2022.Datos.Repositorios;
using CoffeeShop2022.Datos.Repositorios.Facades;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Servicios.Servicios.Facades;

namespace CoffeeShop2022.Servicios.Servicios
{
    public class ServicioTipoProductos:IServicioTipoProducto
    {
        private readonly IRepositorioTipoProductos repositorio;
        private readonly IUnitOfWork unitOfWork;
        private readonly CoffeShop2022DbContext context;
        public ServicioTipoProductos(CoffeShop2022DbContext context, IUnitOfWork unitOfWork, IRepositorioTipoProductos repositorio)
        {
            this.context = context;
            this.unitOfWork = unitOfWork;
            this.repositorio = repositorio;
        }

        //public ServicioTipoProductos()
        //{
        //    context = new CoffeShop2022DbContext();
        //    unitOfWork = new UnitOfWork(context);
        //    repositorio=new RepositorioTipoProductos(context);
        //}
        public void Guardar(TipoProducto tipoProducto)
        {
            try
            {
                repositorio.Guardar(tipoProducto);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }

        public List<TipoProducto> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int tipoProductoId)
        {
            try
            {
                repositorio.Borrar(tipoProductoId);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoProducto GetTipoPorId(int id)
        {
            try
            {
                return repositorio.GetTipoPorId(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Existe(TipoProducto tipoProducto)
        {
            try
            {
                return repositorio.Existe(tipoProducto);
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(TipoProducto tipoProducto)
        {
            try
            {
                return repositorio.EstaRelacionado(tipoProducto);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<IGrouping<int, Producto>> GetProductosPorTipo()
        {
            try
            {
                return repositorio.GetProductosPorTipo();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
