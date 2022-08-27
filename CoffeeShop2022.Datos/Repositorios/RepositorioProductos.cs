using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CoffeeShop2022.Datos.Repositorios.Facades;
using CoffeeShop2022.Entidades.Entidades;
using CoffeeShop2022.Entidades.Enum;

namespace CoffeeShop2022.Datos.Repositorios
{
    public class RepositorioProductos:IRepositorioProductos
    {
        private readonly CoffeShop2022DbContext context;

        public RepositorioProductos(CoffeShop2022DbContext context)
        {
            this.context = context;
        }
        public void Guardar(Producto producto)
        {
            try
            {
                //if (producto.TipoProducto != null)
                //{
                //    context.TipoProductos.Attach(producto.TipoProducto);
                //}
                if (producto.ProductoId==0)
                {
                    context.Productos.Add(producto);
                }
                else
                {
                    var productoInDb = context.Productos.SingleOrDefault(p => p.ProductoId == producto.ProductoId);
                    if (productoInDb==null)
                    {
                        throw new Exception("Código de producto inexistente...");
                    }

                    productoInDb.Descripcion = producto.Descripcion;
                    productoInDb.TipoProductoId = producto.TipoProductoId;
                    productoInDb.PrecioVenta = producto.PrecioVenta;
                    productoInDb.Stock = producto.Stock;
                    //Si tengo imagen la asigno y la guardo
                    if (producto.Imagen!=null)
                    {
                        productoInDb.Imagen = producto.Imagen;
                    }
                    context.Entry(productoInDb).State = EntityState.Modified;

                }

                //context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Producto> GetLista(TipoProducto tp=null, Orden orden=Orden.BD)
        {
            try
            {
                var query = context.Productos
                    .Include(p => p.TipoProducto);
                if (tp != null)
                {
                    query = query.Where(p => p.TipoProductoId == tp.TipoProductoId);
                }

                switch (orden)
                {
                    case Orden.BD:
                        break;
                    case Orden.AZ:
                        query = query.OrderBy(p => p.Descripcion);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(p => p.Descripcion);
                        break;
                    case Orden.ASC:
                        query = query.OrderBy(p => p.PrecioVenta);
                        break;
                    case Orden.DESC:
                        query = query.OrderByDescending(p => p.PrecioVenta);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(orden), orden, null);
                }
                return query
                    .AsNoTracking()
                    .ToList();
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
                var productoInDb = context.Productos.SingleOrDefault(p => p.ProductoId == productoId);
                if (productoInDb==null)
                {
                    throw new Exception("Código de producto inexistente");
                }

                context.Entry(productoInDb).State = EntityState.Deleted;
                //context.SaveChanges();
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
                return context.Productos.SingleOrDefault(p => p.ProductoId == id);
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
                return context.DetalleVentas
                    .Any(dt => dt.ProductoId == producto.ProductoId);
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
                if (producto.ProductoId == 0)
                {
                    return context.Productos
                        .Any(p => p.Descripcion == producto.Descripcion);
                }
                return context.Productos.Any(p => p.Descripcion == producto.Descripcion &&
                                                       p.ProductoId !=producto.ProductoId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
