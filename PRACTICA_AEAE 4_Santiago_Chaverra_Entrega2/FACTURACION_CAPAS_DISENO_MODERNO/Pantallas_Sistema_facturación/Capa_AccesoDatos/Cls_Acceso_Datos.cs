using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_AccesoDatos
{

    public class Cls_parametros 
    {
        // Definimos parametros Atributos
        public string Nombre { get; set; } //Nombre del parametro
        public object Valor { get; set; } // Valor parametro
        public SqlDbType TipoDato { get; set; } // tipo de dato 
        public Int32 Tamaño { get; set; } // longitud del parametro
        public ParameterDirection DireccionParametro { get; set; } // Dirección del parametro , Input , Output
        

        //Constructor parametros de entrada

        public Cls_parametros(string Objnombre, Object ObjValor) 
        {
            Nombre = Objnombre;
            Valor = ObjValor;
            DireccionParametro = ParameterDirection.Input;
        }

        //Constructor parametros de salida

        public Cls_parametros(string Objnombre, SqlDbType ObjTipoDato, Int32 ObjTamaño) 
        {
            Nombre = Objnombre;
            TipoDato = ObjTipoDato;
            Tamaño = ObjTamaño;
            DireccionParametro = ParameterDirection.Output;
        }
    
    }

    public class Cls_Acceso_Datos
    {
        SqlConnection conexion; // se define la variable para la conexión de tipo SqlConnection
        SqlCommand cmd; // se define la variable para realizar los comandos en la BD
        SqlDataReader LectorDatos = null; // utilizados para leer datos, suele ir acompañado de un objeto command  que contiene la consulta.
        SqlDataAdapter da; // se utiliza como puente entre DataSet y SQL Server para recuperar y guardar datos
        DataTable dt; // representa una tabla de datos relacionales en memoria 


        public string AbrirBd() //metodo para abrir la base de datos
        {
            string resultado = "";
            try // permite la captura de un error en caso de que se presente
            {
                //creamos un objeto de tipo conexión a la base de datos y se pasa como parametro la cadena de conexión
                conexion = new SqlConnection("Data Source=DESKTOP-ARMDG69;Initial Catalog=[DBFACTURAS];Integrated Security=true");
                conexion.Open();
            }
            catch (Exception ex) // si hay error retornamos el siguiente mensaje
            {
                resultado = "Error: No se estableció la conexión con la base de datos " + ex;
            }
            return resultado;
        }

        public string CerrarBd() //metodo para cerrar la base de datos
        {
            string resultado = "";
            try 
            { 
                conexion.Close(); // invocamos el metodo para cerrar la base de datos
            }
            catch(Exception ex) 
            {
                resultado = "Error: Fallo al cerrar la conexión " + ex;
            }
            return resultado;

        }

        //PERMITE EJECUTAR PROCEDIMIENTOS ALMACENADOS EN LA BASE DE DATOS, LOS PARAMETROS SE PASAN POR MEDIO DE UNA LISTA (lst)
        public string Ejecutar_procedimiento(string procedimiento,List<Cls_parametros> lst) 
        {
            string salida = "";
            try 
            {
                int retornado;
                AbrirBd();
                //creamos el objeto comando con el nombre del procedimiento a ejecutar y la conexión
                SqlCommand comando = new SqlCommand(procedimiento,conexion);
                comando.CommandType = CommandType.StoredProcedure;

                //Asignamos al comando los valores de los parametros recibidos en la variable lst
                if (lst!=null) 
                {
                    for (int i = 0; i < lst.Count; i++) // recorremos la lista de parametros recibidos en lst
                    {
                        //analiza si el parametro es de entrada, osea que se lo enviemos a la base de datos
                        if (lst[i].DireccionParametro==ParameterDirection.Input) 
                        {
                            //asignamos los valores con el nombre del parametro y el valor
                            comando.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }

                        //identifica si el parametro es el que recibe el valor de filas afectadas en la base de datos

                        if (lst[i].DireccionParametro == ParameterDirection.Output)
                        {
                            //asignamos los valores con el nombre del parametro y el valor
                            comando.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }


                    }                    

                }

                retornado = comando.ExecuteNonQuery();//ejecutamos el procedimiento con sus parametros
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
            catch (Exception ex) 
            {
                salida = "Error: falló la operación " + ex;
            }
            return salida;

        }

        //Recibe una sentencia SQL o un procedimiento para UPDATE, INSERT Y DELETE, RETORNA MENSAJES INDICANDO SI ACTUALIZÓ O NO
        public string EjecutarComando(string sentencia) 
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion); //Indicamos la sentencia a ejecutar y la conexion a la base de datos
                retornado = cmd.ExecuteNonQuery(); //En retornado recibe el Nro de filas afectadas
                CerrarBd() ;
                if (retornado > 0) 
                {
                    salida = "Los datos fueron actualizados";
                }
                else 
                {
                    salida = "Los datos No fueron actualizados";
                }


            }
            catch (Exception ex) 
            {
                salida = "Error: fallo operación " + ex;
            }
            
            return salida;
        }

        //Metodo que permite realizar una consulta en una o varias tablas
        //y retorna un conjunto de registros en un datatable (ideal para llenar el datagrid y los combos)

        public DataTable EjecutarConsulta(string cmd)
        {
            try 
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd() ;
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


    }
}
