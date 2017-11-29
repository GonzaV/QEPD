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
        public Int32 idEmpresaSeleccionada;
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

        public void setIdEmpresaSeleccionada(Int32 id) {

            this.idEmpresaSeleccionada = id;

        }

        public void crearEmpresa(String nombre, String cuit, String direccion, String rubro) {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.newEmpresa");
            cmd.Parameters.Add("@Nombre_Empresa", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Cuit_Empresa", SqlDbType.NVarChar).Value = cuit;
            cmd.Parameters.Add("@Direccion_Empresa", SqlDbType.NVarChar).Value = direccion;
            cmd.Parameters.Add("@descripcionRubro_Empresa", SqlDbType.NVarChar).Value = rubro;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();
        
        
        }

        public Model.Empresa getEmpresa(String nombre) 
        {
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getEmpresaNombre");
            cmd.Parameters.Add("@Nombre_Empresa", SqlDbType.NVarChar).Value = nombre;

            DBhelper.abrirConexion();

            DataTable tablaEmpresa = DBhelper.obtenerTabla(cmd);

            Model.Empresa empresa = new Model.Empresa();

            foreach (DataRow row in tablaEmpresa.Rows)
            {
               /* empresa.set
                
                setar lo de empresa pero para eso necesito la clase vieja de empresa
                
                */
            }

            DBhelper.cerrarConexion();

            return empresa;
        }


        public List<Model.Rubro> getRubros()
        {

            DataTable tablaRubros;
            List<Model.Rubro> listaDeRubros = new List<Model.Rubro>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getRubros");

            DBhelper.abrirConexion();

            tablaRubros = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaRubros.Rows)
            {

                Model.Rubro rubro = new Model.Rubro();

                rubro.setDescripcion((String)row["Descripcion_Rubro"]);
                rubro.setNro((decimal)row["Nro_Rubro"]);
                
                listaDeRubros.Add(rubro);
            }

            return listaDeRubros;

        }



    }
}
