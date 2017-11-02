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
    class DBhelper
    {

        private static DBhelper instancia;
        private SqlConnection conexion;

        static DBhelper getInstancia() {

            if (instancia == null) {

                instancia = new DBhelper();
                return instancia;
            
            }

            else {

                return instancia;
            
            }
        
        }

        public void crearConexion() {

            conexion = new SqlConnection("tudirec");
        
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





    }
}