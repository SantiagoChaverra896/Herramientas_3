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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            llenar_gridProductos(); //no encontre la opción de _load, por ende coloque la funcion para llenar el grid una vez se inicialice el componente
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgProductos.CurrentRow.Index; //verifico cual fila fue seleccionada
                if (MessageBox.Show("Seguro borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgProductos[0, posActual].Value.ToString()}");// sacamos mensaje

            }
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgProductos.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEditarProductos producto = new frmEditarProductos();// instanciamos el formulario
                producto.IdProductos  = int.Parse(dgProductos[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                producto.ShowDialog(); // mostramos el formulario de forma modal

            }


        }

        public void llenar_gridProductos()
        {
            for (int i = 1; i < 10; i++)
            {
                dgProductos.Rows.Add(i, $"Producto {i}", $"Categoría {i}", $"{i*123}", $"{i*54}");
            }


        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarProductos productos = new frmEditarProductos();
            productos.IdProductos = 0;
            productos.ShowDialog();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
