using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Seguridad
    {

        // DEFINIMOS LOS ATRIBUTOS DE LA CLASE
        public int C_IdEmpleado { get; set; }
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        // consultamos todos los empleados para mostrar en combo

        public DataTable ConsultarEmpleados() 
        {
            string sentencia;
            try 
            {
                sentencia = "select IdEmpleado, strNombre from TBLEMPLEADO";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception) 
            {
                return null;
            }

        }

        // consultamos la información del usuario y clave que tiene un empleado en la tabla TblSeguridad
        public DataTable Consulta_SeguridadEmpleado(int IdEmpleado) 
        {
            string sentencia = "";
            try 
            {
                sentencia = $"select StrUsuario, StrClave from TBLSEGURIDAD where IdEmpleado = {IdEmpleado}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch(Exception) 
            {
                return null;
            }
        }

        //creamos el metodo para eliminar la información de seguridad de un usuario especifico
        // eliminamos un registro de la base de datos

        public string EliminarSeguridadEmpleado() 
        {
            string mensaje = "";
            try
            {
                //creamos una estructura de tipo lista que tendra los parametros que necesita el procedimiento almacenado
                List<Cls_parametros> lst = new List<Cls_parametros>();

                //adicinamos el parametro que permite indicar el IdEmpleado que borraremos
                // contiene el nombre y el valor del parametro
                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                // ejecutamos el procedimiento y pasamos lst con los parametros y valores
                mensaje = Acceso_Datos.Ejecutar_procedimiento("Eliminar_Seguridad", lst);
            }
            catch (Exception ex)
            {
                mensaje = "Fallo borrado en el empleado " + ex.Message;
            }
            return mensaje;
        }

        //implementamos el metodo que facilitará tanto el ingreso como la actualización de la información de seguridad de un usuario especifico

        public string ActualizarSeguridadEmpleado() 
        {
            string mensaje = "";
            try 
            {
                List<Cls_parametros> lst = new List<Cls_parametros>(); //creamos el objeto lista lst que tendra los nombres de parametros y valores
                // Adicionamos los parametros con nombre y valores al objeto creado lst
                lst.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                lst.Add(new Cls_parametros("@StrUsuario", C_StrUsuario));
                lst.Add(new Cls_parametros("@StrClave", C_StrClave));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_StrUsuarioModifico));

                //Ejecutar el procedimiento y pasamos lst con todos los parametros
                mensaje = Acceso_Datos.Ejecutar_procedimiento("actualizar_Seguridad", lst);

            }
            catch (Exception ex)
            {
                mensaje = "FALLO LA ACTUALIZACION EMPLEADO " + ex.Message;
            }
            return mensaje;
        }




    }
}
