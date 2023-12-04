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
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
            llenar_grid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenar_grid()
        {
            for (int i = 1; i < 10; i++)
            {
                dgCategorias.Rows.Add(i, $"Categoría {i + 1}");
            }


        }

        private void dgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCategorias.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgCategorias.CurrentRow.Index; //verifico cual fila fue seleccionada
                if (MessageBox.Show("Seguro borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgCategorias[0, posActual].Value.ToString()}");// sacamos mensaje

            }
            if (dgCategorias.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgCategorias.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEditarCategoria categoria = new frmEditarCategoria();// instanciamos el formulario
                categoria.IdCategoria = int.Parse(dgCategorias[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                categoria.ShowDialog(); // mostramos el formulario de forma modal
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCategoria categoria = new frmEditarCategoria();
            categoria.IdCategoria = 0;
            categoria.ShowDialog();
        }
    }
}
