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
                lblTitulo.Text = "MODIFICAR PRODUCTO";
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
                    "laborum";

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
            MessageBox.Show("Datos Actualizados");
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
    }
}
