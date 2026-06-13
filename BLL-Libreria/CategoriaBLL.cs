using BE_Libreria;
using BE_Libreria.Stock;
using DAL_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class CategoriaBLL: ISujetoCategoria
    {

        private CategoriaDAL _categoriaDAL = new CategoriaDAL();
        private List<IObservadorCategoria> _observadores = new List<IObservadorCategoria>();

        public int ContarCategoria()
        {
            return _categoriaDAL.ContarCategoria();
        }
        //observer
        public void RegistrarObservador(IObservadorCategoria observer)
        {
            if (!_observadores.Contains(observer))
                _observadores.Add(observer);
        }

        public void EliminarObservador(IObservadorCategoria observer)
        {
            _observadores.Remove(observer);
        }

        public void Notificar()
        {
            foreach (var obs in _observadores)
                obs.Actualizar();
        }

        //traigo las categorias de la DAL
        public List<Categoria> RecuperarCategorias()
        {
            return _categoriaDAL.RecuperarCategorias();
        }

        //Eliminar categoria

        public void EliminarCategoria(int idCategoria)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("eliminar_categoria"))
                throw new Exception("Seguridad: No cuenta con los permisos necesarios para eliminar categorías.");

            _categoriaDAL.EliminarCategoria(idCategoria);
            Notificar();
        }

        //Modificar categoria

        public void ModificarCategoria(int idCategoria, string nuevoNombre)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("modificar_categoria"))
                throw new Exception("Seguridad: No cuenta con los permisos necesarios para modificar categorías.");

            if (string.IsNullOrWhiteSpace(nuevoNombre))
                throw new Exception("El nombre de la categoría es obligatorio.");

            _categoriaDAL.ModificarCategoria(idCategoria, nuevoNombre);
            Notificar();
        }

        //Crear categoria
        public void CrearCategoria(string nombreCategoria)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("crear_categoria"))
                throw new Exception("Seguridad: No cuenta con los permisos necesarios para crear categorías.");

            if (string.IsNullOrWhiteSpace(nombreCategoria))
                throw new Exception("El nombre de la categoría es obligatorio.");

            _categoriaDAL.CrearCategoria(nombreCategoria);
            Notificar();
        }

    }
}
