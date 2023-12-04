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
    public partial class frmEditarProductos : Form
    {
        public frmEditarProductos()
        {
            InitializeComponent();
        }

        public int IdProductos { get; set; }

        DataTable dt = new DataTable();
        Cls_Productos producto = new Cls_Productos();

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

            llenar_combo();
            llenar_producto();

        }


        private void llenar_combo() 
        {
            comboBox1.DataSource = producto.ConsultarCategoria();
            comboBox1.DisplayMember = "StrDescripcion";
            comboBox1.ValueMember = "IdCategoria";
        }


        private void llenar_producto()
        {
            if (IdProductos == 0)
            {                 // ES UN REGISTRO NUEVO                 
                lblTitulo.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {
                //ACTUALIZAR EL REGISTRO CON EL ID PASADO                 
                dt = producto.Consulta_Producto(IdProductos);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        lblTitulo.Text = "MODIFICAR PRODUCTO";
                        txtIdProducto.Text= IdProductos.ToString();
                        TxtNombreProducto.Text = row[1].ToString();
                        comboBox1.Text = row[2].ToString();//TxtCodigoReferencia.Text = row[2].ToString();
                        TxtPrecioCompra.Text = row[3].ToString();
                        TxtPrecioVenta.Text = row[4].ToString();
                        TxtCantidadStock.Text = row[5].ToString();
                        TxtRutaImagen.Text = row[6].ToString();
                        TxtDetalleProducto.Text = row[7].ToString();
                        //comboBox1.Text = row[8].ToString();
                    }
                }
            }
        }


        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    int idCategoriaSeleccionada = Convert.ToInt32(comboBox1.SelectedValue);
                    string Mensaje = "";
                    if (validar())
                    {
                        producto.C_IdProducto = IdProductos;
                        producto.C_StrName = TxtNombreProducto.Text;
                        producto.C_StrCodigo = TxtCodigoReferencia.Text;
                        producto.C_NumPrecioCompra = float.Parse(TxtPrecioCompra.Text);
                        producto.C_NumPrecioVenta = float.Parse(TxtPrecioVenta.Text);
                        producto.C_IdCategoria = idCategoriaSeleccionada;
                        producto.C_StrDetalle = TxtDetalleProducto.Text;
                        producto.C_StrFoto = TxtRutaImagen.Text;
                        producto.C_NumStock = int.Parse(TxtCantidadStock.Text);
                        producto.C_DtmFechaModifica = DateTime.Now.ToString("yyyy-MM-dd"); 
                        producto.C_StrUsuarioModifica = "Santiago";
                        Mensaje = producto.ActualizarProducto();
                        MessageBox.Show(Mensaje);
                        this.Close();
                        actualizado = true;
                    }
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
            if (TxtNombreProducto.Text == string.Empty)
            {
                MensajeError.SetError(TxtNombreProducto, "debeingresar  el nombre del Producto");
                TxtNombreProducto.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(TxtNombreProducto, "");
            }
            if (TxtCodigoReferencia.Text == "")
            {
                MensajeError.SetError(TxtCodigoReferencia, "debe ingresar el Codigo");
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
                MensajeError.SetError(TxtPrecioCompra, "debe ingresar el Valor");
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
                MensajeError.SetError(TxtPrecioVenta, "debe ingresar el Valor");
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

        private void txtIdProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
