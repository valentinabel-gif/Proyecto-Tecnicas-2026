using BE_Libreria.Ventas;
using DAL_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class DatosInicioGerenteBLL

    {
        private DatosInicioGerenteDAL _DatosInicioGerenteDAL = new DatosInicioGerenteDAL();

        public string ObtenerVendedorConMasVentas()
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("Debe iniciar sesion para realizar la solicitud");
            }

            return _DatosInicioGerenteDAL.ObtenerVendedorConMasVentas();
        }

        public int ProductosStockMinimo()
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("Debe iniciar sesion para realizar la solicitud");
            }

            return _DatosInicioGerenteDAL.ProductosConStockMinimo();
        }

        public int ProductosSinStock()
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("Debe iniciar sesion para realizar la solicitud");
            }

            return _DatosInicioGerenteDAL.ProductosSinStock();
        }

        public List<VentaDelDia> ObtenerVentasDelDia()
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("Debe iniciar sesion para realizar la solicitud");
            }
            return _DatosInicioGerenteDAL.ObtenerVentasDelDia();
        }
    }
}
