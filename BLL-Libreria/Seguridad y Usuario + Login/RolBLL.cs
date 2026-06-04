using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Libreria;
using BE_Libreria;
using System.Runtime.CompilerServices;

namespace BLL_Libreria.Seguridad_y_Usuario___Login
{
    public class RolBLL
    {
        private RolDAL _rolDAL = new RolDAL();
        public List<Rol> ObtenerRoles()
        {
            RolDAL dal = new RolDAL();
            return dal.RecuperarRoles();
        }



    }
}
