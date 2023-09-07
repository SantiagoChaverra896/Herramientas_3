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
    public partial class frmEditarProductos : Form
    {
        public frmEditarProductos()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();
        public int IdProductos { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public string Precio { get; set; }
        public string Stock { get; set; }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigoReferencia_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void CodigoReferencia_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            llenar_combo_Empleados();
            LLENAR_PRODUCTO();
        }
        private void LLENAR_PRODUCTO()
        {
            if (IdProductos == 0)
            {                 // ES UN REGISTRO NUEVO                 
                lblTitulo.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {                 //ACTUALIZAR EL REGISTRO CON EL ID PASADO                 
                string sentencia = $"Select p.IdProducto, p.StrNombre, p.StrCodigo, p.NumPrecioCompra,p.NumPrecioVenta, p.NumStock, p.strFoto, p.StrDetalle, cp.StrDescripcion from TBLPRODUCTO p JOIN TBLCATEGORIA_PROD cp on p.IdCategoria = cp.IdCategoria where p.IdProducto = {IdProductos}";
                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    lblTitulo.Text = "MODIFICAR PRODUCTO";
                    IdProducto.Text = IdProductos.ToString();
                    txtproducto.Text = row[1].ToString();
                    txtcodigorefe.Text = row[2].ToString();
                    txtprecioc.Text = row[3].ToString();
                    TxtPrecioVenta.Text = row[4].ToString();
                    TxtCantidadStock.Text = row[5].ToString();
                    TxtRutaImagen.Text = row[6].ToString();
                    TxtDetalleProducto.Text = row[7].ToString();
                    cboEmpleado.Text = row[8].ToString();
                }
            }
        }
        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtNombreProducto_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void llenar_combo_Empleados()
        {
            DataTable dt = new DataTable(); 
            Acceso_datos Acceso = new Acceso_datos();  // creamos un objeto  con la clase Acceso_datos
            dt = Acceso.cargartabla("TBLCATEGORIA_PROD", "");              
            cboEmpleado.DataSource = dt;             
            cboEmpleado.DisplayMember = "StrDescripcion";             
            cboEmpleado.ValueMember = "IdCategoria";             
            Acceso.CerrarrBd();         
        }

        private void cboEmpleado_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    int idCategoriaSeleccionada = Convert.ToInt32(cboEmpleado.SelectedValue);
                    string sentencia = $"Exec [actualizar_Producto] {IdProductos},'{txtproducto.Text}','{txtcodigorefe.Text}','{txtprecioc.Text}','{TxtPrecioVenta.Text}', '{idCategoriaSeleccionada}','{TxtDetalleProducto.Text}', '{TxtRutaImagen.Text}', '{TxtCantidadStock.Text}', '{DateTime.Now.ToShortDateString()}','Javier'";
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
            if (txtproducto.Text == string.Empty)
            {
                MensajeError.SetError(txtproducto, "debeingresar  el nombre del Cliente");
                txtproducto.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtproducto, "");
            }
            if (txtcodigorefe.Text == "")
            {
                MensajeError.SetError(txtcodigorefe, "debe ingresar el documento");
                txtcodigorefe.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtcodigorefe, "");
            }
            if (!esNumerico(txtcodigorefe.Text))
            {
                MensajeError.SetError(txtcodigorefe, "El Codigo debe ser numerico");
                txtcodigorefe.Focus();
                return false;
            }
            MensajeError.SetError(txtcodigorefe, "");

            if (txtprecioc.Text == "")
            {
                MensajeError.SetError(txtprecioc, "debe ingresar el documento");
                txtprecioc.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtprecioc, "");
            }
            if (!esNumerico(txtprecioc.Text))
            {
                MensajeError.SetError(txtcodigorefe, "El Codigo debe ser numerico");
                txtprecioc.Focus();
                return false;
            }
            MensajeError.SetError(txtprecioc, "");

            if (TxtPrecioVenta.Text == "")
            {
                MensajeError.SetError(TxtPrecioVenta, "debe ingresar el documento");
                TxtPrecioVenta.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtPrecioVenta, "");
            }
            if (!esNumerico(TxtPrecioVenta.Text))
            {
                MensajeError.SetError(TxtPrecioVenta, "El Codigo debe ser numerico");
                TxtPrecioVenta.Focus();
                return false;
            }
            MensajeError.SetError(TxtPrecioVenta, "");

            if (TxtCantidadStock.Text == "")
            {
                MensajeError.SetError(TxtCantidadStock, "debe ingresar el documento");
                TxtCantidadStock.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtCantidadStock, "");
            }
            if (!esNumerico(TxtCantidadStock.Text))
            {
                MensajeError.SetError(TxtCantidadStock, "El Codigo debe ser numerico");
                TxtCantidadStock.Focus();
                return false;
            }
            MensajeError.SetError(TxtCantidadStock, "");
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
