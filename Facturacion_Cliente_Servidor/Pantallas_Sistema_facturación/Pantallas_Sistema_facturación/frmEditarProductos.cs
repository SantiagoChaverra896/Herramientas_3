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

        public int IdProductos { get; set; }
        DataTable dt = new DataTable(); // creamos el objeto de tipo DataTable para almacenar lo consultado.
        Acceso_datos Acceso = new Acceso_datos();

        private void llenar_producto() 
        {
            
        }

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
            //editar productos
            if (IdProductos == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {//actualizar el registro con el id pasado
                /*lblTitulo.Text = "MODIFICAR PRODUCTO";
                IdProducto.Text = IdProductos.ToString();
                TxtNombreProducto.Text = "Nombre 1 Apellido";
                TxtCodigoReferencia.Text = "34353446o";
                TxtPrecioCompra.Text = "$ 500.000";
                TxtPrecioVenta.Text = "$ 35.435.464";
                TxtCantidadStock.Text = "500";
                TxtDetalleProducto.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor" +
                    " incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi " +
                    "ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat " +
                    "nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est " +
                    "laborum";*/
                string sentencia = $"select IdProducto, StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta, NumStock, strFoto, StrDetalle, IdCategoria from TBLPRODUCTO where IdProducto = {IdProductos}"; // consulto el registro del IdProductos
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    //llenamos los campos con el registro consultado
                    IdProducto.Text = IdProductos.ToString();
                    TxtNombreProducto.Text = row[1].ToString();
                    TxtCodigoReferencia.Text = row[2].ToString();
                    TxtPrecioCompra.Text = row[3].ToString();
                    TxtPrecioVenta.Text = row[4].ToString();
                    TxtCantidadStock.Text = row[5].ToString();
                    TxtRutaImagen.Text = row[6].ToString();
                    TxtDetalleProducto.Text = row[7].ToString();
                    cboCategoria.Text = row[8].ToString();
                }

            }

            

            llenar_comboCategorias();
        }


        //::::::::::::Actualizaciones

        public bool Guardar()
        {
            Boolean actualizado = false;
            //int IdCategoria;

            if (validar())
            {
                try
                {
                    /// Asignación del idCategoria segun el valor seleccionado en el combo
                    /*

                    if (cboCategoria.Text.Equals("Tecnología"))
                    {
                        IdCategoria = 1;
                    } 
                    else if (cboCategoria.Text.Equals("Alimentos")) 
                    {
                        IdCategoria = 2;
                    }
                    else if (cboCategoria.Text.Equals("Carnes"))
                    {
                        IdCategoria = 3;
                    };*/
                    
                    
                    

                    ///
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_Producto] {IdProductos},'{TxtNombreProducto.Text}',{TxtCodigoReferencia.Text},{TxtPrecioCompra.Text},{TxtPrecioVenta.Text},'1','{TxtDetalleProducto.Text}','{TxtRutaImagen.Text}',{TxtCantidadStock.Text},'{DateTime.Now.ToShortDateString()}','Santiago'";
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

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (TxtNombreProducto.Text == string.Empty)
            {
                MensajeError.SetError(TxtNombreProducto, "debe ingresar  el nombre de Producto");
                TxtNombreProducto.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtNombreProducto, "");
            }
            if (TxtCodigoReferencia.Text == "")
            {
                MensajeError.SetError(TxtCodigoReferencia, "debe ingresar el Código Referencia");
                TxtCodigoReferencia.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtCodigoReferencia, "");
            }
            if (!esNumerico(TxtCodigoReferencia.Text))
            {
                MensajeError.SetError(TxtCodigoReferencia, "El Codigo debe ser numerico");
                TxtCodigoReferencia.Focus();
                return false;
            }
            MensajeError.SetError(TxtCodigoReferencia, "");

            if (TxtPrecioCompra.Text == "")
            {
                MensajeError.SetError(TxtPrecioCompra, "debe ingresar el precio de compra");
                TxtPrecioCompra.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtPrecioCompra, "");
            }
            if (!esNumerico(TxtPrecioCompra.Text))
            {
                MensajeError.SetError(TxtPrecioCompra, "El valor debe ser numerico");
                TxtPrecioCompra.Focus();
                return false;
            }
            MensajeError.SetError(TxtPrecioCompra, "");

            if (TxtPrecioVenta.Text == "")
            {
                MensajeError.SetError(TxtPrecioVenta, "debe ingresar el precio de venta");
                TxtPrecioVenta.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtPrecioVenta, "");
            }
            if (!esNumerico(TxtPrecioVenta.Text))
            {
                MensajeError.SetError(TxtPrecioVenta, "El valor debe ser numerico");
                TxtPrecioVenta.Focus();
                return false;
            }
            MensajeError.SetError(TxtPrecioVenta, "");

            if (TxtCantidadStock.Text == "")
            {
                MensajeError.SetError(TxtCantidadStock, "debe ingresar la cantidad");
                TxtCantidadStock.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtCantidadStock, "");
            }
            if (!esNumerico(TxtCantidadStock.Text))
            {
                MensajeError.SetError(TxtCantidadStock, "El valor debe ser numerico");
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

        private void llenar_comboCategorias()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos();  // creamos un objeto  con la clase Acceso_datos
            dt = Acceso.cargarTabla("TBLCATEGORIA_PROD", "");
            cboCategoria.DataSource = dt;
            cboCategoria.DisplayMember = "StrDescripcion";
            cboCategoria.ValueMember = "IdCategoria";
            Acceso.CerrarBd();
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
            //MessageBox.Show("Datos Actualizados");
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

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
