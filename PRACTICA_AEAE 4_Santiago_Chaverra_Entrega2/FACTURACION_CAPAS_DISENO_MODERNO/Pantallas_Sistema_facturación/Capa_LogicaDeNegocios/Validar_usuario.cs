using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Validar_usuario
    {
        //definimos los atributos de la clase
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public Int32 C_IdEmpleado { get; set; }
        public void ValidarUsuario() //metodo que valida el usuario, consulta en la base de datos el usuario y la clave
        {
            try 
            {
                string sentencia = $"select IdEmpleado from TBLSEGURIDAD where StrUsuario = '{C_StrUsuario}' and StrClave = '{C_StrClave}'";
                DataTable dt = new DataTable();
                Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos(); // creamos un objeto con la clase Acceso a Datos
                dt = Acceso.EjecutarConsulta(sentencia);

                foreach(DataRow row in dt.Rows) 
                {
                    C_IdEmpleado = int.Parse(row[0].ToString()); // actualizamos el numero del id del cliente  que se encontró en la BD
                }
            }
            catch(Exception ex) 
            {
                throw new Exception("Error en la consulta "+ ex);
            }



        }


    }


}
