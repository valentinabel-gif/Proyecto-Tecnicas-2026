using BE_Libreria;
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
    public partial class FormEditarRol : Form
    {
        private Rol _rol;
        private RolBLL _rolBLL;
        private List<Permiso> _todosLosPermisos;
        private List<Permiso> _permisosDelRol;
        public FormEditarRol(Rol rol, RolBLL rolBLL)
        {
            InitializeComponent();
            _rol = rol;
            _rolBLL = rolBLL;
        }

        private void FormEditarRol_Load(object sender, EventArgs e)
        {
            // Cargás el nombre del rol en el textbox
            txtNombreRol.Text = _rol.NombreMedidaDeSeguridad;

            // Recuperás todos los permisos y los que tiene el rol
            _todosLosPermisos = _rolBLL.RecuperarTodosLosPermisos();
            _permisosDelRol = _rolBLL.RecuperarPermisosPorRol(_rol.IdMedidaDeSeguridad);

            CargarGrillaPermisos();
        }
        private void CargarGrillaPermisos()
        {
            dgvPermisos.AutoGenerateColumns = false;
            dgvPermisos.Columns.Clear();

            dgvPermisos.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Permisos",
                Name = "colNombrePermiso",
                Width = 200,
                ReadOnly = true
            });
            dgvPermisos.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Permiso",
                Name = "colTienePermiso",
                Width = 80
            });

            // Cargás cada permiso y marcás el checkbox si el rol lo tiene
            foreach (Permiso p in _todosLosPermisos)
            {
                bool tienePermiso = _permisosDelRol.Exists(x => x.IdMedidaDeSeguridad == p.IdMedidaDeSeguridad);
                dgvPermisos.Rows.Add(p.NombreMedidaDeSeguridad, tienePermiso);
            }
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
                {
                    throw new Exception("El nombre del rol es obligatorio.");
                }
                   
                // Guarda los permisos marcados
                List<Permiso> permisosSeleccionados = new List<Permiso>();
                for (int i = 0; i < dgvPermisos.Rows.Count; i++)
                {
                    bool marcado = Convert.ToBoolean(dgvPermisos.Rows[i].Cells["colTienePermiso"].Value);
                    if (marcado)
                    {
                        permisosSeleccionados.Add(_todosLosPermisos[i]);
                    }
                }

                _rolBLL.ActualizarRol(_rol.IdMedidaDeSeguridad, txtNombreRol.Text, permisosSeleccionados);

                MessageBox.Show("Rol actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir sin guardar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void txtNombreRol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

