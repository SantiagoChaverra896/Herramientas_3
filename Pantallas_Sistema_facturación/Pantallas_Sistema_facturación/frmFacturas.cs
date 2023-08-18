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
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        public int IdFactura { get; set; }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            if (IdFactura == 0)
            {//registro nuevo
                lblTitulo.Text = "INGRESO NUEVA FACTURA";
            }
            else
            {//actualizar el registro con el id pasado
                lblTitulo.Text = "MODIFICAR FACTURA";
                NroFactura.Text = IdFactura.ToString();
                comboCliente.Text = "Cliente 1";
                comboEmpleado.Text = "Empleado 1";
                comboEstadoFactura.Text = "Pendiente";

                

            }
        }
    }
}
