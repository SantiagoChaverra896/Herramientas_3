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
    public partial class frmEditarRolEmpleados : Form
    {
        public frmEditarRolEmpleados()
        {
            InitializeComponent();
        }

        public int IdRol { get; set; }




        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarRolEmpleados_Load(object sender, EventArgs e)
        {
            if (IdRol == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVO ROL";
            }
            else
            {//actualizar el registro con el id pasado
                lblTitulo.Text = "MODIFICAR ROL";
                txtNombreRol.Text = "Rol de prueba";
                txtDescripcionRol.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

               
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }
    }
}
