using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class frmListaClientes : Form        
    {
        SqlConnection conexion;
        SqlCommand cmd;
        DataTable table = new DataTable();
        Acceso_datos acceso_Datos = new Acceso_datos();
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
            dgClientes.Rows.Clear();
            string strconsulta = "Select * from TBLCLIENTES";
            table = acceso_Datos.EjecutarComandoDatos(strconsulta);

            foreach (DataRow row in table.Rows)
            {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[4], row[3], row[5]);
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
            if (e.ColumnIndex == dgClientes.Columns["btnBorrar"].Index && e.RowIndex >= 0)
            {
                int indiceFila = e.RowIndex;
                int posActual = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells[0].Value);
                string Nom = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[1].Value);
                if (MessageBox.Show("Seguro borrar: " + Nom, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sentencia = $"Exec Eliminar_cliente '{ posActual }'";
                    string mensaje = acceso_Datos.EjecutarComando(sentencia);
                    MessageBox.Show(mensaje);
                    if (indiceFila >= 0 && indiceFila < dgClientes.Rows.Count)
                    {
                        dgClientes.Rows.RemoveAt(indiceFila);
                    }
                }
            }
            if (e.ColumnIndex == dgClientes.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                int posActual = dgClientes.CurrentRow.Index; 
                frmEditarCliente cliente = new frmEditarCliente();
                cliente.IdCliente = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells[0].Value);
                cliente.Nombre = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[1].Value);
                cliente.identificacion = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[2].Value);
                cliente.telefono = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[3].Value);
                cliente.direccion = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[4].Value);
                cliente.correo = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[5].Value);
                cliente.ShowDialog(); 
                
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
