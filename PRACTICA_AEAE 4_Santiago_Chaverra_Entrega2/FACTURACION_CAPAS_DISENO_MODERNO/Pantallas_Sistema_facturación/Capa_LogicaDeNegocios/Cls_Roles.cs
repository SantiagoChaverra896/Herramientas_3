using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;
using System.Globalization;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Roles
    {
        // definimos los atributos de la clase
        public int C_IdRolEmpleado { get; set; }
        public string C_NombreRol {get; set; }
        public string C_StrDescripcionRol { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        // Consultamos todos los datos de la tabla de roles

        public DataTable ConsultaRoles() 
        {
            string sentencia;
            try 
            {
                sentencia = "SELECT * from TBLROLES";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;

            }catch(Exception) 
            {
                return null;
            }
        }

        // sobrecarga del metodo consulta para  anexarle el parametro IdEmpleado que nos permita buscar un empleado especifico

        public DataTable Consulta_Roles(int IdRolEmpleado) 
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * from TBLROLES where IdRolEmpleado = {IdRolEmpleado}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }

        }

        // funcion para filtrar por nombre de rol 

        public DataTable Filtrar_Empleado(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLROLES where StrDescripcion like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch(Exception ex)
            {
                return null;
            }

        }

        public string EliminarRol(int IdRol) 
        {
            string mensaje = "";
            try 
            {
                mensaje = $"Delete from TBLROLES where IdRolEmpleado = {IdRol}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(mensaje);
                return Convert.ToString(dt);

            }
            catch (Exception) 
            {
                return null;
            }
        }

        public string ActualizarRol()
        {
            string mensaje = "";
            try
            {
                mensaje = $"Update TBLROLES set StrDescripcion = '{C_StrDescripcionRol}' where IdRolEmpleado = {C_IdRolEmpleado}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(mensaje);
                return "Datos Actualizados";
            }
            catch (Exception)
            {
                return "No se pudo actualizar";
            }
        }

        public string InsertarRol()
        {
            string mensaje = "";
            try
            {
                mensaje = $"Insert into TBLROLES (StrDescripcion) Values ('{C_StrDescripcionRol}')";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(mensaje);
                return "Datos Insertados";
            }
            catch (Exception)
            {
                return "No se pudo insertar el nuevo registro";
            }
        }






    }
}
