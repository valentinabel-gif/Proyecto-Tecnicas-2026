using BE_Libreria;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_Libreria
{
    public class RolDAL
    {
        private Conexion _conexion = new Conexion();


        public List<Rol> RecuperarRoles()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_RecuperarRoles");

            List<Rol> roles = new List<Rol>();
            if(tabla!= null)
            {
                foreach(DataRow fila in tabla.Rows)
                {
                    roles.Add(new Rol(Convert.ToInt32(fila["id_rol"]), fila["nombre_rol"].ToString()));
                }
            }
            return roles;
        }

    }
}
