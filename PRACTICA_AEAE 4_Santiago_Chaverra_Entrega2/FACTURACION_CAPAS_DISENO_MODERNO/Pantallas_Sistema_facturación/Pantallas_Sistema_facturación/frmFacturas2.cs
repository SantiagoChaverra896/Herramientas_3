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
    public partial class frmFacturas2 : Form
    {
        public frmFacturas2()
        {
            InitializeComponent();
            
        }

        DataTable dt = new DataTable();
        Cls_Facturas factura = new Cls_Facturas();


        public void llenar_grid()
        {
            dgFacturas.Rows.Clear();
            dt = factura.ConsultaFacturas();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    dgFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                }
            }
            else
            {
                MessageBox.Show("No se encontraron registros");
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgFacturas.Columns["btnBorrar"].Index && e.RowIndex >= 0) // verificamos el boton que se presionó, de acuerdo con el nombre de la columna 
            {
                int indiceFila = e.RowIndex;
                int posActual = Convert.ToInt32(dgFacturas.Rows[e.RowIndex].Cells[0].Value);
                string Ro = Convert.ToString(dgFacturas.Rows[e.RowIndex].Cells[1].Value);
                if (MessageBox.Show("Seguro borrar: " + posActual, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (indiceFila >= 0 && indiceFila < dgFacturas.Rows.Count)
                    {
                        factura.EliminarFactura(posActual);
                        dgFacturas.Rows.RemoveAt(indiceFila);
                    }
                }

            }

            if (e.ColumnIndex == dgFacturas.Columns["btnEditar"].Index && e.RowIndex >= 0) // verifica si presiono un boton editar
            {
                int posActual = dgFacturas.CurrentRow.Index; //verifico cual fila fue seleccionada
                frmFacturas factura = new frmFacturas();// instanciamos el formulario
                factura.IdFactura = int.Parse(dgFacturas[0, posActual].Value.ToString());// pasamos al formulario de edicion el Id del cliente seleccionado
                factura.ShowDialog(); // mostramos el formulario de forma modal

            }
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            frmFacturas factura = new frmFacturas();
            factura.IdFactura = 0;
            factura.ShowDialog();
            llenar_grid();
            
        }
               

        private void frmFacturas2_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgFacturas.Rows.Clear();
                dt = factura.Filtrar_Factura(txtBuscar.Text);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dgFacturas.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                    llenar_grid();
                }
            }
            else
            {
                llenar_grid();
            }
            txtBuscar.Text = "";
        }
    }
}
