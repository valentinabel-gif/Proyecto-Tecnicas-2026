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
            if (!Sesion.Instancia.HaySesionActiva())
                throw new Exception("Seguridad: Debe iniciar sesión.");

            return _estadisticasDAL.IngresosPorMes(mes, anio);
        }

        public double EgresosPorMes(int mes, int anio)
        {
            if (!Sesion.Instancia.HaySesionActiva())
                throw new Exception("Seguridad: Debe iniciar sesión.");

            return _estadisticasDAL.EgresosPorMes(mes, anio);
        }

        public List<ResumenVentas> ObtenerVentasPorMes(int mes, int anio)
        {
            if (!Sesion.Instancia.HaySesionActiva())
                throw new Exception("Seguridad: Debe iniciar sesión.");

            return _estadisticasDAL.ObtenerVentasPorMes(mes, anio);
        }
    }
}
