using BE_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class ProveedorDAL
    {
        private Conexion _conexion = new Conexion();

        public List<Proveedor> BuscarProveedores(string busqueda)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@busqueda", busqueda)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_BuscarProveedores", parametros);
            List<Proveedor> proveedores = new List<Proveedor>();

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    proveedores.Add(new Proveedor(
                        Convert.ToInt32(fila["id_proveedor"]),fila["nombre_proveedor"].ToString(),fila["cuit"].ToString(),fila["telefono"].ToString()));
                }
            }
            return proveedores;
        }

        public void EliminarProveedor(int idProveedor)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_proveedor", idProveedor)
            };
            _conexion.EscribirPorStoreProcedure("sp_EliminarProveedor", parametros);
        }

        public void ModificarProveedor(Proveedor proveedor)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_proveedor", proveedor.IdProveedor),
                _conexion.crearParametro("@nombre_proveedor", proveedor.NombreProveedor),
                _conexion.crearParametro("@cuit", proveedor.CuitProveedor),
                _conexion.crearParametro("@telefono", proveedor.TelefonoProveedor),
            };
            _conexion.EscribirPorStoreProcedure("sp_ModificarProveedor", parametros);
        }
    }
}

