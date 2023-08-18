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
    public partial class frmEditarCategoria : Form
    {
        public frmEditarCategoria()
        {
            InitializeComponent();
        }
       public int IdCategoria { get; set; }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmEditarCategoria_Load(object sender, EventArgs e)
        {
            if (IdCategoria == 0)
            {//registro nuevo
                Titulo.Text = "INGRESO NUEVA CATEGORIA";
            }
            else
            {//actualizar el registro con el id pasado
                Titulo.Text = "MODIFICAR CATEGORIA";
                txtIdCategoria.Text = IdCategoria.ToString();
                txtNombreCategoria.Text = "LOREM IPSUM";

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }
    }
}
