using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;
using System.ComponentModel.Design;

namespace Capa_LogicaDeNegocios
{
    public class Cls_Productos
    {
        // definimos los atributos de la clase
        public int C_IdProducto { get; set; }
        public string C_StrName { get; set; }
        public string C_StrCodigo { get; set; }
        public float C_NumPrecioCompra { get; set; }
        public float C_NumPrecioVenta { get; set; }
        public int C_IdCategoria { get; set; }
        public string C_StrDetalle { get; set; }
        public string C_StrFoto { get;set; }
        public int C_NumStock { get; set; }
        public string C_DtmFechaModifica { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();



        public DataTable ConsultaProducto() 
        {
            string sentencia;
            try 
            {
                sentencia = "Select p.IdProducto, p.StrNombre, cp.StrDescripcion, p.NumPrecioVenta, p.NumStock from TBLPRODUCTO p JOIN TBLCATEGORIA_PROD cp on p.IdCategoria = cp.IdCategoria";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception) 
            {
                return null;
            }

        }


        public DataTable Consulta_Producto(int IdProducto)
        {
            string sentencia;
            try
            {
                sentencia = $"Select p.IdProducto, p.StrNombre, cp.StrDescripcion, p.NumPrecioCompra ,p.NumPrecioVenta, p.NumStock, p.strFoto, p.StrDetalle from TBLPRODUCTO p JOIN TBLCATEGORIA_PROD cp on p.IdCategoria = cp.IdCategoria where IdProducto = {IdProducto}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }


        public DataTable ConsultarCategoria()
        {
            string sentencia;
            try
            {
                sentencia = $"SELECT * FROM TBLCATEGORIA_PROD";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }



        }



        public DataTable Filtrar_Producto(string filtro)
        {
            string sentencia;
            try
            {
                sentencia = $"select * from TBLPRODUCTO where StrNombre like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }

        }


        public string EliminarProducto()
        {
            string mensaje = "";
            try
            {
                //creamos una estructura de tipo lista que tendra los parametros que necesitan los procedimientos almacenados 
                List<Cls_parametros> lst = new List<Cls_parametros>();

                // adicionamos el parametro que permite indicar el IdCliente que borraremos
                lst.Add(new Cls_parametros("@IdCliente", C_IdProducto));
                // ejecutamos el procedimiento y pasamos lst con los parametros y valores
                mensaje = Acceso_Datos.Ejecutar_procedimiento("Eliminar_Cliente", lst);


            }
            catch (Exception ex)
            {
                mensaje = "Falló el borrado del cliente" + ex.Message;
            }

            return mensaje;


        }


        public string ActualizarProducto()
        {
            string mensaje = "";
            try
            {
                List<Cls_parametros> lst = new List<Cls_parametros>();

                //adicionamos los parametros con nombre y valores al objeto creado lst
                lst.Add(new Cls_parametros("@IdProducto", C_IdProducto));
                lst.Add(new Cls_parametros("@StrNombre", C_StrName));
                lst.Add(new Cls_parametros("@StrCodigo", C_StrCodigo));
                lst.Add(new Cls_parametros("@NumPrecioCompra", C_NumPrecioCompra));
                lst.Add(new Cls_parametros("@NumPrecioVenta", C_NumPrecioVenta));
                lst.Add(new Cls_parametros("@IdCategoria", C_IdCategoria));
                lst.Add(new Cls_parametros("@StrDetalle", C_StrDetalle));
                lst.Add(new Cls_parametros("@StrFoto", C_StrFoto));
                lst.Add(new Cls_parametros("@NumStock", C_NumStock));
                lst.Add(new Cls_parametros("@DtmFechaModifica", C_DtmFechaModifica));
                lst.Add(new Cls_parametros("@StrUsuarioModifica", C_StrUsuarioModifica));


                //ejecutamos el procedimiento y pasamos el lst con los parametros    
                mensaje = Acceso_Datos.Ejecutar_procedimiento("actualizar_Producto", lst);

            }
            catch (Exception ex)
            {
                mensaje = "Falló la actualización cliente " + ex.Message;
            }

            return mensaje;

        }







    }
}
