using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class TarjetaCredito : MedioDePago
    {
        //esto vendria a ser como un define de C, lo uso para q cuando instanciemos y pida el porcentajeAjuste lo cargue de aca y si el dia de mañana cambia el porcentaje de credito solamente lo cambies de aca y lsito
        public const int PORCENTAJE_RECARGO_DEFAULT = 10;

        //constructor
        public TarjetaCredito(int idMedioPago, string nombreMedioPago, int porcentajeAjuste) : base(idMedioPago, nombreMedioPago, porcentajeAjuste)
        {

        }

        public override double CalcularTotalConAjuste(double montoBase)
        {
            //sumamos el 10% de recargo
            double recargo = montoBase * (PorcentajeAjuste / 100.0);
            return montoBase + recargo;
        }
    }
}
