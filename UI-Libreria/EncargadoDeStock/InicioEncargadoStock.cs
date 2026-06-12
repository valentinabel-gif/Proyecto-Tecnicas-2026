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

namespace UI_Libreria.EncargadoDeStock
{
    public partial class InicioEncargadoStock : Form
    {
        //Declaramos los User Control
        UcInicio VistaInicio;
        UcIngresos VistaIngresos;
        UcProveedores VistaProveedores;
        UcStock VistaStock;
        UcProductos VistaProductos;

        public InicioEncargadoStock()
        {
            InitializeComponent();
            //Fecha del inicio
            Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            //Creamos una sola vez los User Control
            VistaInicio= new UcInicio();
            VistaIngresos = new UcIngresos();
            VistaProveedores = new UcProveedores();
            VistaStock = new UcStock();
            VistaProductos = new UcProductos();

            AbrirUserControl(VistaInicio);
        }

        private void AbrirUserControl(UserControl uc)
        {
            InicioPanel.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            InicioPanel.Controls.Add(uc);

            uc.BringToFront();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaInicio);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InicioEncargadoStock_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Sesion.Instancia.CerrarSesion(); // Singleton limpia la sesión
                login loginForm = new login();  // abrís el form de login
                loginForm.Show();
                this.Close();
            }
        }

        private void BtnIngresos_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaIngresos);
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaProveedores);
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaStock);
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaProductos);
        }

        private void InicioPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }
