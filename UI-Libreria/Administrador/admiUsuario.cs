using BE_Libreria;
using BE_Libreria.Seguridad_y_Usuario;
using BLL_Libreria;
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
    public partial class admiUsuario : UserControl , IObservadorUsuario//obs
    {
        private List<Usuario> _listaUsuarios = new List<Usuario>();
        private UsuarioBLL _usuarioBLL; //= new UsuarioBLL();

        public admiUsuario(UsuarioBLL usuarioBLL)
        {
            InitializeComponent();
            _usuarioBLL = usuarioBLL;
            _usuarioBLL.RegistrarObservador(this);//obs
        }
        private void txtBuscar_Enter(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //editar usuario
            if (e.RowIndex < 0) return;

            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "colEditar")
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["id_usuario"].Value);

                FormEditarUsuario frm = new FormEditarUsuario(idUsuario, _usuarioBLL);
                frm.FormClosed += (s, args) => CargarListaUsuarios();
                frm.ShowDialog();
            }


            //eliminar usuario

            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["id_usuario"].Value);
                string username = dgvUsuarios.Rows[e.RowIndex].Cells["nombre_usuario"].Value.ToString();

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea eliminar al usuario {username}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        _usuarioBLL.BajaUsuario(idUsuario);
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void admiUsuario_Load(object sender, EventArgs e)
        {

            CargarListaUsuarios();

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                dgvUsuarios.DataSource = new List<Usuario>(_listaUsuarios);
                lblSinResultados.Visible = false; // para que no se vea el label
                return;
            }

            List<Usuario> filtrados = _listaUsuarios
                .Where(u => u.UsernameUsuario.ToLower().Contains(textoBusqueda) ||
                            u.NombreRolUsuario.ToLower().Contains(textoBusqueda))
                .ToList();

            dgvUsuarios.DataSource = filtrados;
            // lblSinResultados.Visible = filtrados.Count == 0;
            //verifico
            if (filtrados.Count == 0)
            {
                lblSinResultados.Visible = true;
            }
            else
            {
                lblSinResultados.Visible = false;
            }

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            btnBuscarUsuario_Click(sender, e);
        }

        private void CargarListaUsuarios()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            _listaUsuarios = _usuarioBLL.RecuperarTodosLosUsuarios();
            dgvUsuarios.DataSource = new List<Usuario>(_listaUsuarios);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Actualizar()
        {
            //MessageBox.Show("Observer ejecutando");
            CargarListaUsuarios();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCrearUsuario form = new FormCrearUsuario(_usuarioBLL);
            form.Show();
        }

        private void lblSinResultados_Click(object sender, EventArgs e)
        {

        }
    }
}
