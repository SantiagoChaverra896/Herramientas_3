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
    public partial class frmListaClientes : Form

        
    {
        public frmListaClientes()
        {
            InitializeComponent();
            

        }



        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void llenar_grid()
        {
            for (int i = 1; i < 10; i++) 
            {
                dgClientes.Rows.Add(i, $"Nombre {i} Apellido 1 Apellido 2", $"{i * 12345}", $"{i * 12345}");            
            }


        }

        private void frmListaClientes_Load(object sender,   EventArgs e)
        {
            llenar_grid();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_3(object sender, EventArgs e)
        {

        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.Columns[e.ColumnIndex].Name=="btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgClientes.CurrentRow.Index; //verifico cual fila fue seleccionada
                if (MessageBox.Show("Seguro borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgClientes[0, posActual].Value.ToString()}");// sacamos mensaje
            
            }
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgClientes.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEditarCliente cliente = new frmEditarCliente();// instanciamos el formulario
                cliente.IdCliente = int.Parse(dgClientes[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                cliente.ShowDialog(); // mostramos el formulario de forma modal
                
            }
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente cliente = new frmEditarCliente();
            cliente.IdCliente = 0;
            cliente.ShowDialog();

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
