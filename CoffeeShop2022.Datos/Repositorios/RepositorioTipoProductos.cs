using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CoffeeShop2022.Datos.Repositorios.Facades;
using CoffeeShop2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.Repositorios
{
    public class RepositorioTipoProductos:IRepositorioTipoProductos
    {
        private readonly CoffeShop2022DbContext context;

        //public RepositorioTipoProductos()
        //{
        //    context=new CoffeShop2022DbContext();
        //}

        public RepositorioTipoProductos(CoffeShop2022DbContext context)
        {
            this.context = context;
        }

        public void Guardar(TipoProducto tipoProducto)
        {
            try
            {
                if (tipoProducto.TipoProductoId==0)
                {
                    context.TipoProductos.Add(tipoProducto);
                    
                }
                else
                {
                    var tpInDb =
                        context.TipoProductos
                            .SingleOrDefault(tp => tp.TipoProductoId == tipoProducto.TipoProductoId);
                    if (tpInDb==null)
                    {
                        throw new Exception("Tipo de Producto no encontrado");
                    }

                    tpInDb.Descripcion = tipoProducto.Descripcion;
                    context.Entry(tpInDb).State = EntityState.Modified;
                    //context.SaveChanges();
                }
                //context.SaveChanges();
            }
            catch (Exception e)
            {
                //if (e.InnerException!=null && e.InnerException.InnerException.Message.Contains("IX"))
                //{
                //    throw new Exception("Registro existente...");
                //}
                throw new Exception(e.Message);
            }
        }

        public List<TipoProducto> GetLista()
        {
            try
            {
                return context.TipoProductos
                    .AsNoTracking()
                    .ToList();
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
                var tpInDb = context.TipoProductos.SingleOrDefault(t => t.TipoProductoId == tipoProductoId);
                if (tpInDb==null)
                {
                    throw new Exception("Tipo de producto no encontrado");
                }

                context.Entry(tpInDb).State = EntityState.Deleted;
                //context.SaveChanges();
            }
            catch (Exception e)
            {
                //if (e.InnerException!=null && e.InnerException.InnerException.Message.Contains("REFERENCE"))
                //{
                //    throw new Exception("Registro relacionado!!! Baja denegada");
                //}
                throw new Exception(e.Message);
            }
        }

        public TipoProducto GetTipoPorId(int id)
        {
            try
            {
                return context.TipoProductos
                    .SingleOrDefault(tp => tp.TipoProductoId == id);
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
                if (tipoProducto.TipoProductoId==0)
                {
                    return context.TipoProductos
                        .Any(tp => tp.Descripcion == tipoProducto.Descripcion);
                }
                return context.TipoProductos.Any(tp=>tp.Descripcion==tipoProducto.Descripcion && 
                                                     tp.TipoProductoId!=tipoProducto.TipoProductoId);
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
                return context.Productos
                    .Any(p => p.TipoProductoId == tipoProducto.TipoProductoId);
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
                return context.Productos
                    .GroupBy(p => p.TipoProductoId)
                    .ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
