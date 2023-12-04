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
    public partial class frmEmpleados2 : Form
    {
        public frmEmpleados2()
        {
            InitializeComponent();
            llenar_grid();
        }

        
        public void llenar_grid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgEmpleados.Rows.Add($"{i}", $"Nombre Empleado {i}", $"{10332145+i}", $"{2563699 + i}");
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgEmpleados.CurrentRow.Index; //verifico cual fila fue seleccionada
                if (MessageBox.Show("Seguro borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgEmpleados[0, posActual].Value.ToString()}");// sacamos mensaje

            }
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgEmpleados.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEmpleados empleado = new frmEmpleados();// instanciamos el formulario
                empleado.IdEmpleado= int.Parse(dgEmpleados[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                empleado.ShowDialog(); // mostramos el formulario de forma modal

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEmpleados empleado = new frmEmpleados();
            empleado.IdEmpleado = 0;
            empleado.ShowDialog();
        }
    }
}
