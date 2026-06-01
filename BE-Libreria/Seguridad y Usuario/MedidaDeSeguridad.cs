using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//como vi que rol y permisos tenian los mismos atributos y metodos, creo esta clase asi heredan ambos y no repito codigo, con esto encima aplico el patron Composite porque el rol y el permiso pueden contener otros roles y permisos. si queremos agregar un nuevo rol o permiso, simplemente lo agregamos a esta clase y se hereda a ambos.

namespace BE_Libreria
{
    public abstract class MedidaDeSeguridad
    {
        //atributos
        private int _idMedidaDeSeguridad;
        private string _nombreMedidaDeSeguridad;

        //constructor
        public MedidaDeSeguridad(int idMedidaDeSeguridad, string nombreMedidaDeSeguridad)
        {
            _idMedidaDeSeguridad = idMedidaDeSeguridad;
            _nombreMedidaDeSeguridad = nombreMedidaDeSeguridad;
        }

        //propiedades
        public int IdMedidaDeSeguridad
        {
            get { return _idMedidaDeSeguridad; }
        }
        public string NombreMedidaDeSeguridad
        {
            get { return _nombreMedidaDeSeguridad; }
        }

        //metodos

        public abstract bool TienePermiso(string nombrePermisoBusca);
        public abstract void Agregar(MedidaDeSeguridad medida);
        public abstract void Quitar(MedidaDeSeguridad medida);
        public abstract List<MedidaDeSeguridad> ObtenerMedidas(); //El rol q es el contenedor de permisos va a devolver la lista de permisos que tiene y el permiso va a devolver una lista vacia porque no tiene permisos adentro.
    }
}
