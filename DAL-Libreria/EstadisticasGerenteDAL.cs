using BE_Libreria.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class EstadisticasGerenteDAL
    {
        private Conexion _conexion = new Conexion();

            public double IngresosPorMes(int mes, int anio)
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    _conexion.crearParametro("@mes", mes.ToString()),
                    _conexion.crearParametro("@anio", anio.ToString())
                };

                DataTable tabla = _conexion.LeerPorStoreProcedure("sp_IngresosPorMes", parametros);
                if (tabla != null && tabla.Rows.Count > 0)
                {
                    return Convert.ToDouble(tabla.Rows[0]["total"]);
                }
                return 0;
            }

            public double EgresosPorMes(int mes, int anio)
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    _conexion.crearParametro("@mes", mes.ToString()),
                    _conexion.crearParametro("@anio", anio.ToString())
                };

                DataTable tabla = _conexion.LeerPorStoreProcedure("sp_EgresosPorMes", parametros);
                if (tabla != null && tabla.Rows.Count > 0)
                {
                    return Convert.ToDouble(tabla.Rows[0]["total"]);
                }
                return 0;
            }

            public List<ResumenVentas> ObtenerVentasPorMes(int mes, int anio)
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    _conexion.crearParametro("@mes", mes.ToString()),
                    _conexion.crearParametro("@anio", anio.ToString())
                };

                DataTable tabla = _conexion.LeerPorStoreProcedure("sp_VentasPorMes", parametros);
                List<ResumenVentas> ventas = new List<ResumenVentas>();

                if (tabla != null)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        ventas.Add(new ResumenVentas(
                            Convert.ToInt32(fila["id_venta"]),
                            Convert.ToDateTime(fila["fecha_venta"]),
                            fila["cliente"].ToString(),
                            Convert.ToDouble(fila["total_venta"])
                        ));
                    }
                }
                return ventas;
            }
     }
  }
