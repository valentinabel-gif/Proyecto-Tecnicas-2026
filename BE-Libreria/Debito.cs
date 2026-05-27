using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class Debito : MedioDePago
    {
        //constructor
        public Debito(int idMedioPago, string nombreMedioPago, int porcentajeAjuste): base(idMedioPago, nombreMedioPago, porcentajeAjuste)
        {

        }

        public override double CalcularTotalConAjuste(double montoBase)
        {
            return montoBase;//debito no tiene recargo??(preguntar)
        }
    }
}
