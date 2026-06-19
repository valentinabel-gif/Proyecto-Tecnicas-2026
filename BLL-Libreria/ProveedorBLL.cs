using BE_Libreria;
using DAL_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class ProveedorBLL
    {
        private ProveedorDAL _dal = new ProveedorDAL();

        public List<Proveedor> BuscarProveedores(string busqueda)
        {
            return _dal.BuscarProveedores(busqueda);
        }

        public void EliminarProveedor(int idProveedor)
        {
            _dal.EliminarProveedor(idProveedor);
        }

        public void ModificarProveedor(Proveedor proveedor)
        {
            _dal.ModificarProveedor(proveedor);
        }
    }
}
