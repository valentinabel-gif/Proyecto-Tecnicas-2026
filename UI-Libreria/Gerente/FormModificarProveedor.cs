using BE_Libreria;
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

namespace UI_Libreria.Gerente
{
    public partial class FormModificarProveedor : Form
    {
        private int _idProveedor;
        private ProveedorBLL _proveedorBLL;
        public FormModificarProveedor(int idProveedor, ProveedorBLL proveedorBLL)
        {
            InitializeComponent();
            _idProveedor = idProveedor;
            _proveedorBLL = proveedorBLL;
        }

        private void FormModificarProveedor_Load(object sender, EventArgs e)
        {
            CargarDatosProveedor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatosProveedor()
        {
            Proveedor proveedor = _proveedorBLL.BuscarProveedores("").Find(p => p.IdProveedor == _idProveedor);

            if (proveedor != null)
            {
                txtNombre.Text = proveedor.NombreProveedor;
                txtTelefono.Text = proveedor.TelefonoProveedor.ToString();
                txtCuit.Text = proveedor.CuitProveedor;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||string.IsNullOrWhiteSpace(txtTelefono.Text) ||string.IsNullOrWhiteSpace(txtCuit.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Proveedor proveedor = new Proveedor(_idProveedor, txtNombre.Text.Trim(), txtCuit.Text.Trim(), txtTelefono.Text.Trim());
                _proveedorBLL.ModificarProveedor(proveedor);

                MessageBox.Show("Proveedor modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Valida que el cuit sea solo numeros
        private void TxtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // Solo letray numeros y espacios para el nombre
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        // }numero y guion (opcional) para el telefono
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '-' || char.IsControl(e.KeyChar));

        }
    }

}
