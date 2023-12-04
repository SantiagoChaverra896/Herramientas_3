using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Pantallas_Sistema_facturación
{
    public partial class frmListaClientes : Form

        
    {
        public frmListaClientes()
        {
            InitializeComponent();
            

        }

        DataTable dt = new DataTable(); // dataTable para consulta de datos
        Cls_Clientes cliente = new Cls_Clientes(); // instanciamos el objeto cliente



        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void llenar_grid()
        {
            dgClientes.Rows.Clear(); //limpiamos los datos previos del grid
            dt = cliente.ConsultaCliente(); // llenamos el datagrid con los datos retornados desde el metodo Consulta_Cliente()

            if (dt.Rows.Count>0) // verifico si retorno valores 
            {
                foreach(DataRow row in dt.Rows)// esta instruccion permite recorrer todas las filas retornadas
                    dgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());

            }
            else 
            {
                MessageBox.Show("No se encontraron registros");
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
                int indiceFila = e.RowIndex;
                int posActual = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells[0].Value);
                string Ro = Convert.ToString(dgClientes.Rows[e.RowIndex].Cells[1].Value);

                if(MessageBox.Show("Seguro borrar: "+Ro, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                {
                    cliente.Cls_IdCliente = posActual;
                    cliente.EliminarCliente();
                    cliente.Cls_IdCliente = 0;
                    dgClientes.Rows.RemoveAt(indiceFila);
                }


                            
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
            frmEditarCliente cliente = new frmEditarCliente(); // creamos el objeto del formulario para actualizar los datos empleados
            cliente.IdCliente = 0; // parametro del id del empleado, al pasar 0 indica que es un nuevo registro
            cliente.ShowDialog(); // mostramos el formulario
            llenar_grid(); // una vez actualizados los datos cargamos de nuevo el grid para ver los cambios realizados

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "") // verifico si ingresaron texto a buscar 
            {
                dgClientes.Rows.Clear(); // limpiamos el dataGridView
                dt = cliente.Filtrar_Cliente(txtBuscar.Text); // invocamos filtrar cliente con el texto del campo a buscar como parametro 

                if (dt.Rows.Count > 0) // si retorna valores los recorremos para llenar el datagridview 
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgClientes.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());
                    }

                }
                else 
                {
                    MessageBox.Show("No se encontraron registros por la busqueda solicitada"); 
                    llenar_grid();
                }

            
            }
            else 
            {
                llenar_grid(); // sino ingresaron valor a buscar llenamos el grid con todos los valores
            }
            txtBuscar.Text = "";
        }
    }
}
