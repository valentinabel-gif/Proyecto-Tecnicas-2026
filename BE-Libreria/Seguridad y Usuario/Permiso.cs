using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//esta va a ser una de las clases hijas de MedidaDeSeguridad. permiso va a ser la clase hoja del composite porque no va a contener otros permisos adentro solo va a tener sus propios atributos y metodos

namespace BE_Libreria
{
    public class Permiso : MedidaDeSeguridad
    {
        //constructor
        public Permiso(int idPermiso, string nombrePermiso) : base(idPermiso, nombrePermiso)
        {

        }

        public override void Agregar(MedidaDeSeguridad medida)
        {
            throw new ArgumentException();
        }

        public override void Quitar(MedidaDeSeguridad medida)
        {
            throw new ArgumentException();
        }

        public override List<MedidaDeSeguridad> ObtenerMedidas()
        {
            return new List<MedidaDeSeguridad>();
        }
    }
}
