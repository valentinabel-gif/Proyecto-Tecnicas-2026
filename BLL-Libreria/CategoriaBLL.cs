using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Libreria;

namespace BLL_Libreria
{
    public class CategoriaBLL
    {

        private CategoriaDAL _categoriaDAL = new CategoriaDAL();

        public int ContarCategoria()
        {
            return _categoriaDAL.ContarCategoria();
        }

    }
}
