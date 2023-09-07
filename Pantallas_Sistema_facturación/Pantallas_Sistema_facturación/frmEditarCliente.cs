using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación
{
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
            
        }
        DataTable dt = new DataTable();     // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO         
        Acceso_datos Acceso = new Acceso_datos();  // creamos un objeto  con la clase Acceso_datos  
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string identificacion { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            LLENAR_CLIENTE();
        }
        private void LLENAR_CLIENTE()
        {
            if (IdCliente == 0)
            {                 // ES UN REGISTRO NUEVO                 
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
                txtIdCliente.Text = "";
                txtNombre.Text = "";
                txtDocumento.Text = "";
                txtDireccion.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";
            }
            else
            {
                lblTitulo.Text = "MODIFICAR CLIENTE";
                txtIdCliente.Text = IdCliente.ToString();
                txtNombre.Text = Nombre;
                txtDocumento.Text = identificacion;
                txtDireccion.Text = direccion;
                txtTelefono.Text = telefono;
                txtEmail.Text = correo;
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
                    string sentencia = $"Exec [actualizar_Cliente] {IdCliente},'{txtNombre.Text}',{txtDocumento.Text} ,'{txtDireccion.Text}','{txtTelefono.Text}', '{txtEmail.Text}' ,'Javier','{DateTime.Now.ToShortDateString()}'";
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
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombre.Text == string.Empty)
            {
                MensajeError.SetError(txtNombre, "debeingresar  el nombre del Cliente");
                txtNombre.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombre, "");
            }
            if (txtDocumento.Text == "")
            {
                MensajeError.SetError(txtDocumento, "debe ingresar el documento");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDocumento, "");
            }
            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El Documento debe ser numerico");
                txtDocumento.Focus();
                return false;
            }
            MensajeError.SetError(txtDocumento, "");
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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
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
