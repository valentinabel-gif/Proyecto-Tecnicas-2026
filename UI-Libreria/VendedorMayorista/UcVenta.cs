using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Libreria.VendedorMayorista
{
    public partial class UcVenta : UserControl
    {
        public UcVenta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificamos si la tecla presionada fue Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Quita el sonido del 'plim'

                // Sumamos el producto a la grilla
                dgvDetalle.Rows.Add("1", "Producto de Prueba", "1500.00");

                txtBusqueda.Clear();

                // Esta línea te va a marcar error hasta que copies el código de abajo
                CalcularTotales();
            }
        }

        private void CalcularTotales()
        {
            double subtotal = 0;

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    subtotal += Convert.ToDouble(row.Cells[2].Value);
                }
            }

            // N2 es para que muestre 2 decimales (formato moneda)
            txtSubtotal.Text = subtotal.ToString("N2");
            txtTotal.Text = subtotal.ToString("N2");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
