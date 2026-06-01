using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//esta es la clase contenedor del composite, con la lista de medidas va a contener los permmisos y los roles hijos de algun rol

namespace BE_Libreria
{
    public class Rol : MedidaDeSeguridad
    {
        //lista privada para almacenar los permisos del rol y los roles hijos de ese rol
        private List<MedidaDeSeguridad> _listaMedidas;

        //constructor
        public Rol(int idRol, string nombreRol) : base(idRol, nombreRol)
        {
            _listaMedidas = new List<MedidaDeSeguridad>();
        }

        //propiedad
        public List<MedidaDeSeguridad> ListaMedidas
        {
            get { return _listaMedidas; }
        }

        //metodos

        public override void Agregar(MedidaDeSeguridad medida)
        {
            if (medida != null && !_listaMedidas.Contains(medida))
            {
                _listaMedidas.Add(medida);
            }
        }
        public override void Quitar(MedidaDeSeguridad medida)
        {
            if (medida != null)
            {
                _listaMedidas.Remove(medida);
            }
        }

        public override List<MedidaDeSeguridad> ObtenerMedidas()
        {
            return _listaMedidas;
        }

        public override bool TienePermiso(string nombrePermisoBusca)
        {
            foreach (MedidaDeSeguridad medida in _listaMedidas)
            {
                //si la medida es un permiso lo valida directamente y si llega a ser un rol hijo eel foreach vuelve a arrancar adentro de ese rol
                if (medida.TienePermiso(nombrePermisoBusca))
                {
                    return true;
                }
            }
            return false; //si recorre todo el asrbol y no encuentra nada manda false
        }

    }
}
