using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria.Seguridad_y_Usuario
{

    public interface IObservadorUsuario
    {
        void Actualizar(); // Se llama cuando hay cambios en usuarios
    }
}
