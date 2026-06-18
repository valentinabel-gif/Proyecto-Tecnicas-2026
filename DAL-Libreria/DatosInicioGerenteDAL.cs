using BE_Libreria.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DatosInicioGerenteDAL
    {
        private Conexion _conexion = new Conexion();

        public string ObtenerVendedorConMasVentas()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_VendedorConMasVentas");
            if (tabla != null && tabla.Rows.Count > 0)
            {
                return tabla.Rows[0]["nombre_usuario"].ToString();
            }
              
            return "No hay vendedores con mayor venta";
        }

        public int ProductosConStockMinimo()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_ProductosConStockMinimo");
            if (tabla != null && tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["total"]);

            }
             return 0;
        }

        public int ProductosSinStock()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_ProductosSinStock");
            if (tabla != null && tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["total"]);
            }
            return 0;
        }

        public List<VentaDelDia> ObtenerVentasDelDia()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_VentasDelDia");
            List<VentaDelDia> ventas = new List<VentaDelDia>();

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    ventas.Add(new VentaDelDia(
                        Convert.ToInt32(fila["id_venta"]),
                        fila["vendedor"].ToString(),
                        Convert.ToDouble(fila["total_venta"]),
                        Convert.ToDateTime(fila["fecha_venta"])
                    ));
                }
            }
            return ventas;
        }
    }
}
