using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class Reporte
    {
        //atributos
        private int _reporteID;
        private int _usuarioID;
        private string _cuil; //agregue cuil para q quede el usuario q lo genera
        private string _formatoReporte;
        private DateTime _fechaReporte;

        //constructor
        public Reporte(int reporteID, int usuarioID, string cuil, string formatoReporte, DateTime fechaReporte)
        {
            _reporteID = reporteID;
            _usuarioID = usuarioID;
            _cuil = cuil;
            _formatoReporte = formatoReporte;
            _fechaReporte = fechaReporte;

        }

        //propiedades
        public int ReporteID
        {
            get { return _reporteID; }
        }
        public int UsuarioID
        {
            get { return _usuarioID; }
        }
        public string Cuil
        {
            get { return _cuil; }
        }
        public string FormatoReporte
        {
            get { return _formatoReporte; }
        }
        public DateTime FechaReporte
        {
            get { return _fechaReporte; }
        }
    }

}
