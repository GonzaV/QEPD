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

        const Int32 VACIO = -1;
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

        public Int32 getIdEmpresaSeleccionada() {

            return idEmpresaSeleccionada;

        }

        public void reiniciarEmpresaSeleccionada() {

            idEmpresaSeleccionada = VACIO;

        }

        public void crearEmpresa(String nombre, String cuit, String direccion, String rubro) {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.newEmpresa");
            cmd.Parameters.Add("@Nombre_Empresa", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Cuit_Empresa", SqlDbType.NVarChar).Value = cuit;
            cmd.Parameters.Add("@Direccion_Empresa", SqlDbType.NVarChar).Value = direccion;
            cmd.Parameters.Add("@descripcionRubro_Empresa", SqlDbType.NVarChar).Value = rubro;

            DBhelper.abrirConexion();

            DBhelper.obtenerRetornoProcedure(cmd);

            DBhelper.cerrarConexion();
        
        
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

        public void modificarEmpresa(String nombre, String cuit, String direccion, String rubro) {

            DBhelper.crearConexion();

            if(nombre == "") nombre = "acaPidoNombreEmpresa";
            if(cuit == "") cuit = "acaPidoCuitEmpresa";
            if(direccion == "") direccion = "acaPidoDireccionEmpresa";
            if(rubro == "") rubro = "acaPidoRubroEmpresa";

            SqlCommand cmd = DBhelper.crearCommand("QEPD.modificarEmpresa");
            cmd.Parameters.Add("@idEmpresa",SqlDbType.Int).Value = idEmpresaSeleccionada;
            cmd.Parameters.Add("@Nombre_Empresa", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Cuit_Empresa", SqlDbType.NVarChar).Value = cuit;
            cmd.Parameters.Add("@Direccion_Empresa", SqlDbType.NVarChar).Value = direccion;
            cmd.Parameters.Add("@descripcionRubro_Empresa", SqlDbType.NVarChar).Value = rubro;
            cmd.Parameters.Add("@Fecha_Rendicion", SqlDbType.DateTime).Value = DateTime.Now;

            DBhelper.abrirConexion();

            DBhelper.obtenerRetornoProcedure(cmd);

            DBhelper.cerrarConexion();

        }

        /*public Model.Empresa getEmpresa() {

            Model.Empresa empresa;

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getEmpresa");
            cmd.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = idEmpresaSeleccionada;

            DBhelper.abrirConexion();

            

           

               

                rubro.setDescripcion((String)row["Descripcion_Rubro"]);
                rubro.setNro((decimal)row["Nro_Rubro"]);

                return empresa;
                
            }*/

            
        
        


    }
}
