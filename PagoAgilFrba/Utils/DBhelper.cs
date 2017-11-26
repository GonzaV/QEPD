using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PagoAgilFrba.Utils
{
    public class DBhelper
    {

        private static DBhelper instancia;
        private SqlConnection conexion;

        public static DBhelper getInstancia() {

            if (instancia == null) {

                instancia = new DBhelper();
                return instancia;
            
            }

            else {

                return instancia;
            
            }
        
        }

        public void crearConexion() {

            conexion = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD2C2017;User ID=gd;Password=gd2017");
        
        }

        public void abrirConexion() {

            conexion.Open();

        }

        public SqlCommand crearCommand(String nombreProcedure) {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = nombreProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            return cmd;
        
        }

        public DataTable obtenerTabla(SqlCommand cmd){

            SqlDataReader reader;
            DataTable tabla = new DataTable();

            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            tabla.Load(reader);

            return tabla;

        }

        public void obtenerRetornoProcedure(SqlCommand cmd) { //Cuando el procedure no retorna tabla

           cmd.ExecuteNonQuery();
            
        }

        public void cerrarConexion() {

            conexion.Close();

        }

      /*  public DataTable obtenerUnicoResultadoTabla(SqlCommand cmd) {

            SqlDataReader reader;
            DataTable tabla = new DataTable();

            reader = cmd.ExecuteScalar();
            tabla.Load(reader);

            return tabla;
        
        }*/

        //AGREGO ESTO PARA SABER SI SE CREO ALGO EN LA TABLA
        
        

    }
}
