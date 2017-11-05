using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PagoAgilFrba.Model{

    class Repo_cliente{
        
        
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();
        public static List<Cliente> listaDeClientes = new List<Cliente>();
        public static Repo_cliente instancia;

        public static Repo_cliente getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_cliente();

                return instancia;
            }
        }



        public void getClientes(){

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("QEPD.getClientes");


 
        }


        public void newCliente(String nombre, String apellido, Int32 dni, String email, Int32 telefono, DateTime fnacimiento, String direccion, Int32 cp){

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("QEPD.newCliente");
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@dni", SqlDbType.Int).Value = dni;
            cmd.Parameters.Add("@fnacimiento", SqlDbType.DateTime).Value = fnacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
            cmd.Parameters.Add("@cp", SqlDbType.Int).Value = cp;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();


        }

        public void eliminarCliente(Int32 idCliente){
            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("QEPD.newCliente");
            cmd.Parameters.Add("@idCLiente", SqlDbType.NVarChar).Value = idCliente;
        }

    }
}
