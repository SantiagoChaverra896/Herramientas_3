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
    public partial class frmEditarRolEmpleados : Form
    {
        public frmEditarRolEmpleados()
        {
            InitializeComponent();
        }

        public int IdRol { get; set; }
        public string NRol { get; set; }
        public string DRol { get; set; }
        
        DataTable dt = new DataTable();
        Cls_Roles roles = new Cls_Roles();



        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarRolEmpleados_Load(object sender, EventArgs e)
        {
            if (IdRol == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVO ROL";
            }
            else
            {//actualizar el registro con el id pasado
                lblTitulo.Text = "MODIFICAR ROL";
                llenar_campos();
                
               
            }
        }

        public void llenar_campos() 
        {
            dt = roles.Consulta_Roles(IdRol);
            if(dt.Rows.Count > 0) 
            {
                foreach(DataRow row in dt.Rows) 
                {
                    txtNombreRol.Text = row[1].ToString();
                   
                }
            }
        }

        public void Guardar()
        {
            string Mensaje = "";
            if (validar())
            {
                roles.C_IdRolEmpleado= IdRol;
                roles.C_NombreRol = txtNombreRol.Text;
                roles.C_StrDescripcionRol = txtDescripcionRol.Text;
                if (IdRol!= 0)
                {
                    Mensaje = roles.ActualizarRol();
                    MessageBox.Show(Mensaje);
                }
                else
                {
                    Mensaje = roles.InsertarRol();
                    MessageBox.Show(Mensaje);
                }
            }
        }


        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombreRol.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreRol, "Debe ingresar el nombre del Rol");
                txtNombreRol.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreRol, "");
            }
            return errorCampos;
        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Datos Actualizados");
            Guardar();
        }
    }
}
