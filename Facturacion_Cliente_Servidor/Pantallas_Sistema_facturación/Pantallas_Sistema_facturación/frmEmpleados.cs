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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable(); // creamos el objeto de tipo DataTable para almacenar lo consultado.
        Acceso_datos Acceso = new Acceso_datos();

        public int IdEmpleado { get; set; }


        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            if (IdEmpleado == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {//actualizar el registro con el id pasado
                lblTitulo.Text = "MODIFICAR EMPLEADO";
                
                string sentencia = $"select * from TBLEMPLEADO where IdEmpleado = {IdEmpleado}"; // consulto el registro del IdCliente

                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    //llenamos los campos con el registro consultado
                    txtDocumentoEmpleado.Text = IdEmpleado.ToString();
                    txtNombreEmpleado.Text = row[1].ToString();
                    txtDocumentoEmpleado.Text += row[2].ToString();
                    txtDireccionEmpleado.Text = row[3].ToString();  
                    txtTelefonoEmpleado.Text = row[4].ToString();
                    txtEmailEmpleado.Text  = row[5].ToString();
                    FechaIngreso.Text = row[7].ToString();
                    FechaRetiro.Text = row[8].ToString();
                    datosEmpleado.Text = row[9].ToString();

                }

            }

            llenar_comboCategorias();

        }   

        private void llenar_comboCategorias()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();  // creamos un objeto  con la clase Acceso_datos
            dt = Acceso.cargarTabla("TBLROLES", "");
            comboRolEmpleado.DataSource = dt;
            comboRolEmpleado.DisplayMember = "StrDescripcion";
            comboRolEmpleado.ValueMember = "IdRolEmpleado";
            Acceso.CerrarBd();
        }



        public bool Guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Empleado] {IdEmpleado},'{txtNombreEmpleado.Text}',{txtDocumentoEmpleado.Text} ,'{txtDireccionEmpleado.Text}','{txtTelefonoEmpleado.Text}', '{txtEmailEmpleado.Text}','1','{FechaIngreso.Value:yyyy-MM-dd}','{FechaRetiro.Value:yyyy-MM-dd}','{datosEmpleado.Text}','{DateTime.Now.ToShortDateString()}','Santiago'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción" + ex);
                    actualizado = false;
                }

            }

            return actualizado;
        }

        // Funcion que permite validar los campos del formulario 

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombreEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreEmpleado, "debe ingresar el nombre del cliente");
                txtNombreEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreEmpleado, "");
            }

            if (txtDocumentoEmpleado.Text == "")
            {
                MensajeError.SetError(txtDocumentoEmpleado, "debe ingresar el documento del cliente");
                txtDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDocumentoEmpleado, "");
            }

            if (!esNumerico(txtDocumentoEmpleado.Text))
            {
                MensajeError.SetError(txtDocumentoEmpleado, "El documento debe ser numerico");
                txtDocumentoEmpleado.Focus();
                return false;
            }
            MensajeError.SetError(txtDocumentoEmpleado, "");

            return errorCampos;

        }

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





    }
}
