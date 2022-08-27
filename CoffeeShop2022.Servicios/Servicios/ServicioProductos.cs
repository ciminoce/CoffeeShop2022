using System;
using System.Collections.Generic;
using CoffeeShop2022.Datos;
using CoffeeShop2022.Datos.Repositorios;
using CoffeeShop2022.Datos.Repositorios.Facades;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Entidades.Enum;
using CoffeeShop2022.Servicios.Servicios.Facades;

namespace CoffeeShop2022.Servicios.Servicios
{
    public class ServicioProductos:IServicioProductos
    {
        private readonly IRepositorioProductos repositorio;
        private readonly IUnitOfWork uniOfWork;
        private readonly CoffeShop2022DbContext context;
        public ServicioProductos(CoffeShop2022DbContext context, IUnitOfWork uniOfWork, IRepositorioProductos repositorio)
        {
            this.context = context;
            this.uniOfWork = uniOfWork;
            this.repositorio = repositorio;
        }

        //public ServicioProductos()
        //{
        //    repositorio=new RepositorioProductos();
        //}
        public void Guardar(Producto producto)
        {
            try
            {
                repositorio.Guardar(producto);
                uniOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public void Borrar(int productoId)
        {
            try
            {
                repositorio.Borrar(productoId);
                uniOfWork.Save();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Producto GetProductoPorId(int id)
        {
            try
            {
                return repositorio.GetProductoPorId(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


        }

        public bool Existe(Producto producto)
        {
            try
            {
                return repositorio.Existe(producto);
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Producto producto)
        {
            try
            {
                return repositorio.EstaRelacionado(producto);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Producto> GetLista(TipoProducto tp, Orden orden)
        {
            try
            {
                return repositorio.GetLista(tp,orden);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
