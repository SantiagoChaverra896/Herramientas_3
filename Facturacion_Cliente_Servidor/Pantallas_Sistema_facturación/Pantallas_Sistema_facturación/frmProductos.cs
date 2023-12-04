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

        DataTable dt = new DataTable();//creamos un objeto de tipo datatable para almacenar lo consultado
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto de la clase acceso a datos

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgProductos.CurrentRow.Index; //verifico cual fila fue seleccionada, identificador de la fila a borrar

                if (MessageBox.Show($"Seguro desea borrar el producto {dgProductos[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {  //invocamos el procedimiento almacenado de eliminar producto y pasamos como parametro el Id del cliente
                    int IdProducto = Convert.ToInt32(dgProductos[0, posActual].Value.ToString());

                    string sentencia = $"Exec Eliminar_producto '{IdProducto}' ";
                    string Mensaje = Acceso.EjecutarComando(sentencia);

                    MessageBox.Show(Mensaje);
                    llenar_gridProductos(); // Se llama nuevamente la instruccion para mostrar los datos actualizados

                }
            }
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgProductos.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmEditarProductos producto = new frmEditarProductos();// instanciamos el formulario
                producto.IdProductos = int.Parse(dgProductos[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del producto seleccionado
                producto.ShowDialog(); // mostramos el formulario de forma modal

            }


        }

        public void llenar_gridProductos()
        {
           
            dgProductos.Rows.Clear(); // limpiamos el contenido del datagrid

            string sentencia = $"select TP.IdProducto, TP.StrNombre, CP.StrDescripcion, TP.NumPrecioVenta, TP.NumStock from TBLPRODUCTO TP JOIN TBLCATEGORIA_PROD CP ON TP.IdCategoria = CP.IdCategoria"; // Sentencia a ejecutar
            dt = Acceso.EjecutarComandoDatos(sentencia); // invocamos el metodo de EjecutarComandoDatos que fue creado en nuestra clase Acceso_Datos 
            //recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                dgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }


        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            frmEditarProductos producto = new frmEditarProductos(); // se crea el objeto del formulario
            producto.IdProductos = 0; // esta es una propiedad o atributo que debe ser creada en el frmClientes
                                   // esto permite pasar el idcliente del formulario FrmListarClientes al FrmClientes
                                   // se pasa el valor 0 para indicar que se trata de un nuevo cliente

            producto.ShowDialog(); // mostramos el formulario de forma modal
            llenar_gridProductos(); // cuando sale de la ventana mostramos de nuevo el grid para ver el registro ingresado




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
            if (txtBuscar.Text != "")
            {
                dgProductos.Rows.Clear(); // limpiamos el contenido del data grid
                // creamos la sentencia de consulta con un parametro del texto a buscar
                string sentencia = $"select * from TBLPRODUCTO where StrNombre like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia); // ejecutamos la consulta

                foreach (DataRow row in dt.Rows)
                {
                    dgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4]); // llenamos el grid con lo consultado
                }

            }
            else
            {
                llenar_gridProductos();
            }
        }
    }
}
