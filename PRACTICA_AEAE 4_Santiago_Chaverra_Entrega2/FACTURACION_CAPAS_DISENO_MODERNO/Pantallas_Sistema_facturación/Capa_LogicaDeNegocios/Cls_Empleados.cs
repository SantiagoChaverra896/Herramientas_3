using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;
using System.Globalization;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Empleados
    {
        // definimos los atributos de la clase
        public int C_IdEmpleado { get; set; }
        public string C_strNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public string C_DtmIngreso { get; set; }
        public string C_DtmRetiro { get; set; }
        public string C_StrDatosAdicionales { get; set; }
        public string C_UsuarioModifico { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        // CONSULTAMOS TODOS LOS DATOS DE LA TABLA DE EMPLEADOS

        public DataTable ConsultaEmpleado() 
        {
            string sentencia;
            try 
            {
                sentencia = $"select * from TBLEMPLEADO";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch(Exception) 
            {
                return null;
            }
        }


        public DataTable Consulta_Empleado(int IdEmpleado)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLEMPLEADO where IdEmpleado = {IdEmpleado}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable Filtrar_Empleado(string filtro) 
        {
            string sentencia;
            try 
            {
                sentencia = $"select * from TBLEMPLEADO where strnombre like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch(Exception)
            {
                return null;
            }
        
        }


        // metodo para consultar todos los registros de la tabla TBLROLES con el fin de llenar el combo para indicar el rol del empleado
        public DataTable ConsultarRol() 
        {
            string sentencia;
            try 
            {
                sentencia = $"select * from TBLROLES";
                DataTable dt = new DataTable() ;
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception) 
            {
                return null;
            }



        }

        //Metodo para eliminar un empleado especifico

        public string EliminarEmpleado() 
        {
            string mensaje = "";
            try 
            { 
                //creamos una estructura de tipo lista que tendra los parametros que necesitan los procedimientos almacenados
                List<Cls_parametros> lst = new List<Cls_parametros>();
                // adicionamos el parametro que permite indicar el IdEmpleado que borraremos
                // contiene el nombre y el valor del parametro 

                lst.Add(new Cls_parametros("@IdEmpleado",C_IdEmpleado));
                // ejecutamos el procedimiento y pasamos lst con nuevos procedimientos y valores
                mensaje = Acceso_Datos.Ejecutar_procedimiento("eliminar_Empleado", lst);

            
            
            }
            catch(Exception ex) 
            {
                mensaje = "Falló borrado en el empleado "+ex.Message;
            }
            return mensaje;
        }

        // metodo que permite tanto insertar como actualizar los datos de un empleado
        public string ActualizarEmpleado() 
        {
            string mensaje = "";
            try 
            {
                
                List<Cls_parametros> lst = new List<Cls_parametros>(); // creamos el objeto lista lst que tendra los nombres de parametros y valores
                
                // adicionamos los parametros con nombre y valores al objeto creado lst
                lst.Add(new Cls_parametros("@IdEmpleado",C_IdEmpleado));
                lst.Add(new Cls_parametros("@StrNombre", C_strNombre));
                lst.Add(new Cls_parametros("@NumDocumento", C_NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion", C_StrDireccion));
                lst.Add(new Cls_parametros("@StrTelefono", C_StrTelefono));
                lst.Add(new Cls_parametros("@StrEmail", C_StrEmail));
                lst.Add(new Cls_parametros("@IdRolEmpleado", C_IdRolEmpleado));
                lst.Add(new Cls_parametros("@DtmIngreso", C_DtmIngreso)); 
                lst.Add(new Cls_parametros("@DtmRetiro", C_DtmRetiro));
                lst.Add(new Cls_parametros("@strDatosAdicionales", C_StrDatosAdicionales));
                lst.Add(new Cls_parametros("@DtmFechaModifica", DateTime.Now));
                lst.Add(new Cls_parametros("@StrUsuarioModifico", C_UsuarioModifico));


                //Ejecutamos el procedimiento y pasamos lst con todos los parametros
                mensaje = Acceso_Datos.Ejecutar_procedimiento("actualizar_Empleado",lst);


            }
            catch (Exception ex) 
            {
                mensaje = "Fallo la actualización del empleado " + ex.Message;
            }

            return mensaje;
        }




    }
}
