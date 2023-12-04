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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        Cls_Seguridad SeguridadEmpleado = new Cls_Seguridad();

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }

        private void llenar_combo_Empleados()
        {
            comboBox1.DataSource = SeguridadEmpleado.ConsultarEmpleados(); // indicamos metodos de consulta de los empleados
            comboBox1.DisplayMember = "StrNombre"; //informacion del nombre del empleado
            comboBox1.ValueMember = "IdEmpleado"; // codigo interno que identifica id empleado
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        public void Consultar() 
        {
            int IdEmpleado = int.Parse(comboBox1.SelectedValue.ToString());
            dt = SeguridadEmpleado.Consulta_SeguridadEmpleado(IdEmpleado); //consultamos el empleado con el IdEmpleado especifico

            if(dt.Rows.Count > 0) // si retorna valores de consulta, asignamos los valores a los campos
            {
                foreach(DataRow row in dt.Rows) 
                {
                    txtUsuario.Text = row[0].ToString();
                    txtClave.Text = row[1].ToString();
                }
            }
            else 
            {
                txtClave.Text = "";
                txtUsuario.Text = "";
                MessageBox.Show("No se le ha asignado usuario y clave a este Empleado");
            }


        }

        // los datos de usuario y clave asociados al empleado los actualizamos en la base de datos por medio del boton actualizar, a través del cual se invoca la funcion guardar

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        // funcion que permite guardar los datos de ingreso de un usuario

        public void Guardar() 
        {
            string mensaje = "";
            if (validar())  // funcion que valida la información de los campos
            {
                SeguridadEmpleado.C_IdEmpleado = int.Parse(comboBox1.SelectedValue.ToString());
                SeguridadEmpleado.C_StrUsuario = txtUsuario.Text;
                SeguridadEmpleado.C_StrClave = txtClave.Text;
                SeguridadEmpleado.C_StrUsuarioModifico = "santiago";
                mensaje = SeguridadEmpleado.ActualizarSeguridadEmpleado();// invocamos el metodo actualizar
                MessageBox.Show(mensaje);

            }
            txtClave.Text = "";
            txtUsuario.Text = "";

        }

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuario, " Debe ingresar el usuario del empleado ");
                txtUsuario.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtUsuario, "");
            }

            if (txtClave.Text == "")
            {
                MensajeError.SetError(txtClave, " Debe ingresar la clave");
                txtClave.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtClave, "");
            }
                        
            return errorCampos;


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        //funcion que permite eliminar los datos de ingreso de un usuario

        public void Eliminar() 
        {
            //preguntamos si esta seguron de borrar el registro
            if(MessageBox.Show($"Esta seguro de borrar el registro de: \n {comboBox1.Text}","CONFIRMACION",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            { 
                //pasamos el parametro del IdEmpleado que vamos  a notificar
                SeguridadEmpleado.C_IdEmpleado = int.Parse(comboBox1.SelectedValue.ToString());

                string mensaje = SeguridadEmpleado.EliminarSeguridadEmpleado(); // ejecutamos el borrado
                if(mensaje != "") 
                {
                    MessageBox.Show(mensaje);
                }
                else 
                {
                    MessageBox.Show($"BORRANDO EL REGISTRO");
                    txtClave.Text = "";
                    txtUsuario.Text = "";

                }
            }

        }


    }


}
