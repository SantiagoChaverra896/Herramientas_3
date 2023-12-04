using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantallas_Sistema_facturación
{
    public partial class FrmPrincipal_ : MaterialForm
    {
        public FrmPrincipal_()
        {
            InitializeComponent();
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabOpcionesMenu_Click(object sender, EventArgs e)
        {

        }

        private void Acerca_Click(object sender, EventArgs e)
        {

        }

        public void AbrirForm(Form formHijo) 
        { 
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill; 
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmListaClientes ListaClientes = new frmListaClientes();
            AbrirForm(ListaClientes);
        }
    }
}
