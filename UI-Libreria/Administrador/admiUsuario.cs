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
    public partial class admiUsuario : UserControl
    {
        public admiUsuario()
        {
            InitializeComponent();
        }
        private void txtBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admiUsuario_Load(object sender, EventArgs e)
        {
       

            dgvUsuarios.Rows.Add("1", "jperez", "Administrador");

            dgvUsuarios.Rows.Add("2", "mlopez", "Empleado");
        
    }
    }
}
