using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class AlertaStock
    {
        //atributos
        private int _idAlertaStock;
        private string _tipoAlerta;
        private DateTime _fechaAlerta;
        private int _stockAlMomento;
        private Producto _productoItem;

        //constructor
        public AlertaStock(int idAlertaStock, string tipoAlerta, DateTime fechaAlerta, int stockAlMomento, Producto productoItem)
        {
            _idAlertaStock = idAlertaStock;
            _tipoAlerta = tipoAlerta;
            _fechaAlerta = fechaAlerta;
            _stockAlMomento = stockAlMomento;
            _productoItem = productoItem;
        }

        //propiedades
        public int IdAlertaStock
        {
            get { return _idAlertaStock; }
        }
        public string TipoAlerta
        {
            get { return _tipoAlerta; }
        }
        public DateTime FechaAlerta
        {
            get { return _fechaAlerta; }
        }
        public int StockAlMomento
        {
            get { return _stockAlMomento; }
        }
        public Producto ProductoItem
        {
            get { return _productoItem; }
        }
    }
}
