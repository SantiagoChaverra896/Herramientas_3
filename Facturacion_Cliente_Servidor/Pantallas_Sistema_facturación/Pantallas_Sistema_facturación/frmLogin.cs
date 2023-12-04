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
    public partial class frmLogin : Form
    {
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
            string Respuesta = ""; //creamos variable para controlar si se encontro el usuario en la base de datos
            if (TxtUsuario.Text != "" && TxtUsuario.Text != string.Empty)
            {
                Acceso_datos Acceso = new Acceso_datos();
                Respuesta = Acceso.ValidarUsuario(TxtUsuario.Text,Txtpasword.Text);

                /*if (TxtUsuario.Text == "admin" && Txtpasword.Text == "123")
                    Respuesta = "SANTIAGO CHAVERRA LOPEZ";*/

                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido : " + Respuesta); // Mostramos mensaje de bienvenida
                    frmPrincipal frmppal = new frmPrincipal(); // creamos el objeto del formulario principal
                    this.Hide(); // ocultamos el formulario de login
                    frmppal.Show(); // mostramos el fomulario principal

                }
                else
                {
                    MessageBox.Show("USUARIO Y CLAVE NO ENCONTRADOS");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    Txtpasword.Text = "";

                }   

            }
            else 
            {
                MessageBox.Show("Debe ingresar un usuario y una clave");
            }
        }
    }
}
