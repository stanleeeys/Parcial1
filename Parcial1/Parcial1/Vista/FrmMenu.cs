using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1.Vista
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_Empleado = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Empl_nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Empl_apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string Empl_DUI = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string Empl_direccion = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string Empl_tel = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string Empl_email = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string Empl_cargo = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            txtIdEmpleado.Text = Id_Empleado;
            txtEmpl_nombre.Text = Empl_nombre;
            txtApellido.Text = Empl_apellido;
            txtDui.Text = Empl_DUI;
            txtDireccion.Text = Empl_direccion;
            txtTel.Text = Empl_tel;
            txtemail.Text = Empl_email;
            txtCargo.Text = Empl_cargo;

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
