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
    public partial class VentaGerente : UserControl
    {
        public VentaGerente()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VentaGerente_Load(object sender, EventArgs e)
        {
            FechaIngreso.Format = DateTimePickerFormat.Custom;
            FechaIngreso.CustomFormat = "MMMM yyyy";

            FechaEgreso.Format = DateTimePickerFormat.Custom;
            FechaEgreso.CustomFormat = "MMMM yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
