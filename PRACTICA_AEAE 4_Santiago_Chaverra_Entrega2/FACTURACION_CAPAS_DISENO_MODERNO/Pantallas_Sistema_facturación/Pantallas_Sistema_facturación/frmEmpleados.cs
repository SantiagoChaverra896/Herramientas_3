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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public int IdEmpleado { get; set; }

        DataTable dt = new DataTable();
        Cls_Empleados empleado = new Cls_Empleados();

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //this.Close();

            //verificamos si desea cerrar la ventana
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK) 
            {
                this.Close();
            }


        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            //MessageBox.Show("Datos Actualizados");
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            llenar_combo();
           if (IdEmpleado == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVO EMPLEADO";
            }
            else
            {//actualizar el registro con el id pasado
                lblTitulo.Text = "MODIFICAR EMPLEADO";
                /*txtNombreEmpleado.Text = "Empleado 1";
                txtDocumentoEmpleado.Text = IdEmpleado.ToString();
                txtDireccionEmpleado.Text = "Dirección empleado";
                txtTelefonoEmpleado.Text = "Telefono empleado";
                txtEmailEmpleado.Text = "Email empleado";
                comboRolEmpleado.Text = "Operador";
                datosEmpleado.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor " +
                    "incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco " +
                    "laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit" +
                    " esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, " +
                    "sunt in culpa qui officia deserunt mollit anim id est laborum";*/
                llenar_campos();

            }
        }

        private void llenar_combo() 
        {
            comboRolEmpleado.DataSource = empleado.ConsultarRol(); //invocamos el metodo de consulta del Rol
            comboRolEmpleado.DisplayMember = "StrDescripcion"; //Información del nombre del rol que se muestra al usuario
            comboRolEmpleado.ValueMember = "IdRolEmpleado"; // codigo interno que identifica el rol, este es el valor que se guarda luego en la tabla de empleados

        }


        private void llenar_campos() 
        {
            dt = empleado.Consulta_Empleado(IdEmpleado);//consultamos el empleado con el IdEmpleado especifico
            if(dt.Rows.Count > 0) //si retorna valores de consulta, asignamos los valores a los campos 
            {
                foreach(DataRow row in dt.Rows) 
                {
                    txtNombreEmpleado.Text = row[1].ToString();
                    txtDocumentoEmpleado.Text = row[2].ToString();
                    txtDireccionEmpleado.Text = row[3].ToString();
                    txtTelefonoEmpleado.Text = row[4].ToString();
                    txtEmailEmpleado.Text = row[5].ToString();
                    // seleccionamos en la lista el rol de acuerdo al valor que se tiene en la tabla tblEmpleados
                    comboRolEmpleado.SelectedValue = int.Parse(row[6].ToString());
                    dtmIngreso.Value = Convert.ToDateTime(row[7].ToString());   
                    dtmRetiro.Value = Convert.ToDateTime(row[8].ToString());
                    txtDatosAdicionales.Text = row[9].ToString();
                }
            }
        }

        public void Guardar() 
        {
            string mensaje = "";
            if(validar())// funcion que valida la informacion de los campos
            {
                empleado.C_IdEmpleado = IdEmpleado;
                empleado.C_strNombre = txtNombreEmpleado.Text;
                empleado.C_NumDocumento = double.Parse(txtDocumentoEmpleado.Text); 
                empleado.C_StrDireccion = txtDireccionEmpleado.Text; 
                empleado.C_StrTelefono = txtTelefonoEmpleado.Text;
                empleado.C_StrEmail = txtEmailEmpleado.Text;
                empleado.C_IdRolEmpleado = int.Parse(comboRolEmpleado.SelectedValue.ToString());
                empleado.C_DtmIngreso = dtmIngreso.Value.ToString("yyyy-MM-dd");///dtmIngreso.Text;
                empleado.C_DtmRetiro = dtmRetiro.Value.ToString("yyyy-MM-dd");// dtmRetiro.Text;
                empleado.C_StrDatosAdicionales = txtDatosAdicionales.Text;
                empleado.C_UsuarioModifico = "santiago";
                mensaje = empleado.ActualizarEmpleado(); //invocamos el metodo de actualizar información del empleado
                MessageBox.Show(mensaje);
            }

        }

        // funcion que permite validar los campos del formulario

        private Boolean validar() 
        {
            Boolean errorCampos = true;
            if(txtNombreEmpleado.Text == string.Empty) 
            {
                MensajeError.SetError(txtNombreEmpleado, " Debe ingresar el nombre del empleado ");
                txtNombreEmpleado.Focus();
                errorCampos = false;
            }
            else 
            { 
                MensajeError.SetError(txtNombreEmpleado,""); 
            }

            if(txtDocumentoEmpleado.Text == "") 
            {
                MensajeError.SetError(txtDocumentoEmpleado, " Debe ingresar el documento ");
                txtDocumentoEmpleado.Focus();
                errorCampos = false;    
            }
            else 
            {
                MensajeError.SetError(txtDocumentoEmpleado, "");
            }

            if (!esNumerico(txtDocumentoEmpleado.Text)) 
            {
                MensajeError.SetError(txtDocumentoEmpleado, "El documento debe ser númerico");
                txtDocumentoEmpleado.Focus();
                return false;
            }
            MensajeError.SetError(txtDocumentoEmpleado, "");
            return errorCampos;          
        
        
        }
        // validación de valores numericos

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
