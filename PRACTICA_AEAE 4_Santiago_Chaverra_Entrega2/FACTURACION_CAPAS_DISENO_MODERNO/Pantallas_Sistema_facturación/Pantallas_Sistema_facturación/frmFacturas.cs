using Capa_LogicaDeNegocios;
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


        DataTable dt = new DataTable();
        Cls_Facturas factura = new Cls_Facturas();

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
                llenar_combo();
                //llenar_campos();
            }
            else
            {//actualizar el registro con el id pasado
                lblTitulo.Text = "MODIFICAR FACTURA";
                //NroFactura.Text = IdFactura.ToString();
                //comboCliente.Text = "Cliente 1";
                //comboEmpleado.Text = "Empleado 1";
                //comboEstadoFactura.Text = "Pendiente";
                llenar_campos();
                llenar_combo();


            }
        }

        private void llenar_campos()
        {
            dt = factura.Consulta_Factura(IdFactura);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    NroFactura.Text = row[0].ToString();
                    comboCliente.SelectedValue = int.Parse(row[1].ToString());
                    comboEmpleado.SelectedValue = int.Parse(row[2].ToString());
                    dateTimePicker1.Value = Convert.ToDateTime(row[3].ToString());
                    comboEstadoFactura.SelectedValue = int.Parse(row[4].ToString());
                    txtDescuento.Text = row[5].ToString();
                    txtIva.Text = row[6].ToString();
                    txtTotal.Text = row[7].ToString();
                    txtDetalleFac.Text = row[8].ToString();
                }
            }
        }

        private void llenar_combo()
        {
            comboCliente.DataSource = factura.ConsultarCliente();
            comboCliente.DisplayMember = "StrNombre";
            comboCliente.ValueMember = "IdCliente";
            comboEmpleado.DataSource = factura.ConsultarEmpleado();
            comboEmpleado.DisplayMember = "strNombre";
            comboEmpleado.ValueMember = "IdEmpleado";
            comboEstadoFactura.DataSource = factura.ConsultarEstado();
            comboEstadoFactura.DisplayMember = "StrDescripcion";
            comboEstadoFactura.ValueMember = "IdEstadoFactura";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            factura.DtmFecha = dateTimePicker1.Value;
            factura.IdCliente = int.Parse(comboCliente.SelectedValue.ToString());
            factura.IdEmpleado = int.Parse(comboEmpleado.SelectedValue.ToString());
            factura.NumDescuento = float.Parse(txtDescuento.Text);
            factura.NumImpuesto = float.Parse(txtIva.Text);
            factura.NumValorTotal = float.Parse(txtTotal.Text);
            factura.IdEstado = int.Parse(comboEstadoFactura.SelectedValue.ToString());
            factura.DtmFechaModifica = DateTime.Now;
            factura.StrUsuarioModifica = "Santiago";
            factura.StrDetalle = txtDetalleFac.Text;
            string salida = "";
            if (IdFactura > 0)
            {
                factura.IdFactura = IdFactura;
                salida = factura.ActualizarFactura();
            }
            else
            {
                factura.IdFactura = int.Parse(NroFactura.Text);
                salida = factura.InsertarFactura();
            }
            MessageBox.Show(salida);
            this.Close();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (NroFactura.Text != "")
            {
                if (MessageBox.Show("Seguro borrar la factura: " + NroFactura.Text, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    factura.EliminarFactura(int.Parse(NroFactura.Text));
                    this.Hide();
                }
            }
        }
    }
}
