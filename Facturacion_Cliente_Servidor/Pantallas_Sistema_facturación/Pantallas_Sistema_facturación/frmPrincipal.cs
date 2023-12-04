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
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmTestingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
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

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategoriaProductos CategoriaProductos = new frmCategoriaProductos();
            AbrirForm(CategoriaProductos);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            AbrirForm(productos);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformes informes = new frmInformes();
            AbrirForm(informes);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmFacturas2 facturas = new frmFacturas2();
            AbrirForm(facturas);
        }

        private void btnEmpleados_Click_1(object sender, EventArgs e)
        {
            frmEmpleados2 empleados = new frmEmpleados2();
            AbrirForm(empleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRolesEmpleados roles = new frmRolesEmpleados();
            AbrirForm (roles);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad adminSeguridad = new frmAdminSeguridad();
            AbrirForm(adminSeguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            AbrirForm(ayuda);
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new frmAcercaDe();
            AbrirForm(acercaDe);
        }
    }
}
