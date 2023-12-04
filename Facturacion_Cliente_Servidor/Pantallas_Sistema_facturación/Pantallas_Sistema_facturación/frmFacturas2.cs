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
    public partial class frmFacturas2 : Form
    {
        public frmFacturas2()
        {
            InitializeComponent();
            
        }

        DataTable dt = new DataTable();//creamos un objeto de tipo datatable para almacenar lo consultado
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto de la clase acceso a datos


        public void llenar_grid()
        {
            /*for (int i = 1; i < 10; i++)
            {
                dgFacturas.Rows.Add($"{i}", $"Nombre Cliente {i}", "05/05/2023",$"{547*i}","Pendiente");
            }*/

            dgFacturas.Rows.Clear(); // limpiamos el contenido del datagrid

            string sentencia = $"select f.IdFactura, c.StrNombre, f.DtmFecha, f.NumValorTotal, ef.StrDescripcion FROM TBLFACTURA f join TBLESTADO_FACTURA ef on ef.IdEstadoFactura = f.IdEstado join TBLCLIENTES c on c.IdCliente = f.IdCliente"; // Sentencia a ejecutar
            dt = Acceso.EjecutarComandoDatos(sentencia); // invocamos el metodo de EjecutarComandoDatos que fue creado en nuestra clase Acceso_Datos 
            //recorremos los datos consultados para llenar el grid
            foreach (DataRow row in dt.Rows)
            {
                dgFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnBorrar") // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int posActual = dgFacturas.CurrentRow.Index; //verifico cual fila fue seleccionada, identificador de la fila a borrar

                if (MessageBox.Show($"Seguro desea borrar al cliente {dgFacturas[1, posActual].Value.ToString()}", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {  //invocamos el procedimiento almacenado de eliminar cliente y pasamos como parametro el Id del cliente
                    int IdFactura = Convert.ToInt32(dgFacturas[0, posActual].Value.ToString());

                    // No encontré el procedimiento almacenado en la base de datos para eliminar facturas por ende se deja esta porción comentada y se muestra mensaje generico. 
                    /*string sentencia = $"Exec Eliminar_Factura '{IdFactura}' ";
                    string Mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(Mensaje);*/

                    MessageBox.Show("Factura eliminada exitosamente");

                    llenar_grid(); // Se llama nuevamente la instruccion para mostrar los datos actualizados

                }
            }
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnEditar") // verifica si presiono un boton editar
            {
                int posActual = dgFacturas.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmFacturas factura = new frmFacturas();// instanciamos el formulario
                factura.IdFactura = int.Parse(dgFacturas[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                factura.ShowDialog(); // mostramos el formulario de forma modal

            }


        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            frmFacturas factura = new frmFacturas();
            factura.IdFactura = 0;
            factura.ShowDialog();
           
        }

        private void frmFacturas2_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgFacturas.Rows.Clear(); // limpiamos el contenido del data grid
                // creamos la sentencia de consulta con un parametro del texto a buscar
                string sentencia = $"select f.IdFactura, c.StrNombre, f.DtmFecha, f.NumValorTotal, ef.StrDescripcion FROM TBLFACTURA f join TBLESTADO_FACTURA ef on ef.IdEstadoFactura = f.IdEstado join TBLCLIENTES c on c.IdCliente = f.IdCliente where c.StrNombre like '%{txtBuscar.Text}%'";
                dt = Acceso.EjecutarComandoDatos(sentencia); // ejecutamos la consulta

                foreach (DataRow row in dt.Rows)
                {
                    dgFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4]); // llenamos el grid con lo consultado
                }

            }
            else
            {
                llenar_grid();
            }
        }
    }
}
