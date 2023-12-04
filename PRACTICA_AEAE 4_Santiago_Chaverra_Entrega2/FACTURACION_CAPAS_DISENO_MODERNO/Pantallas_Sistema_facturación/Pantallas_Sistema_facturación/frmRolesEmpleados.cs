using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Pantallas_Sistema_facturación
{
    public partial class frmRolesEmpleados : Form
    {
        public frmRolesEmpleados()
        {
            InitializeComponent();
            
        }

        DataTable dt = new DataTable(); // dataTable para consultar datos
        Cls_Roles roles = new Cls_Roles();    // instanciamos el objeto roles

        public void llenar_grid()
        {
            dgRoles.Rows.Clear();
            dt = roles.ConsultaRoles();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow rows in dt.Rows)
                {
                    dgRoles.Rows.Add(rows[0].ToString(), rows[1].ToString());
                }
            }

        }





        private void dgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRoles.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                /*int posActual = dgRoles.CurrentRow.Index; //verifico cual fila fue seleccionada
                if (MessageBox.Show("Seguro borrar", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {dgRoles[0, posActual].Value.ToString()}");// sacamos mensaje*/
                int indiceFila = e.RowIndex;
                int posActual = Convert.ToInt32(dgRoles.Rows[e.RowIndex].Cells[0].Value);
                string Ro = Convert.ToString(dgRoles.Rows[e.RowIndex].Cells[1].Value);
                if (MessageBox.Show("Seguro borrar: " + Ro, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (indiceFila >= 0 && indiceFila < dgRoles.Rows.Count)
                    {
                        string result = roles.EliminarRol(posActual);
                        dgRoles.Rows.RemoveAt(indiceFila);
                        MessageBox.Show("Rol Eliminado");
                    }
                }



            }
            if (dgRoles.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                /*int posActual = dgRoles.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEditarRolEmpleados rol = new frmEditarRolEmpleados();// instanciamos el formulario
                rol.IdRol = int.Parse(dgRoles[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                rol.ShowDialog(); // mostramos el formulario de forma modal */
                int posActual = Convert.ToInt32(dgRoles.Rows[e.RowIndex].Cells[0].Value);
                frmEditarRolEmpleados rol = new frmEditarRolEmpleados();
                rol.IdRol= posActual;
                rol.NRol = Convert.ToString(dgRoles.Rows[e.RowIndex].Cells[1].Value);
                rol.ShowDialog();


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
            //MessageBox.Show("Datos Actualizados");




        }

        private void frmRolesEmpleados_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
            if (materialSingleLineTextField1.Text != "") //verifico si ingresaron texto a buscar
            {
                dgRoles.Rows.Clear(); //limpiamos el datagridview
                dt = roles.Filtrar_Empleado(materialSingleLineTextField1.Text); // invocamos filtrar rol con el texto a buscar como parametro 

                if (dt.Rows.Count >0) // si retorna valores los recorremos para llenar el datagridview
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgRoles.Rows.Add(row[0].ToString(), row[1].ToString());
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
            materialSingleLineTextField1.Text = "";
        }

    }
}
