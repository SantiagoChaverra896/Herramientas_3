using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // utilizado para mostrar mensajes, a futuro no la utilizamos ya que los mensajes no son propios de esta clase.
using System.Drawing;

namespace Pantallas_Sistema_facturación
{
    internal class Acceso_datos
    {
        SqlConnection conexion; // se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd; // se defie la variable para realizar comandos en la BD
        SqlDataReader LectorDatos = null;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;


        public void AbrirBd() // metodo para abrir la base de datos
        {
            try // permite capturar un error en caso de que se presente
            {
                //creamos un objeto de tipo conexion a la base de datos y se pasa como parametro a la cadena de conexion
                conexion = new SqlConnection("Data Source=DESKTOP-ARMDG69;Initial Catalog=[DBFACTURAS];Integrated Security=True");
                conexion.Open(); // Metodo invocado para abrir la base de datos
            }
            catch(Exception ex) // En caso de error se presentara este mensaje
            {
                MessageBox.Show("Fallo de conexión " + ex);
            }
        }


        public void CerrarBd() // método para cerrar la base de datos
        {
            try // permite captura de un error en caso que se presente
            {
                conexion.Close();// invocamos método para cerrar la base de datos
            }
            catch(Exception ex) // en caso de error se presenta el siguiente mensaje
            {
                MessageBox.Show("Fallo al cerrar la conexión " + ex);
            }
        }


        // :::::::::::::::::Metodo para validar el ingreso del usuario al sistema 
        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try 
            {

                string strEmpleado = "";
                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'";
                AbrirBd();
                cmd = new SqlCommand();
                // utilizamos las propiedades de SqlCommand esta es una forma extendidas con mas parámetros de control
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text; // otros tipos son :CommandType.StoredProcedure CommandType.TableDirect
                cmd.CommandTimeout = 10;
                LectorDatos = cmd.ExecuteReader();// ejecuta y retorna un conjunto de datos, no actualizable
                while (LectorDatos.Read()) // recorremos los datos consultados
                {
                    strEmpleado = Convert.ToString(LectorDatos.GetValue(0));
                }
                if (LectorDatos != null) // cerramos el lector de datos
                {
                    LectorDatos.Close();
                }
                return strEmpleado;

            }
            catch (Exception ex) 
            {
                MessageBox.Show("FALLA LECTURA: " + ex.Message);
                return "";

            }



        }

        // :::::::::::::::::::::::::::::Metodo Ejecutar Comando
        // recibe una sentencia para realizar acciones de actualizar, retirar y nuevo, solo retorna un valor numerico que indica cuantas filas fueron afectadas.

        public string EjecutarComando(string sentencia) 
        {
            string salida = "LOS DATOS SE ACTUALIZARON SATISFACTORIAMENTE";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia,conexion);
                retornado = cmd.ExecuteNonQuery();  // utilizado para update, insert y delete
                CerrarBd();
                if (retornado > 0) 
                {
                    salida = "Los datos fueron actualizados";
                }
                else 
                {
                    salida = "Los datos no fueron actualizados";
                }
            }
            catch(Exception ex)
            {
                salida = "Falló inserción: " + ex;
            }
            return salida;
        }


        //:::::::::::::::Metodo cargar tabla
        // metodo que permite consultar una tabla y recuperar un conjunto de datos, permite filtrar la información requerida

        public DataTable cargarTabla(string tabla, string strCondicion) 
        {
            try
            {
                AbrirBd();
                String Sql = "select * from " + tabla + " " + strCondicion;
                da = new SqlDataAdapter(Sql, conexion);
                da = new SqlDataAdapter(Sql,conexion);
                ds = new DataSet();
                da.Fill(ds, tabla);
                DataTable dt = new DataTable();
                dt = ds.Tables[tabla];
                CerrarBd();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " +ex.ToString());
                return null;
            }

        }

        // metodo que permite consultar con una sentencia select o invocar un procedimiento almacenado
        public DataTable EjecutarComandoDatos(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("FALLÓ OPERACIÓN: " + ex);
                return null;
            }
        }


    }





}
