using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//medio de pago como clase abstracta

namespace BE_Libreria
{
    public abstract class MedioDePago
    {
        //atributos
        private int _idMedioPago;
        private string _nombreMedioPago;
        private int _porcentajeAjuste; //los porcentajes de ajuste segun medio de pago van a ser fijos

        //constructor
        public MedioDePago(int idMedioPago, string nombreMedioPago, int porcentajeAjuste)
        {
            _idMedioPago = idMedioPago;
            _nombreMedioPago = nombreMedioPago;
            _porcentajeAjuste = porcentajeAjuste;
        }

        // propiedades
        public int IdMedioPago
        {
            get { return _idMedioPago; }
        }

        public string NombreMedioPago
        {
            get { return _nombreMedioPago; }
        }

        public int PorcentajeAjuste
        {
            get { return _porcentajeAjuste; }
        }

        public abstract double CalcularTotalConAjuste(double montoBase);
    }
}
