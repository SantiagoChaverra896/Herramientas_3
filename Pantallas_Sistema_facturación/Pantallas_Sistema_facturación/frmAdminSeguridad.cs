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
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta; 
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); 
            if (Rta == DialogResult.OK) 
            { 
                this.Close(); 
            }
        }

        private void frmAdminSeguridad_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void llenar_combo_Empleados()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();  // creamos un objeto  con la clase Acceso_datos   
            dt = Acceso.cargartabla("TBLEMPLEADO", "");
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "strNombre";
            comboBox1.ValueMember = "IdEmpleado";
            Acceso.CerrarrBd();
        }
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtUsusario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsusario, "debe ingresar  un valor de Usuario");
                txtUsusario.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtUsusario, "");
            }
            if (Txtpasword.Text == "")
            {
                MensajeError.SetError(Txtpasword, "Debe ingresar  un valor de cédula");
                Txtpasword.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(Txtpasword, "");
            }
            return errorCampos;
        }
        private bool IsNumeric(string num)
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
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Seguridad '{Convert.ToInt32(comboBox1.SelectedValue)}' ,'{txtUsusario.Text}','{Txtpasword.Text}','{DateTime.Now}','Javier'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }
        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"Exec Eliminar_Seguridad '{Convert.ToInt32(comboBox1.SelectedValue)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            txtUsusario.Text = "";
            Txtpasword.Text = "";
        }
        public void Consultar()
        {
            DataTable dt = new DataTable();
            string sentencia = "select StrUsuario,StrClave from TBLSEGURIDAD where IdEmpleado=" + comboBox1.SelectedValue.ToString();
            Acceso_datos Acceso = new Acceso_datos();  // creamos un objeto  con la clase Acceso_datos  
            dt = Acceso.EjecutarComandoDatos(sentencia);
            if (dt.Rows.Count > 0)
            {
                txtUsusario.Text = dt.Rows[0]["StrUsuario"].ToString();
                Txtpasword.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no dispone de datos de ingreso");
                txtUsusario.Text = "";
                Txtpasword.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            llenar_combo_Empleados();
        }
    }
}
