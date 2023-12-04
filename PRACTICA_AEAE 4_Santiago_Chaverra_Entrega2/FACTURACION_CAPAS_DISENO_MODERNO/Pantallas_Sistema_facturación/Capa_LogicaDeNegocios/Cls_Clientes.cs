using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;
using System.Net.Http.Headers;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Clientes
    {
        // Definimos los atributos de la clase

        public int Cls_IdCliente { get; set; }
        public string Cls_StrNombre { get; set; }
        public int Cls_NumDocumento { get; set; }
        public string Cls_StrDireccion { get; set; }
        public string Cls_StrTelefono { get; set; }
        public string Cls_StrEmail { get; set; }
        public string Cls_DtmFechaModifica { get; set; }
        public string Cls_StrUsuarioModifica { get; set; }


        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();


        // consultamos todos los datos de la tabla clientes

        public DataTable ConsultaCliente() 
        {
            string sentencia;
            try 
            {
                sentencia = "select * from TBLCLIENTES";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
                
            }
            catch (Exception)
            {
                return null;
            }
        
        }

        public DataTable Consulta_Cliente(int IdCliente)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLCLIENTES where IdCliente = {IdCliente}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }

        }


        public DataTable Filtrar_Cliente(string filtro) 
        {
            string sentencia;
            try 
            {
                sentencia = $"select * from TBLCLIENTES where StrNombre like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            
            }
            catch (Exception)
            {
                return null;
            }

        }

        public string EliminarCliente() 
        {
            string mensaje = "";
            try 
            { 
                //creamos una estructura de tipo lista que tendra los parametros que necesitan los procedimientos almacenados 
                List<Cls_parametros> lst = new List<Cls_parametros>();

                // adicionamos el parametro que permite indicar el IdCliente que borraremos
                lst.Add(new Cls_parametros("@IdCliente", Cls_IdCliente));
                // ejecutamos el procedimiento y pasamos lst con los parametros y valores
                mensaje = Acceso_Datos.Ejecutar_procedimiento("Eliminar_Cliente", lst);

            
            }
            catch(Exception ex) 
            {
                mensaje = "Falló el borrado del cliente" + ex.Message;
            }

            return mensaje;


        }

        public string ActualizarCliente() 
        {
            string mensaje = "";
            try 
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                //adicionamos los parametros con nombre y valores al objeto creado lst
                lst.Add(new Cls_parametros("@IdCliente",Cls_IdCliente));
                lst.Add(new Cls_parametros("@StrNombre",Cls_StrNombre));
                lst.Add(new Cls_parametros("@NumDocumento",Cls_NumDocumento));
                lst.Add(new Cls_parametros("@StrDireccion",Cls_StrDireccion));
                lst.Add(new Cls_parametros("@StrTelefono",Cls_StrTelefono));
                lst.Add(new Cls_parametros("@StrEmail",Cls_StrEmail));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", Cls_StrUsuarioModifica));
                lst.Add(new Cls_parametros("@DtmFechaModifica", Cls_DtmFechaModifica));

                //ejcutamos el procedimiento y pasamos el lst con los parametros    

                mensaje = Acceso_Datos.Ejecutar_procedimiento("actualizar_Cliente", lst);
                

            }
            catch(Exception ex)
            {
                mensaje = "Falló la actualización cliente " + ex.Message;
            }

            return mensaje;
        
        }







    }
}
