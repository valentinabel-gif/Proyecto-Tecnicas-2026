using BE_Libreria;
using BE_Libreria.Seguridad_y_Usuario;
using BLL_Libreria;
using BLL_Libreria.Seguridad_y_Usuario___Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Libreria.Administrador
{
    public partial class admiInicio : UserControl , IObservadorUsuario, IObservadorRol
    {

        private UsuarioBLL _usuarioBLL; //= new UsuarioBLL();
        private RolBLL _rolBLL;
        private CategoriaBLL _categoriaBLL = new CategoriaBLL();

    
        public admiInicio(UsuarioBLL usuarioBLL, RolBLL rolBLL)
        {
            InitializeComponent();
            _usuarioBLL = usuarioBLL;
            _rolBLL = rolBLL;
            _usuarioBLL.RegistrarObservador(this);
            _rolBLL.RegistrarObservador(this);
            DatosGrilla();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuInicio_Click(object sender, EventArgs e)
        {
            FormCrearUsuario form = new FormCrearUsuario(_usuarioBLL);
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admiInicio_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
            //DatosGrilla();
            CargarListaUsuarios();

        }

        private void CargarEstadisticas()
        {
            cantUsuarios.Text = _usuarioBLL.ContarUsuarios().ToString();
            cantRoles.Text = _rolBLL.ContarRoles().ToString();
            cantPermisos.Text = _rolBLL.ContarPermisos().ToString();
            txtCategoria.Text = _categoriaBLL.ContarCategoria().ToString();
        }
        private void DatosGrilla()
        {
            ListaUsuarios.AutoGenerateColumns = false;
            ListaUsuarios.Columns.Clear();

            ListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Usuario", DataPropertyName = "UsernameUsuario", Width = 150 });
            ListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Rol", DataPropertyName = "NombreRolUsuario", Width = 150 });


        }

        private void CargarListaUsuarios()
        {
            List<Usuario> usuarios = _usuarioBLL.RecuperarTodosLosUsuarios();
            ListaUsuarios.DataSource = null;
            ListaUsuarios.DataSource = usuarios;
            ListaUsuarios.Refresh();
        }

        private void ListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void IObservadorUsuario.Actualizar()
        {
            CargarListaUsuarios();
            CargarEstadisticas();
        }

        void IObservadorRol.Actualizar()
        {
            CargarEstadisticas(); // actualiza el contador de roles
            
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cantRoles_Click(object sender, EventArgs e)
        {

        }

        private void cantUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearRolInicio_Click(object sender, EventArgs e)
        {
            FormCrearRol form = new FormCrearRol(_rolBLL);
            form.ShowDialog();
        }
    }
}
