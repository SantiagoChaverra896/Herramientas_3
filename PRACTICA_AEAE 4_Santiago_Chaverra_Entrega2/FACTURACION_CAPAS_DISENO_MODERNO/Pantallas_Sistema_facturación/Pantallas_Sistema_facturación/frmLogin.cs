using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_LogicaDeNegocios;

namespace Pantallas_Sistema_facturación
{

    // Funcionalidad: por medio de este formulario realizamos el acceso a la base de datos
    // con el fin de verificar si el usuario y la clave están registrados en la tabla TBLSEGURIDAD
    // por: Santiago Chaverra 21/09/2023

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
           /* string Respuesta = ""; //creamos variable para controlar si se encontro el usuario en la base de datos
            if (TxtUsuario.Text != "" && TxtUsuario.Text != string.Empty)
            {
                if (TxtUsuario.Text == "admin" && TxtPassword.Text == "123")
                    Respuesta = "SANTIAGO CHAVERRA LOPEZ";

                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido : " + Respuesta); // Mostramos mensaje de bienvenida
                    frmPrincipal frmppal = new frmPrincipal(); // creamos el objeto del formulario principal
                    this.Hide(); // ocultamos el formulario de login
                    frmppal.Show(); // mostramos el fomulario principal

                }
                else
                {
                    MessageBox.Show("Usuario y clave no encontrados");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    TxtPassword.Text = "";

                }

            }
            else 
            {
                MessageBox.Show("Debe ingresar un usuario y una clave");
            }*/

            if(TxtUsuario.Text != "" && TxtPassword.Text != string.Empty) // validamos que el usuario y la contraseña no estén vacios
            {
                //creamos el objeto a partir de la clase validar_usuario
                Validar_usuario Obj_validar = new Validar_usuario();
                // asignamos valores a los atributos
                Obj_validar.C_StrUsuario = TxtUsuario.Text;
                Obj_validar.C_StrClave = TxtPassword.Text;

                Obj_validar.ValidarUsuario(); // Ejecutamos el metodo de validación

                if (Obj_validar.C_IdEmpleado != 0)
                {
                    MessageBox.Show("Datos de verificación validos");//mostramos mensaje
                    frmPrincipal frmppal = new frmPrincipal(); // creamos el objeto del formulario principal
                    this.Hide(); // ocultamos el formulario de login
                    frmppal.Show(); // presentamos el formulario principal
                }
                else 
                {
                    MessageBox.Show("Usuarios y clave no encontrados");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                    TxtPassword.Text = "";

                }
            }
            else 
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }




        }
    }
}
