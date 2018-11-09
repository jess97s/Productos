using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using capaEntidades;

namespace capaDatos
{
   
        public class accesoDatosRespaldoBD
        {
            SqlConnection cnx; //conexion
            Conexion cn = new Conexion();
            SqlCommand cm = null; //para los comando sql
            int indicador = 0; //variablae k indica si el metodo se ejecuto


            public int respaldarBD()
            {
                try
                {
                    SqlConnection cnx = cn.conectar(); //conexion

                    cm = new SqlCommand("respaldoBD_Productos", cnx);
                    cm.CommandType = CommandType.StoredProcedure;
                    cnx.Open();
                    cm.ExecuteNonQuery();
                    indicador = 1;
                }


                catch (Exception e)
                {
                    e.Message.ToString();
                    indicador = 0;
                }
                finally { cm.Connection.Close(); }
                return indicador;
            }
        }
    }
