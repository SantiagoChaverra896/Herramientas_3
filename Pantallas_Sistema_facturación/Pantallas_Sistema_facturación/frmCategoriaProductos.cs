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
    public partial class frmCategoriaProductos : Form
    {
        public frmCategoriaProductos()
        {
            InitializeComponent();
        }
        SqlConnection conexion;
        SqlCommand cmd;
        DataTable table = new DataTable();
        Acceso_datos acceso_Datos = new Acceso_datos();
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void llenar_grid()
        {
            dgCategorias.Rows.Clear();
            string strconsulta = "SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD";
            table = acceso_Datos.EjecutarComandoDatos(strconsulta);

            foreach (DataRow row in table.Rows)
            {
                dgCategorias.Rows.Add(row[0], row[1]);
            }
        }

        private void dgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgCategorias.Columns["btnBorrar"].Index && e.RowIndex >= 0)
                {
                    int indiceFila = e.RowIndex;
                    int posActual = Convert.ToInt32(dgCategorias.Rows[e.RowIndex].Cells[0].Value);
                    string Categ = Convert.ToString(dgCategorias.Rows[e.RowIndex].Cells[1].Value);
                if (MessageBox.Show("Seguro borrar: " + Categ, "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sentencia = $"Exec Eliminar_CategoriaProducto {posActual}";
                        string mensaje = acceso_Datos.EjecutarComando(sentencia);
                    if (indiceFila >= 0 && indiceFila < dgCategorias.Rows.Count)
                        {
                            dgCategorias.Rows.RemoveAt(indiceFila);
                        }
                    }
                }
            if (e.ColumnIndex == dgCategorias.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                int posActual = Convert.ToInt32(dgCategorias.Rows[e.RowIndex].Cells[0].Value); 
                string Categ = Convert.ToString(dgCategorias.Rows[e.RowIndex].Cells[1].Value);
                frmEditarCategoria categoria = new frmEditarCategoria();
                categoria.IdCategoria = posActual;
                categoria.Ncategoria = Categ;
                categoria.ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCategoria categoria = new frmEditarCategoria();
            categoria.IdCategoria = 0;
            categoria.ShowDialog();
        }

        private void frmCategoriaProductos_Load(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmEditarCategoria frmEditarCategoria = new frmEditarCategoria();
            frmEditarCategoria.ShowDialog();
        }
    }
}
