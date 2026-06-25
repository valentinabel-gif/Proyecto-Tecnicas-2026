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
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("buscar_proveedor"))
            {
                throw new Exception("Seguridad: No tiene permisos para buscar proveedores.");
            }
            return _dal.BuscarProveedores(busqueda);
        }

        public void EliminarProveedor(int idProveedor)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("eliminar_proveedor"))
            {
                throw new Exception("Seguridad: No tiene permisos para eliminar proveedores.");
            }
            _dal.EliminarProveedor(idProveedor);
        }

        public void ModificarProveedor(Proveedor proveedor)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||!Sesion.Instancia.UsuarioActivo.TienePermiso("modificar_proveedor"))
            {
                throw new Exception("Seguridad: No tiene permisos para modificar proveedores.");
            }
            _dal.ModificarProveedor(proveedor);
        }
    }
}
