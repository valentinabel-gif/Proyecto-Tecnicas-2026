using BE_Libreria;
using BE_Libreria.Stock;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class ReporteDAL
    {
        private Conexion _conexion = new Conexion();

        public List<Producto> BuscarProductosParaReporte(string criterio)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        _conexion.crearParametro("@criterio", criterio)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_BuscarProductosParaReporte", parametros);

            List<Producto> lista = new List<Producto>();

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Categoria categoria = new Categoria(
                        Convert.ToInt32(fila["id_categoria"]),
                        fila["nombre_categoria"].ToString()
                    );

                    lista.Add(new Producto(
                        Convert.ToInt32(fila["id_producto"]),
                        fila["nombre_producto"].ToString(),
                        Convert.ToDouble(fila["valor_venta"]),
                        Convert.ToDouble(fila["valor_lista"]),
                        Convert.ToInt32(fila["stock"]),
                        fila["codigo_barra"].ToString(),
                        fila["descripcion_producto"] != DBNull.Value ?
                            fila["descripcion_producto"].ToString() : "",
                        categoria
                    ));
                }
            }

            return lista;
        }
        private ReporteProducto MapearReporte(DataRow fila)
        {
            return new ReporteProducto(
                Convert.ToInt32(fila["id_producto"]),
                fila["nombre_producto"].ToString(),
                fila["nombre_categoria"].ToString(),
                Convert.ToInt32(fila["total_vendido"]),
                Convert.ToDouble(fila["ingresos"]),
                Convert.ToDouble(fila["rentabilidad"]),
                Convert.ToInt32(fila["stock"])
            );
        }

        public List<ReporteProducto> ObtenerReportePorIds(string ids)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        _conexion.crearParametro("@ids", ids)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_Reporte", parametros);

            List<ReporteProducto> lista = new List<ReporteProducto>();

            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                    lista.Add(MapearReporte(fila));

            return lista;
        }
    }
   }
