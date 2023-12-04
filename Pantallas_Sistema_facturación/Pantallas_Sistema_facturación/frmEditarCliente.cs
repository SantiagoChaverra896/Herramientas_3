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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
            
        }

        public int IdCliente { get; set; }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else {//actualizar el registro con el id pasado
                lblTitulo.Text = "MODIFICAR CLIENTE";
                txtIdCliente.Text = IdCliente.ToString();
                txtNombre.Text = "Nombre 1 Apellido";
                txtDocumento.Text = "34353446o";
                txtDireccion.Text = "calle donde vive cliente";
                txtTelefono.Text = "35435464";
                
            }

            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
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
