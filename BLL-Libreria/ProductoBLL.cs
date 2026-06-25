using BE_Libreria;
using DAL_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class ProductoBLL
    {
        private ProductoDAL _productoDAL = new ProductoDAL();

        //los metodos q tiro aca son de busqueda

        public Producto BuscarPorCodigoBarra(string codigoBarra)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("buscar_producto"))
            {
                throw new Exception("Seguridad: No tiene permisos para buscar productos.");
            }

            if (string.IsNullOrWhiteSpace(codigoBarra))
            {
                throw new Exception("Debe ingresar un código de barras.");
            }

            return _productoDAL.BuscarPorCodigoBarra(codigoBarra);
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("buscar_producto"))
            {
                throw new Exception("Seguridad: No tiene permisos para buscar productos.");
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("Debe ingresar un nombre para buscar.");
            }

            return _productoDAL.BuscarPorNombre(nombre);
        }

        public Producto ObtenerPorId(int idProducto)
        {
            if (idProducto <= 0)
            {
                throw new Exception("El ID del producto es inválido.");
            }

            return _productoDAL.ObtenerPorId(idProducto);
        }

        public List<Producto> ObtenerTodos()
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("ver_lista_productos"))
            {
                throw new Exception("Seguridad: No tiene permisos para ver el listado de productos.");
            }
            return _productoDAL.ObtenerTodos();
        }

        //lo de aca tiene q ver mas con stock

        public bool VerificarStock(int idProducto, int cantidadSolicitada)
        {
            if (cantidadSolicitada <= 0)
            {
                throw new Exception("La cantidad debe ser mayor a cero.");
            }

            Producto producto = ObtenerPorId(idProducto);

            if (producto == null)
            {
                throw new Exception("Producto no encontrado.");
            }

            return producto.Stock >= cantidadSolicitada;
        }

        public void DescontarStock(int idProducto, int cantidad)
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            if (cantidad <= 0)
            {
                throw new Exception("La cantidad a descontar debe ser mayor a cero.");
            }

            Producto producto = ObtenerPorId(idProducto);

            if (producto == null)
            {
                throw new Exception("Producto no encontrado.");
            }

            if (producto.Stock < cantidad)
            {
                throw new Exception($"Stock insuficiente. Stock actual: {producto.Stock}.");
            }

            _productoDAL.DescontarStock(idProducto, cantidad);
        }

        //aca tiro lo q es alta baja y modificacion

        public void AgregarProducto(Producto nuevoProducto)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("agregar_producto"))
            {
                throw new Exception("No tiene permisos para agregar productos.");
            }

            if (nuevoProducto == null)
            {
                throw new ArgumentNullException("El producto no puede ser nulo.");
            }

            if (string.IsNullOrWhiteSpace(nuevoProducto.NombreProducto))
            {
                throw new Exception("El nombre del producto es obligatorio.");
            }

            if (nuevoProducto.ValorVenta <= 0)
            {
                throw new Exception("El valor de venta debe ser mayor a cero.");
            }

            if (nuevoProducto.Stock < 0)
            {
                throw new Exception("El stock no puede ser negativo.");
            }

            if (string.IsNullOrWhiteSpace(nuevoProducto.CodigoBarra))
            {
                throw new Exception("El código de barras es obligatorio.");
            }

            if (_productoDAL.ExisteCodigoBarra(nuevoProducto.CodigoBarra))
            {
                throw new Exception("El código de barras ya está registrado.");
            }


            _productoDAL.AgregarProducto(nuevoProducto);
        }

        public void ModificarProducto(Producto productoModificado)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("editar_producto"))
            {
                throw new Exception("No tiene permisos para modificar productos.");
            }

            if (productoModificado == null)
            {
                throw new ArgumentNullException("El producto no puede ser nulo.");
            }

            if (productoModificado.IdProducto <= 0)
            {
                throw new Exception("El ID del producto es inválido.");
            }

            if (string.IsNullOrWhiteSpace(productoModificado.NombreProducto))
            {
                throw new Exception("El nombre del producto es obligatorio.");
            }

            if (productoModificado.ValorVenta <= 0)
            {
                throw new Exception("El valor de venta debe ser mayor a cero.");
            }

            if (productoModificado.Stock < 0)
            {
                throw new Exception("El stock no puede ser negativo.");
            }

            _productoDAL.ModificarProducto(productoModificado);
        }

        public void EliminarProducto(int idProducto)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("eliminar_producto"))
            {
                throw new Exception("No tiene permisos para eliminar productos.");
            }

            if (idProducto <= 0)
            {
                throw new Exception("El ID del producto es inválido.");
            }

            _productoDAL.EliminarProducto(idProducto);

        }

        //aca lo de alerta de stock

        public List<Producto> ObtenerProductosSinStock()
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            return _productoDAL.ObtenerProductosSinStock();
        }

        public List<Producto> ObtenerProductosStockBajo(int stockMinimo)
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            if (stockMinimo < 0)
            {
                throw new Exception("El stock mínimo no puede ser negativo.");
            }

            return _productoDAL.ObtenerProductosStockBajo(stockMinimo);
        }

        public bool ExisteCodigoBarra(string codigoBarra)
        {
            if (string.IsNullOrWhiteSpace(codigoBarra))
            {
                return false;
            }

           return _productoDAL.ExisteCodigoBarra(codigoBarra);
        }


        /*proveedores de vista gerente*/

        public List<Producto> ObtenerProductosPorProveedor(int idProveedor)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("ver_lista_productos"))
            {
                throw new Exception("Seguridad: No tiene permisos para ver el listado de productos.");
            }
            ProductoDAL dal = new ProductoDAL();
            return dal.ObtenerProductosPorProveedor(idProveedor);
        }

        public List<Producto> ObtenerPreciosPorProveedor(int idProveedor)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("consultar_precios"))
            {
                throw new Exception("Seguridad: No tiene permisos para consultar precios.");
            }
            ProductoDAL dal = new ProductoDAL();
            return dal.ObtenerPreciosPorProveedor(idProveedor);
        }

    }
}
