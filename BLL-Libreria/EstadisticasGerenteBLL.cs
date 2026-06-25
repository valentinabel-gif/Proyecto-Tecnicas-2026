using BE_Libreria.Ventas;
using DAL_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class EstadisticasGerenteBLL
    {
        private EstadisticasGerenteDAL _estadisticasDAL = new EstadisticasGerenteDAL();

        public double IngresosPorMes(int mes, int anio)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("consultar_ingresos"))
            {
                throw new Exception("Seguridad: No tiene permisos para consultar ingresos.");
            }
            return _estadisticasDAL.IngresosPorMes(mes, anio);
        }

        public double EgresosPorMes(int mes, int anio)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("consultar_egresos"))
            {
                throw new Exception("Seguridad: No tiene permisos para consultar egresos.");
            }

            return _estadisticasDAL.EgresosPorMes(mes, anio);
        }

        public List<ResumenVentas> ObtenerVentasPorMes(int mes, int anio)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("ver_ventas"))
            {
                throw new Exception("Seguridad: No tiene permisos para ver ventas.");
            }

            return _estadisticasDAL.ObtenerVentasPorMes(mes, anio);
        }
    }
}
