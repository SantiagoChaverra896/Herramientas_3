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
    public partial class frmEmpleados2 : Form
    {
        public frmEmpleados2()
        {
            InitializeComponent();
            
        }

        DataTable dt = new DataTable(); // dataTable para consulta de datos
        Cls_Empleados empleado = new Cls_Empleados(); // instanciamos el objeto empleado
        
        public void llenar_grid()
        {
           /* for (int i = 1; i < 10; i++)
            {
                dgEmpleados.Rows.Add($"{i}", $"Nombre Empleado {i}", $"{10332145+i}", $"{2563699 + i}");
            }*/

            dgEmpleados.Rows.Clear(); // limpiamos los datos del grid
            dt = empleado.ConsultaEmpleado(); // llenamos el data table (dt), con los datos retornados desde el metodo ConsultaEmpleado()

            if (dt.Rows.Count>0) //verifico si retorno valores 
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());
                } 
                
            }
            else 
            {
                MessageBox.Show("No se encontraron registros");
            }

            txtBuscar.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                               
                int indiceFila = e.RowIndex;
                int posActual = Convert.ToInt32(dgEmpleados.Rows[e.RowIndex].Cells[0].Value);
                string Ro = Convert.ToString(dgEmpleados.Rows[e.RowIndex].Cells[1].Value);
                if (MessageBox.Show("Seguro borrar: " + Ro, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (indiceFila >= 0 && indiceFila < dgEmpleados.Rows.Count)
                    {
                        empleado.C_IdEmpleado = posActual;
                        empleado.EliminarEmpleado();
                        empleado.C_IdEmpleado = 0;
                        dgEmpleados.Rows.RemoveAt(indiceFila);
                    }
                }



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
            frmEmpleados empleado = new frmEmpleados(); // creamos el objeto del formulario para actualizar los datos de empleados
            empleado.IdEmpleado = 0; // parametro del id del empleado, al pasar cero indica que es nuevo registro
            empleado.ShowDialog(); //mostramos el formulario
            llenar_grid(); // una vez actualizados los datos, cargamos de nuevo el grid para ver los cambios realizados
        }

        private void frmEmpleados2_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text != "") //verifico si ingresaron el texto a buscar
            {
                dgEmpleados.Rows.Clear();// limpiamos el datagrid view
                dt = empleado.Filtrar_Empleado(txtBuscar.Text); // invocamos filtrar empleado con el texto a buscar como parametro

                if (dt.Rows.Count > 0) // si retorno valores los recorremos para llenar el datagrid view 
                { 
                    foreach(DataRow row in dt.Rows) 
                    {
                        dgEmpleados.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());
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
                llenar_grid(); // si no ingresaron valor a buscar llamamos el grid con todos los valores
            }
            txtBuscar.Text = "";
        }
    }
}
