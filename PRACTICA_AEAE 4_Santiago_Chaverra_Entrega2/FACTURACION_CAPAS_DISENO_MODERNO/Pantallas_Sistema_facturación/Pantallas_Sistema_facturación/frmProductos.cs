using Capa_LogicaDeNegocios;
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
            
        }

        DataTable dt = new DataTable(); // dataTable para consulta de datos
        Cls_Productos producto = new Cls_Productos(); // instanciamos el objeto cliente



        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                /*int posActual = dgProductos.CurrentRow.Index; //verifico cual fila fue seleccionada
                if (MessageBox.Show("Seguro borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgProductos[0, posActual].Value.ToString()}");// sacamos mensaje*/

                int indiceFila = e.RowIndex;
                int posActual = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells[0].Value);
                string Ro = Convert.ToString(dgProductos.Rows[e.RowIndex].Cells[1].Value);

                if (MessageBox.Show("Seguro borrar: " + Ro, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    producto.C_IdProducto = posActual;
                    producto.EliminarProducto();
                    producto.C_IdProducto = 0;
                    dgProductos.Rows.RemoveAt(indiceFila);

                }


            }
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgProductos.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEditarProductos producto = new frmEditarProductos();// instanciamos el formulario
                producto.IdProductos  = int.Parse(dgProductos[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                producto.ShowDialog(); // mostramos el formulario de forma modal
                llenar_gridProductos();

            }
            

        }

        public void llenar_gridProductos()
        {
            dgProductos.Rows.Clear(); //limpiamos los datos previos del grid
            dt = producto.ConsultaProducto();// llenamos el datagrid con los datos retornados desde el metodo Consulta_Cliente()

            if (dt.Rows.Count > 0) // verifico si retorno valores 
            {
                foreach (DataRow row in dt.Rows)// esta instruccion permite recorrer todas las filas retornadas
                    dgProductos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());

            }
            else
            {
                MessageBox.Show("No se encontraron registros");
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
            llenar_gridProductos();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            llenar_gridProductos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "") // verifico si ingresaron texto a buscar 
            {
                dgProductos.Rows.Clear(); // limpiamos el dataGridView
                dt = producto.Filtrar_Producto(txtBuscar.Text); // invocamos filtrar cliente con el texto del campo a buscar como parametro 

                if (dt.Rows.Count > 0) // si retorna valores los recorremos para llenar el datagridview 
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgProductos.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron registros por la busqueda solicitada");
                    llenar_gridProductos();
                }


            }
            else
            {
                llenar_gridProductos(); // sino ingresaron valor a buscar llenamos el grid con todos los valores
            }
            txtBuscar.Text = "";
        }
    }
}
