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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
            
        }

        public int IdCliente { get; set; }
        DataTable dt = new DataTable();
        Cls_Clientes cliente = new Cls_Clientes();

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else {//actualizar el registro con el id pasado
                lblTitulo.Text = "MODIFICAR CLIENTE";
                /*txtIdCliente.Text = IdCliente.ToString();
                txtNombre.Text = "Nombre 1 Apellido";
                txtDocumento.Text = "34353446o";
                txtDireccion.Text = "calle donde vive cliente";
                txtTelefono.Text = "35435464";*/
                llenar_campos();
                
            }

            
        }

        //consultamos por le id el cliente que vamos a modificar y mostramos la información consultada


        private void llenar_campos() 
        {
            dt = cliente.Consulta_Cliente(IdCliente); //consultamos el cliente con un IdCliente especifico
            if(dt.Rows.Count > 0) // si retorna valores de consulta, asignamos los valores a los campos
            {
                foreach(DataRow row in dt.Rows)
                {
                    txtIdCliente.Text = IdCliente.ToString();
                    txtNombre.Text = row[1].ToString();
                    txtDocumento.Text = row[2].ToString();
                    txtDireccion.Text = row[3].ToString();
                    txtTelefono.Text = row[4].ToString();
                    txtEmail.Text = row[5].ToString();


                }
            }
        
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public void Guardar() 
        {
            string mensaje = "";
            if (validar()) // funcion que valida la información de los campos
            { 
                cliente.Cls_IdCliente = IdCliente;
                cliente.Cls_StrNombre = txtNombre.Text;
                cliente.Cls_NumDocumento = int.Parse(txtDocumento.Text);
                cliente.Cls_StrDireccion = txtDireccion.Text;
                cliente.Cls_StrTelefono = txtTelefono.Text;
                cliente.Cls_StrEmail = txtEmail.Text;
                cliente.Cls_StrUsuarioModifica = "santiago";
                cliente.Cls_DtmFechaModifica =  DateTime.Now.ToString("yyyy-MM-dd");
                mensaje = cliente.ActualizarCliente(); //invocamos el metodo para actualizar la información del cliente
                MessageBox.Show(mensaje);
            
            }
        
        }


        public Boolean validar() 
        {
            Boolean errorCampos = true;
            if(txtNombre.Text == string.Empty) 
            {
                MensajeError.SetError(txtNombre, "debe ingresar el nombre del cliente");
                txtNombre.Focus();
                errorCampos = true;
            }
            else 
            {
                MensajeError.SetError(txtNombre, "");
            }

            if (txtDocumento.Text == string.Empty)
            {
                MensajeError.SetError(txtDocumento, "debe ingresar el nombre del cliente");
                txtDocumento.Focus();
                errorCampos = true;
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

        public bool esNumerico(string num) 
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





        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            
            if(Rta == DialogResult.OK) 
            {
                this.Close();
            }
            
        }

        private void txtIdCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
