using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria.Stock
{
    public interface ISujetoCategoria
    {
        void RegistrarObservador(IObservadorCategoria observer);
        void EliminarObservador(IObservadorCategoria observer);
        void Notificar();
    }
}
