using BE_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class ProductoDAL
    {
        private Conexion _conexion = new Conexion();

        //metodo privado para no repetir el mapeo en cada metodo
        private Producto MapearProducto(DataRow fila)
        {
            Categoria categoria = new Categoria(
                Convert.ToInt32(fila["id_categoria"]),
                fila["nombre_categoria"].ToString()
            );

            return new Producto(
                Convert.ToInt32(fila["id_producto"]),
                fila["nombre_producto"].ToString(),
                Convert.ToDouble(fila["valor_venta"]),
                Convert.ToDouble(fila["valor_lista"]),
                Convert.ToInt32(fila["stock"]),
                fila["codigo_barra"].ToString(),
                fila["descripcion_producto"] != DBNull.Value ?
                    fila["descripcion_producto"].ToString() : "",
                categoria
            );
        }

        public Producto BuscarPorCodigoBarra(string codigoBarra)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@codigo_barra", codigoBarra)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_BuscarProductoPorCodigo", parametros);

            if (tabla == null || tabla.Rows.Count == 0)
                return null;

            return MapearProducto(tabla.Rows[0]);
        }

        public List<Producto> BuscarPorNombre(string nombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@nombre", nombre)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_BuscarProductoPorNombre", parametros);

            List<Producto> productos = new List<Producto>();

            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                    productos.Add(MapearProducto(fila));

            return productos;
        }

        public Producto ObtenerPorId(int idProducto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_producto", idProducto)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_ObtenerProductoPorId", parametros);

            if (tabla == null || tabla.Rows.Count == 0)
                return null;

            return MapearProducto(tabla.Rows[0]);
        }

        public List<Producto> ObtenerTodos()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_ObtenerTodosProductos");

            List<Producto> productos = new List<Producto>();

            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                    productos.Add(MapearProducto(fila));

            return productos;
        }

        public void DescontarStock(int idProducto, int cantidad)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_producto", idProducto),
                _conexion.crearParametro("@cantidad", cantidad)
            };

            _conexion.EscribirPorStoreProcedure(
                "sp_DescontarStock", parametros);
        }

        public bool ExisteCodigoBarra(string codigoBarra)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@codigo_barra", codigoBarra)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_BuscarProductoPorCodigo", parametros);

            return tabla != null && tabla.Rows.Count > 0;
        }

        public void AgregarProducto(Producto producto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_categoria",
                    producto.Categoria.IdCategoria),
                _conexion.crearParametro("@nombre_producto",
                    producto.NombreProducto),
                _conexion.crearParametro("@valor_venta",
                    producto.ValorVenta),
                _conexion.crearParametro("@valor_lista",
                    producto.ValorLista),
                _conexion.crearParametro("@stock",
                    producto.Stock),
                _conexion.crearParametro("@codigo_barra",
                    producto.CodigoBarra),
                _conexion.crearParametro("@descripcion_producto",
                    producto.DescripcionProducto ?? "")
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure(
                "sp_AgregarProducto", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo agregar el producto.");
        }

        public void ModificarProducto(Producto producto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_producto",
                    producto.IdProducto),
                _conexion.crearParametro("@id_categoria",
                    producto.Categoria.IdCategoria),
                _conexion.crearParametro("@nombre_producto",
                    producto.NombreProducto),
                _conexion.crearParametro("@valor_venta",
                    producto.ValorVenta),
                _conexion.crearParametro("@valor_lista",
                    producto.ValorLista),
                _conexion.crearParametro("@stock",
                    producto.Stock),
                _conexion.crearParametro("@codigo_barra",
                    producto.CodigoBarra),
                _conexion.crearParametro("@descripcion_producto",
                    producto.DescripcionProducto ?? "")
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure(
                "sp_ModificarProducto", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo modificar el producto.");
        }

        public void EliminarProducto(int idProducto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_producto", idProducto)
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure(
                "sp_EliminarProducto", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo eliminar el producto.");
        }

        public List<Producto> ObtenerProductosSinStock()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_ObtenerProductosSinStock");

            List<Producto> productos = new List<Producto>();

            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                    productos.Add(MapearProducto(fila));

            return productos;
        }

        public List<Producto> ObtenerProductosStockBajo(int stockMinimo)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@stock_minimo", stockMinimo)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_ObtenerProductosStockBajo", parametros);

            List<Producto> productos = new List<Producto>();

            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                    productos.Add(MapearProducto(fila));

            return productos;
        }

        /*pantalla proveedores de la vista del gerente */

        public List<Producto> ObtenerProductosPorProveedor(int idProveedor)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        _conexion.crearParametro("@id_proveedor", idProveedor)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_ProductosPorProveedor", parametros);
            List<Producto> productos = new List<Producto>();

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Categoria categoria = new Categoria(
                        Convert.ToInt32(fila["id_categoria"]),
                        fila["nombre_categoria"].ToString()
                    );

                    productos.Add(new Producto(
                        Convert.ToInt32(fila["id_producto"]),
                        fila["nombre_producto"].ToString(),
                        Convert.ToDouble(fila["valor_venta"]),
                        Convert.ToDouble(fila["valor_lista"]),
                        Convert.ToInt32(fila["stock"]),
                        fila["codigo_barra"].ToString(),
                        fila["descripcion_producto"].ToString(),
                        categoria
                    ));
                }
            }
            return productos;
        }

        public List<Producto> ObtenerPreciosPorProveedor(int idProveedor)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        _conexion.crearParametro("@id_proveedor", idProveedor)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_PreciosPorProveedor", parametros);
            List<Producto> precios = new List<Producto>();

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Categoria categoria = new Categoria(
                        Convert.ToInt32(fila["id_categoria"]),
                        fila["nombre_categoria"].ToString()
                    );

                    precios.Add(new Producto(
                        Convert.ToInt32(fila["id_producto"]),
                        fila["nombre_producto"].ToString(),
                        Convert.ToDouble(fila["valor_venta"]),
                        Convert.ToDouble(fila["valor_lista"]),
                        Convert.ToInt32(fila["stock"]),
                        fila["codigo_barra"].ToString(),
                        fila["descripcion_producto"].ToString(),
                        categoria
                    ));
                }
            }
            return precios;
        }
    }
}
