using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class Categoria
    {
        //atributos
        private int _idCategoria;
        private string _nombreCategoria;

        //constructor
        public Categoria (int idCategoria,  string nombreCategoria)
        {
            _idCategoria = idCategoria;
            _nombreCategoria = nombreCategoria;
        }

        //propiedades
        public int IdCategoria
        {
            get { return _idCategoria; }
        }

        public string NombreCategoria
        {
            get { return _nombreCategoria; }
        }


    }
}
