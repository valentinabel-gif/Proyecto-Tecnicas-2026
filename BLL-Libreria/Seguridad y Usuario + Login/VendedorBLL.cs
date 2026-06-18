using BE_Libreria.Ventas;
using DAL_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria.Seguridad_y_Usuario___Login
{
    public class VendedorBLL
    {
        private VendedorDAL _dal = new VendedorDAL();

        public List<Vendedor> BuscarVendedor(string busqueda)
        {
            return _dal.BuscarVendedor(busqueda);
        }

        public Vendedor TraerEstadisticas(int IdUsuario)
        {
            return _dal.TraerEstadisticas(IdUsuario);
        }
    }
}
