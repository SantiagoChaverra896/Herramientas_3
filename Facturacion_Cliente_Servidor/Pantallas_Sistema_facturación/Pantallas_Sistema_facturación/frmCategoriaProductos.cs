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
            
        }

        DataTable dt = new DataTable();//creamos un objeto de tipo datatable para almacenar lo consultado
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto de la clase acceso a datos


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenar_grid()
        {
            /*for (int i = 1; i < 10; i++)
            {
                dgCategorias.Rows.Add(i, $"Categoría {i + 1}");
            }*/

            dgCategorias.Rows.Clear(); // limpiamos el contenido del datagrid

            string sentencia = $"select IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD"; // Sentencia a ejecutar
            dt = Acceso.EjecutarComandoDatos(sentencia); // invocamos el metodo de EjecutarComandoDatos que fue creado en nuestra clase Acceso_Datos 
            //recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                dgCategorias.Rows.Add(row[0], row[1]);
            }


        }

        private void dgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* if (dgCategorias.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
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
             }*/

            if (dgCategorias.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgCategorias.CurrentRow.Index; //verifico cual fila fue seleccionada, identificador de la fila a borrar

                if (MessageBox.Show($"Seguro desea borrar la categoria {dgCategorias[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {  //invocamos el procedimiento almacenado de eliminar cliente y pasamos como parametro el Id del cliente
                    int IdCategoria = Convert.ToInt32(dgCategorias[0, posActual].Value.ToString());

                    string sentencia = $"Exec Eliminar_CategoriaProducto '{IdCategoria}' ";
                    string Mensaje = Acceso.EjecutarComando(sentencia);

                    MessageBox.Show(Mensaje);
                    llenar_grid(); // Se llama nuevamente la funcion para mostrar los datos actualizados

                }
            }
            if (dgCategorias.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgCategorias.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEditarCategoria categoria = new frmEditarCategoria();// instanciamos el formulario
                categoria.IdCategoria = int.Parse(dgCategorias[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                categoria.ShowDialog(); // mostramos el formulario de forma modal
                llenar_grid();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCategoria categoria = new frmEditarCategoria();
            categoria.IdCategoria = 0;
            categoria.ShowDialog();
        }

        private void frmCategoriaProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgCategorias.Rows.Clear(); // limpiamos el contenido del data grid
                // creamos la sentencia de consulta con un parametro del texto a buscar
                string sentencia = $"select * from TBLCATEGORIA_PROD where StrDescripcion like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia); // ejecutamos la consulta

                foreach (DataRow row in dt.Rows)
                {
                    dgCategorias.Rows.Add(row[0], row[1]); // llenamos el grid con lo consultado
                }

            }
            else
            {
                llenar_grid();
            }
        }
    }
}
