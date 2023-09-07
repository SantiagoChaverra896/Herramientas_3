using MaterialSkin;
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
    public partial class frmEditarCategoria : Form
    {
        public frmEditarCategoria()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();
        public int IdCategoria { get; set; }
       public string Ncategoria { get; set; }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            LLENAR_PRODUCTO();
            txtIdCategoria.Text = IdCategoria.ToString();
            txtNombreCategoria.Text = Ncategoria;
        }
        private void LLENAR_PRODUCTO()
        {
            if (IdCategoria == 0)
            {                 // ES UN REGISTRO NUEVO                 
                lblTitulo.Text = "INGRESO NUEVA CATEGORIA";
            }
            else
            {                 //ACTUALIZAR EL REGISTRO CON EL ID PASADO                 
                string sentencia = $"SELECT * FROM TBLCATEGORIA_PROD where IdCategoria = {IdCategoria}";
                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    lblTitulo.Text = "MODIFICAR CATEGORIA";
                    txtIdCategoria.Text = IdCategoria.ToString();
                    txtNombreCategoria.Text = row[1].ToString();
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_CategoriaProducto] {IdCategoria},'{txtNombreCategoria.Text}', '{DateTime.Now.ToShortDateString()}','Javier'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    this.Close();
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
            if (txtNombreCategoria.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreCategoria, "debeingresar  el nombre del Cliente");
                txtNombreCategoria.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreCategoria, "");
            }
            if (txtIdCategoria.Text == "")
            {
                MensajeError.SetError(txtIdCategoria, "debe ingresar el documento");
                txtIdCategoria.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtIdCategoria, "");
            }
            if (!esNumerico(txtIdCategoria.Text))
            {
                MensajeError.SetError(txtIdCategoria, "El Codigo debe ser numerico");
                txtIdCategoria.Focus();
                return false;
            }
            MensajeError.SetError(txtIdCategoria, "");

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
    }
}
