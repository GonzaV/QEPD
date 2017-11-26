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
    public class Repo_empresas
    {

        public static Repo_empresas instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_empresas getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_empresas();

                return instancia;
            }
        }

        public void crearEmpresa(String nombre, String cuit, String direccion, String cp) {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.modificarRol");
            cmd.Parameters.Add("@rolId", SqlDbType.Int).Value = rolSeleccionado.getId();
            cmd.Parameters.Add("@rolNombreNuevo", SqlDbType.NVarChar).Value = nuevoNombre;

            DBhelper.abrirConexion();

            DBhelper.obtenerRetornoProcedure(cmd);

            DBhelper.cerrarConexion();
        
        
        }

    }
}
