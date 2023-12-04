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
    public partial class frmFacturas2 : Form
    {
        public frmFacturas2()
        {
            InitializeComponent();
            llenar_grid();
        }
        public void llenar_grid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgFacturas.Rows.Add($"{i}", $"Nombre Cliente {i}", "05/05/2023",$"{547*i}","Pendiente");
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgFacturas.CurrentRow.Index; //verifico cual fila fue seleccionada
                if (MessageBox.Show("Seguro borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgFacturas[0, posActual].Value.ToString()}");// sacamos mensaje

            }
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgFacturas.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmFacturas factura = new frmFacturas();// instanciamos el formulario
                factura.IdFactura = int.Parse(dgFacturas[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                factura.ShowDialog(); // mostramos el formulario de forma modal

            }
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            frmFacturas factura = new frmFacturas();
            factura.IdFactura = 0;
            factura.ShowDialog();
        }
    }
}
