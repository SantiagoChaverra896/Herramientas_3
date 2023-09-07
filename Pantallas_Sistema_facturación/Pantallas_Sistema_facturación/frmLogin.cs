using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pantallas_Sistema_facturación
{
    public partial class frmLogin : Form
    {
        public string serverName = "";
        public string databaseName = "";
        public string userNameG = "";
        public string connectionString = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
            {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string Respuesta = "";
                string username = TxtUsuario.Text;
                string password = TxtPassword.Text;

                Acceso_datos acceso_Datos = new Acceso_datos();
                Respuesta = acceso_Datos.ValidarUsuario(username, password);

                if (Respuesta != "")
                {
                    frmPrincipal frmppal = new frmPrincipal();
                    this.Hide();
                    frmppal.Show();
                }
                else
                {
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    TxtPassword.Text = "";
                    MessageBox.Show("Usuario clave no encontrados.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
