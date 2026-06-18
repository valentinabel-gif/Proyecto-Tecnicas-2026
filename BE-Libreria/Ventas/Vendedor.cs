using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria.Ventas
{
    public class Vendedor
    {
        private int _idUsuario;
        private string _vendedorNombre;
        private int _ventas;
        private decimal _total; 


    public int IdUsuario
        {
            get { return _idUsuario; }
        }
    public string VendedorNombre 
        {
            get { return _vendedorNombre; }
        }
    public int Ventas
        {
            get { return _ventas; }
        }
    public decimal Total 
        { 
            get { return _total; }
        }


    public Vendedor(int IdUsuario , string VendedorNombre, int Ventas , decimal Total)
        {
            _idUsuario = IdUsuario;
            _vendedorNombre = VendedorNombre;
            _ventas = Ventas;
            _total = Total;
        }




    }
}
