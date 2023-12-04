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
        DataTable dt = new DataTable(); // creamos el objeto de tipo DataTable para almacenar lo consultado.
        Acceso_datos Acceso = new Acceso_datos();

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
                //txtIdCategoria.Text = IdCategoria.ToString();
                //txtNombreCategoria.Text = "LOREM IPSUM";

                string sentencia = $"select * from TBLCATEGORIA_PROD where IdCategoria = {IdCategoria}"; // consulto el registro del IdCliente

                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    //llenamos los campos con el registro consultado
                    txtIdCategoria.Text = IdCategoria.ToString();
                    txtNombreCategoria.Text = row[1].ToString();




                }

            }
        }


        // ACTUALIZACIONES::::::::::::Funciones que permiten el ingreso, retiro, actualizacion de la informacion de clientes en la base de datos

        public bool Guardar()
        {
            Boolean actualizado = false;

            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec [actualizar_CategoriaProducto] {IdCategoria},'{txtNombreCategoria.Text}','{DateTime.Now.ToShortDateString()}','Santiago'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción" + ex);
                    actualizado = false;
                }

            }

            return actualizado;
        }

        // Funcion que permite validar los campos del formulario 

        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (txtNombreCategoria.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreCategoria, "debe ingresar el nombre de la Categoria");
                txtNombreCategoria.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreCategoria, "");
            }

            if (txtIdCategoria.Text == "")
            {
                MensajeError.SetError(txtIdCategoria, "debe ingresar el id de la Categoría");
                txtIdCategoria.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtIdCategoria, "");
            }

            if (!esNumerico(txtIdCategoria.Text))
            {
                MensajeError.SetError(txtIdCategoria, "El Id debe ser numerico");
                txtIdCategoria.Focus();
                return false;
            }
            MensajeError.SetError(txtIdCategoria, "");

            return errorCampos;

        }

        // funcion para validar si un valor dado es numerico

        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }





        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
            //MessageBox.Show("Datos Actualizados");
        }
    }
}
