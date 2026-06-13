using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria.Seguridad_y_Usuario
{
    public interface ISujetoRol
    {
        void RegistrarObservador(IObservadorRol observer);
        void EliminarObservador(IObservadorRol observer);
        void Notificar();
    }
}
