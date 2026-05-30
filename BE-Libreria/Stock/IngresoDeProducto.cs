using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class IngresoDeProducto
    {
        //atributos
        private int _idIngresoProducto;
        private DateTime _fechaIngreso;
        private Proveedor _proveedor; 
        private Usuario _usuario;     
        private List<DetalleIngreso> _detallesIngreso;

        //constructor
        public IngresoDeProducto(int idIngresoProducto, DateTime fechaIngreso, Proveedor proveedor, Usuario usuario)
        {
            _idIngresoProducto = idIngresoProducto;
            _fechaIngreso = fechaIngreso;
            _proveedor = proveedor;
            _usuario = usuario;
            _detallesIngreso = new List<DetalleIngreso>();
        }

        //propiedades
        public int IdIngresoProducto
        {
            get { return _idIngresoProducto; }
        }

        public DateTime FechaIngreso
        {
            get { return _fechaIngreso; }
        }

        public Proveedor Proveedor
        {
            get { return _proveedor; }
        }

        public Usuario Usuario
        {
            get { return _usuario; }
        }

        public List<DetalleIngreso> DetallesIngreso
        {
            get { return _detallesIngreso; }
        }

        public double SubTotalIngresos // esta ocupa el lugar de el atributo subtotalingreso, sumo todos los productos que entraron y devuelvo el total
        {
            get
            {
                double acumulador = 0;
                foreach (DetalleIngreso d in _detallesIngreso)
                {
                    acumulador += d.PrecioTotalProducto;
                }
                return acumulador;
            }
        }

        //metodos
        public void AgregarDetalle(DetalleIngreso nuevoDetalle)
        {
            if (nuevoDetalle != null)
            {
                _detallesIngreso.Add(nuevoDetalle);
            }
        }

        public void QuitarDetalle(DetalleIngreso detalleAEliminar)
        {
            _detallesIngreso.Remove(detalleAEliminar);
        }
    }
}
