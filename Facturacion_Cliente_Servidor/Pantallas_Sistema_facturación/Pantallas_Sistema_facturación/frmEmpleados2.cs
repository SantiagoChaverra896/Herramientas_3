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
            
        }

        DataTable dt = new DataTable();//creamos un objeto de tipo datatable para almacenar lo consultado
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto de la clase acceso a datos

        public void llenar_grid()
        {
            dgEmpleados.Rows.Clear(); // limpiamos el contenido del datagrid

            string sentencia = $"select IdEmpleado, strNombre, NumDocumento, StrTelefono FROM TBLEMPLEADO"; // Sentencia a ejecutar
            dt = Acceso.EjecutarComandoDatos(sentencia); // invocamos el metodo de EjecutarComandoDatos que fue creado en nuestra clase Acceso_Datos 
            //recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                dgEmpleados.Rows.Add(row[0], row[1], row[2], row[3]);
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
                int posActual = dgEmpleados.CurrentRow.Index; //verifico cual fila fue seleccionada, identificador de la fila a borrar

                if (MessageBox.Show($"Seguro desea borrar al cliente {dgEmpleados[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {  //invocamos el procedimiento almacenado de eliminar cliente y pasamos como parametro el Id del cliente
                    int IdEmpleado = Convert.ToInt32(dgEmpleados[0, posActual].Value.ToString());

                    string sentencia = $"Exec Eliminar_Empleado '{IdEmpleado}'";
                    string Mensaje = Acceso.EjecutarComando(sentencia);

                    MessageBox.Show(Mensaje);
                    llenar_grid(); // Se llama nuevamente la instruccion para mostrar los datos actualizados

                }
            }
            if (dgEmpleados.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgEmpleados.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEmpleados empleado = new frmEmpleados();// instanciamos el formulario
                empleado.IdEmpleado = int.Parse(dgEmpleados[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                empleado.ShowDialog(); // mostramos el formulario de forma modal

            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEmpleados empleado = new frmEmpleados();
            empleado.IdEmpleado = 0;
            empleado.ShowDialog();
        }

        private void frmEmpleados2_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgEmpleados.Rows.Clear(); // limpiamos el contenido del data grid
                // creamos la sentencia de consulta con un parametro del texto a buscar
                string sentencia = $"select * from TBLEMPLEADO where strNombre like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia); // ejecutamos la consulta

                foreach (DataRow row in dt.Rows)
                {
                    dgEmpleados.Rows.Add(row[0], row[1], row[2], row[3]); // llenamos el grid con lo consultado
                }

            }
            else
            {
                llenar_grid();
            }
        }
    }
}
