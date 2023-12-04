using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; set; }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            if (IdEmpleado == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {//actualizar el registro con el id pasado
                lblTitulo.Text = "MODIFICAR EMPLEADO";
                txtNombreEmpleado.Text = "Empleado 1";
                txtDocumentoEmpleado.Text = IdEmpleado.ToString();
                txtDireccionEmpleado.Text = "Dirección empleado";
                txtTelefonoEmpleado.Text = "Telefono empleado";
                txtEmailEmpleado.Text = "Email empleado";
                comboRolEmpleado.Text = "Operador";
                datosEmpleado.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
                    "incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco " +
                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit" +
                    " esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, " +
                    "sunt in culpa qui officia deserunt mollit anim id est laborum";




            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
