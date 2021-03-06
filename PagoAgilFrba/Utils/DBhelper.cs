﻿using System;
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

            conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexion"].ConnectionString);
            /*conexion = new SqlConnection(@"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD2C2017;User ID=gd;Password=gd2017");*/
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

        public void ejecutarProcedure(SqlCommand cmd) { //Cuando el procedure no retorna tabla

           cmd.ExecuteNonQuery();
            
        }

        public void cerrarConexion() {

            conexion.Close();

        }

        public DataTable obtenerData(String query) {

            //DataSet data = new DataSet();

            crearConexion();
            abrirConexion();

            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand(query, conexion);

            tabla.Load(cmd.ExecuteReader());
            //data.Tables.Add(tabla);

            cerrarConexion();

            return tabla;
              
        }

       
  
        
        

    }
}
