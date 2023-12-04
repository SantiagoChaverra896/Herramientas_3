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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
            
        }

        public int IdCliente { get; set; } // atributo que permite recibir como parametro el IdCliente
        DataTable dt = new DataTable(); // creamos el objeto de tipo DataTable para almacenar lo consultado.
        Acceso_datos Acceso = new Acceso_datos();

        private void llenar_cliente() 
        {

        
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else {//actualizar el registro con el id pasado
                /*
                lblTitulo.Text = "MODIFICAR CLIENTE";
                txtIdCliente.Text = IdCliente.ToString();
                txtNombre.Text = "Nombre 1 Apellido";
                txtDocumento.Text = "34353446o";
                txtDireccion.Text = "calle donde vive cliente";
                txtTelefono.Text = "35435464";*/
                string sentencia = $"select * from TBLCLIENTES where IdCliente = {IdCliente}"; // consulto el registro del IdCliente

                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach(DataRow row in dt.Rows) 
                {
                    //llenamos los campos con el registro consultado
                    txtIdCliente.Text = IdCliente.ToString();
                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();
                    



                }

                
            }

            
        }

        // ACTUALIZACIONES::::::::::::Funciones que permiten el ingreso, retiro, actualizacion de la informacion de clientes en la base de datos

        public bool Guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Cliente] {IdCliente},'{txtNombre.Text}',{txtDocumento.Text} ,'{txtDireccion.Text}','{txtTelefono.Text}', '{txtEmail.Text}','Santiago','{DateTime.Now.ToShortDateString()}'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("falló inserción" + ex);
                    actualizado =false;
                }
            
            }
            
            return actualizado;
        }

        // Funcion que permite validar los campos del formulario 

        private Boolean validar() 
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "debe ingresar el nombre del cliente");
                txtNombre.Focus();
                errorCampos = false;
            }
            else 
            {
                MensajeError.SetError(txtNombre, "");
            }

            if (txtDocumento.Text == "")
            {
                MensajeError.SetError(txtDocumento, "debe ingresar el documento del cliente");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDocumento, "");
            }

            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El documento debe ser numerico");
                txtDocumento.Focus();
                return false;
            }
            MensajeError.SetError(txtDocumento, "");

            return errorCampos;

        }


        // funcion para validar si un valor dado es numerico

        private bool esNumerico(string num)
        {
            try 
            { 
                double x = Convert.ToDouble(num);
                return true;
            }
            catch(Exception) 
            {
                return false;
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            
            //MessageBox.Show("Datos Actualizados");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtIdCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
