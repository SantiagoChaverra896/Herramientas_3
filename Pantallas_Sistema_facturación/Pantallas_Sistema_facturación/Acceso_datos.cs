using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantallas_Sistema_facturación
{
    class Acceso_datos
    {
        SqlConnection conexion;   // se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd;  // se defie la variable para realizar comandos en la BD
        SqlDataReader LectorDatos = null;  // data reader , consulta de solo lectura de informacion
        SqlDataAdapter da;         
        DataTable dt;        
        DataSet ds;

        public string serverName = "ANDRESBORJA\\SQLEXPRESS";
        public string databaseName = "[DBFACTURAS]";
        public string userNameG = "";
        public string connectionString = "";

        public void AbrirBd()  // método para abrir la base de datos
        {
            try    // permite captura de un error en caso que se presente
            {
                conexion = new SqlConnection("Data Source=" + serverName + ";Initial Catalog=" + databaseName + ";Integrated Security=true");
                conexion.Open();  // invocamos método para abrir la base de datos
                          
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            {                 
                MessageBox.Show("falló conexión " + ex);             
            }         
        }          
        public void CerrarrBd()  // método para cerrar  conexion a la base de datos
        {             
            try    // permite captura de un error en caso que se presente
            {
            conexion.Close();  // invocamos método para abrir la base de datos
            }
            catch (Exception ex)// si hay error presenta el siguiente mensaje
            { 
                MessageBox.Show("falló cerrar conexión " + ex);             
            }        
        }
        public string ValidarUsuario(string StrUsuario, string StrClave)
        {
            try
            {
                string strEmpleado = ""; 
                string sentencia = $"select e.strNombre, e.IdRolEmpleado from TBLSEGURIDAD s JOIN TBLEMPLEADO  e ON   s.IdEmpleado = e.IdEmpleado where StrUsuario = '{StrUsuario}' and StrClave = '{StrClave}'"; 
                AbrirBd(); 
                cmd = new SqlCommand();                 // utilizamos las propiedades de SqlCommand esta es una forma extendidas con mas parametros de control
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;
                cmd.CommandType = CommandType.Text;  // otros tipos son :CommandType.StoredProcedure CommandType.TableDirect;                 
                cmd.CommandTimeout = 10;
                LectorDatos = cmd.ExecuteReader();  // ejecuta y retorna un conjunto de datos no actualizable
                while (LectorDatos.Read())  
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
        public string EjecutarComando(string sentencia)
        {
            string salida = "LOS DATOS SE ACTUALIZARON SATISFACTORIAMENTE!";
            try
            {
                int retornado; 
                AbrirBd(); 
                cmd = new SqlCommand(sentencia, conexion); 
                retornado = cmd.ExecuteNonQuery(); // UTILIZADO PARA UPDATE, INSERT y DELETE
                CerrarrBd();                 
                if (retornado > 0)                
                {                     
                    salida = "Los  datos  fueron  Actualizados";                 
                }                 
                else                 
                {                     
                    salida = "Los  datos no fueron Actualizados";                 
                }             
            }             
            catch (Exception ex)             
            {                 
                salida = "falló inserción: " + ex;            
            }             
            return salida;         
        }
        public DataTable cargartabla(string tabla, string strCondicion) 
        { 
            try 
            { 
                AbrirBd(); 
                string Sql = "Select * from " + tabla + " " + strCondicion; 
                da = new SqlDataAdapter(Sql, conexion); 
                ds = new DataSet(); 
                da.Fill(ds, tabla); 
                DataTable dt = new DataTable(); 
                dt = ds.Tables[tabla]; 
                CerrarrBd(); 
                return dt; 
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("ERROR EN LA CONSULTA: " + ex.ToString()); 
                return null; 
            } 
        }
        public DataTable EjecutarComandoDatos(string cmd)
        {
            try 
            { 
                AbrirBd(); 
                da = new SqlDataAdapter(cmd, conexion); 
                dt = new DataTable(); 
                da.Fill(dt); 
                CerrarrBd(); 
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

