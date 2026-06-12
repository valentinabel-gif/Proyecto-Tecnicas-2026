using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria.Seguridad_y_Usuario
{
    public interface ISujetoUsuario
    {
        void RegistrarObservador(IObservadorUsuario observer);
        void EliminarObservador(IObservadorUsuario observer);
        void Notificar();
    }
}
