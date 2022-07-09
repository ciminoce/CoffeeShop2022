using System;
using System.Collections.Generic;
using CoffeeShop2022.Datos.Repositorios;
using CoffeeShop2022.Datos.Repositorios.Facades;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Servicios.Servicios.Facades;

namespace CoffeeShop2022.Servicios.Servicios
{
    public class ServicioTipoProductos:IServicioTipoProducto
    {
        private readonly IRepositorioTipoProductos repositorio;

        public ServicioTipoProductos()
        {
            repositorio=new RepositorioTipoProductos();
        }
        public void Guardar(TipoProducto tipoProducto)
        {
            try
            {
                repositorio.Guardar(tipoProducto);
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
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoProducto GetTipoPorId(int id)
        {
            throw new NotImplementedException();
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
    }
}
