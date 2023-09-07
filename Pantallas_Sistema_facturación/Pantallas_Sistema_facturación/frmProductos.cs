using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        SqlConnection conexion;
        SqlCommand cmd;
        DataTable table = new DataTable();
        Acceso_datos acceso_Datos = new Acceso_datos();
        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgProductos.Columns["btnBorrar"].Index && e.RowIndex >= 0)
            {
                int indiceFila = e.RowIndex;
                int posActual = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells[0].Value);
                string Prod = Convert.ToString(dgProductos.Rows[e.RowIndex].Cells[1].Value);
                if (MessageBox.Show("Seguro borrar: " + Prod, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sentencia = $"Exec Eliminar_Producto '{posActual}'";
                    string mensaje = acceso_Datos.EjecutarComando(sentencia);
                    if (indiceFila >= 0 && indiceFila < dgProductos.Rows.Count)
                    {
                        dgProductos.Rows.RemoveAt(indiceFila);
                        MessageBox.Show(mensaje);
                    }
                }
            }
            if (e.ColumnIndex == dgProductos.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                int posActual = dgProductos.CurrentRow.Index; 
                frmEditarProductos producto = new frmEditarProductos();
                producto.IdProductos  = Convert.ToInt32(dgProductos.Rows[e.RowIndex].Cells[0].Value);
                producto.Producto = Convert.ToString(dgProductos.Rows[e.RowIndex].Cells[1].Value);
                producto.Categoria = Convert.ToString(dgProductos.Rows[e.RowIndex].Cells[2].Value);
                producto.Precio = Convert.ToString(dgProductos.Rows[e.RowIndex].Cells[3].Value);
                producto.Stock = Convert.ToString(dgProductos.Rows[e.RowIndex].Cells[4].Value);
                producto.ShowDialog(); 

            }
        }
        public void llenar_gridProductos()
        {
            dgProductos.Rows.Clear();
            string strconsulta = "Select p.IdProducto, p.StrNombre, cp.StrDescripcion, p.NumPrecioVenta, p.NumStock from TBLPRODUCTO p JOIN TBLCATEGORIA_PROD cp on p.IdCategoria = cp.IdCategoria";
            table = acceso_Datos.EjecutarComandoDatos(strconsulta);

            foreach (DataRow row in table.Rows)
            {
                dgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarProductos productos = new frmEditarProductos();
            productos.IdProductos = 0;
            productos.ShowDialog();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            llenar_gridProductos();
        }
    }
}
