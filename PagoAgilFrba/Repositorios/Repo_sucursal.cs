using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PagoAgilFrba.Repositorios
{
    class Repo_sucursal
    {

        public static Repo_sucursal instancia;
        private Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_sucursal getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_sucursal();

                return instancia;
            }
        }

        public void crearSucursal(decimal codigo_postal, String nombre, String direccion)
        {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.newSucursal");
            cmd.Parameters.Add("@CodPostal", SqlDbType.Float).Value = codigo_postal;
            cmd.Parameters.Add("@SucursalNombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@SucursalDirecc", SqlDbType.NVarChar).Value = direccion;
            
            DBhelper.abrirConexion();

            DBhelper.obtenerRetornoProcedure(cmd);

            DBhelper.cerrarConexion();

        }

    }
}
