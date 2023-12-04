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
    public partial class frmRolesEmpleados : Form
    {
        public frmRolesEmpleados()
        {
            InitializeComponent();
            llenar_grid();
        }


        public void llenar_grid()
        {
            for (int i = 1; i < 8; i++)
            {
                dgRoles.Rows.Add($"{i + 3256487}", $"Rol {i}");
            }


        }

        private void dgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRoles.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgRoles.CurrentRow.Index; //verifico cual fila fue seleccionada
                if (MessageBox.Show("Seguro borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgRoles[0, posActual].Value.ToString()}");// sacamos mensaje

            }
            if (dgRoles.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgRoles.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEditarRolEmpleados rol = new frmEditarRolEmpleados();// instanciamos el formulario
                rol.IdRol = int.Parse(dgRoles[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                rol.ShowDialog(); // mostramos el formulario de forma modal

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarRolEmpleados rol = new frmEditarRolEmpleados();
            rol.IdRol = 0;
            rol.ShowDialog();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }
    }
}
