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

        DataTable dt = new DataTable();//creamos un objeto de tipo datatable para almacenar lo consultado
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto de la clase acceso a datos

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void llenar_grid()
        {
            /*for (int i = 1; i < 10; i++) 
            {
                dgClientes.Rows.Add(i, $"Nombre {i} Apellido 1 Apellido 2", $"{i * 12345}", $"{i * 12345}");            
            }*/
            dgClientes.Rows.Clear(); // limpiamos el contenido del datagrid

            string sentencia = $"select IdCliente, StrNombre, NumDocumento, StrTelefono FROM TBLCLIENTES"; // Sentencia a ejecutar
            dt = Acceso.EjecutarComandoDatos(sentencia); // invocamos el metodo de EjecutarComandoDatos que fue creado en nuestra clase Acceso_Datos 
            //recorremos los datos consultados para llenar el grid
            foreach(DataRow row in dt.Rows) 
            {
                dgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
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
            if (dgClientes.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgClientes.CurrentRow.Index; //verifico cual fila fue seleccionada, identificador de la fila a borrar

                if (MessageBox.Show($"Seguro desea borrar al cliente {dgClientes[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {  //invocamos el procedimiento almacenado de eliminar cliente y pasamos como parametro el Id del cliente
                    int IdCliente = Convert.ToInt32(dgClientes[0, posActual].Value.ToString());

                    string sentencia = $"Exec Eliminar_cliente '{IdCliente}'";
                    string Mensaje = Acceso.EjecutarComando(sentencia);

                    MessageBox.Show(Mensaje);
                    llenar_grid(); // Se llama nuevamente la instruccion para mostrar los datos actualizados

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
            frmEditarCliente cliente = new frmEditarCliente(); // se crea el objeto del formulario
            cliente.IdCliente = 0; // esta es una propiedad o atributo que debe ser creada en el frmClientes
                                   // esto permite pasar el idcliente del formulario FrmListarClientes al FrmClientes
                                   // se pasa el valor 0 para indicar que se trata de un nuevo cliente

            cliente.ShowDialog(); // mostramos el formulario de forma modal
            llenar_grid(); // cuando sale de la ventana mostramos de nuevo el grid para ver el registro ingresado




        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgClientes.Rows.Clear(); // limpiamos el contenido del data grid
                // creamos la sentencia de consulta con un parametro del texto a buscar
                string sentencia = $"select * from TBLCLIENTES where strNombre like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia); // ejecutamos la consulta

                foreach (DataRow row in dt.Rows)
                {
                    dgClientes.Rows.Add(row[0], row[1], row[2], row[3]); // llenamos el grid con lo consultado
                }

            }
            else 
            {
                llenar_grid();
            }
        }
    }
}
