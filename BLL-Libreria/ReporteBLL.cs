using BE_Libreria;
using BE_Libreria.Stock;
using DAL_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class ReporteBLL
    {
        private ReporteDAL _reporteDAL = new ReporteDAL();
        private ProductoBLL _productoBLL = new ProductoBLL();

        public List<Producto> BuscarProductosParaReporte(string criterio)
        {
            if (!Sesion.Instancia.HaySesionActiva())
                throw new Exception("No hay sesión activa.");

            // Si viene null lo convierte a vacío → el SP trae todo
            if (criterio == null)
                criterio = "";
            return _reporteDAL.BuscarProductosParaReporte(criterio);
  
        }
        public List<Producto> ObtenerAlertaStockBajo(int stockMinimo)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("ver_alerta_mercaderia"))
            {
                throw new Exception("Seguridad: No tiene permisos para ver alertas de mercadería.");
            }
            return _productoBLL.ObtenerProductosStockBajo(stockMinimo);
        }

        public List<ReporteProducto> ObtenerReporte(List<int> ids)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("generar_reporte"))
            {
                throw new Exception("Seguridad: No tiene permisos para ver alertas de mercadería.");
            }


            if (ids == null || ids.Count == 0) throw new Exception("Debe seleccionar al menos un producto.");

            if (ids.Count > 50)throw new Exception( "No se pueden incluir más de 50 productos por reporte.");

            string idsJoined = string.Join(",", ids);

            return _reporteDAL.ObtenerReportePorIds(idsJoined);
        }


    }
}
