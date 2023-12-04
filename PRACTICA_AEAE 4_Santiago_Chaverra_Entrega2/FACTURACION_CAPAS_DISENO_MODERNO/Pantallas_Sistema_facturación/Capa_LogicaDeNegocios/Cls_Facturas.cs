using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Facturas
    {
        public int IdFactura { get; set; }
        public DateTime DtmFecha { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public float NumDescuento { get; set; }
        public float NumImpuesto { get; set; }
        public float NumValorTotal { get; set; }
        public int IdEstado { get; set; }
        public DateTime DtmFechaModifica { get; set; }
        public string StrUsuarioModifica { get; set; }
        public string StrDetalle { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        // consultar datos en la tabla de facturas
        public DataTable ConsultaFacturas() 
        {
            string Sentencia = "";
            try
            {
                Sentencia = "select fa.IdFactura, cl.StrNombre, fa.DtmFecha, fa.NumValorTotal, ef.StrDescripcion from TBLFACTURA fa join \r\nTBLCLIENTES cl on fa.IdCliente = cl.IdCliente join TBLESTADO_FACTURA ef on fa.IdEstado = ef.IdEstadoFactura";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }


        }

        // sobre carga funcion consultar facturas para consultar una factura especifica

        public DataTable Consulta_Factura(int factura)
        {
            string Sentencia = "";
            try
            {
                Sentencia = $"select fa.IdFactura, cl.IdCliente, em.IdEmpleado, fa.DtmFecha, ef.IdEstadoFactura, fa.NumDescuento, fa.NumImpuesto, fa.NumValorTotal, fa.StrDescripcion from TBLFACTURA fa join TBLCLIENTES cl on fa.IdCliente = cl.IdCliente join TBLESTADO_FACTURA ef on fa.IdEstado = ef.IdEstadoFactura join TBLEMPLEADO em on em.IdEmpleado = fa.IdEmpleado where fa.IdFactura = '{factura}'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        // filtrar facturas por nombre del cliente
        public DataTable Filtrar_Factura(string filtro)
        {
            string Sentencia = "";
            try
            {
                Sentencia = $"select fa.IdFactura, cl.StrNombre, fa.DtmFecha, fa.NumValorTotal, ef.StrDescripcion from TBLFACTURA fa join \r\nTBLCLIENTES cl on fa.IdCliente = cl.IdCliente join TBLESTADO_FACTURA ef on fa.IdEstado = ef.IdEstadoFactura \r\nwhere cl.StrNombre like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public string EliminarFactura(int IdFactura)
        {
            string Sentencia = "";
            try
            {
                Sentencia = $"Delete from TBLFACTURA where IdFactura = {IdFactura}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(Sentencia);
                return Convert.ToString(dt);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string ActualizarFactura()
        {
            string Sentencia = "";
            try
            {
                Sentencia = $"update TBLFACTURA set DtmFecha = '{DtmFecha}',IdCliente = {IdCliente},IdEmpleado = {IdEmpleado},NumDescuento = '{NumDescuento}', NumImpuesto = '{NumImpuesto}',NumValorTotal = '{NumValorTotal}',IdEstado = {IdEstado},DtmFechaModifica = '{DtmFechaModifica}',StrUsuarioModifica = '{StrUsuarioModifica}', StrDetalle = '{StrDetalle}' where IdFactura = {IdFactura}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(Sentencia);
                return "Datos Actualizados";
            }
            catch (Exception ex)
            {
                return "No se pudo actualizar";
            }
        }

        public string InsertarFactura()
        {
            string Sentencia = "";
            try
            {
                Sentencia = $"Insert into TBLFACTURA (DtmFecha,IdCliente,IdEmpleado,NumDescuento,NumImpuesto,NumValorTotal,IdEstado,DtmFechaModifica,StrUsuarioModifica,StrDescripcion) values ('{DtmFecha}',{IdCliente},{IdEmpleado},'{NumDescuento}','{NumImpuesto}','{NumValorTotal}',{IdEstado},'{DtmFechaModifica}','{StrUsuarioModifica}','{StrDetalle}')";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(Sentencia);
                if (dt == null)
                {
                    return "No inserto";
                }
                return "Datos Insertados";
            }
            catch (Exception ex)
            {
                return "No se pudo actualizar";
            }
        }

        public DataTable ConsultarCliente()
        {
            string Sentencia;
            try
            {
                Sentencia = "Select * from TBLCLIENTES";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable ConsultarEmpleado()
        {
            string Sentencia;
            try
            {
                Sentencia = "Select * from TBLEMPLEADO";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable ConsultarEstado()
        {
            string Sentencia;
            try
            {
                Sentencia = "Select * from TBLESTADO_FACTURA";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(Sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }







    }
}
