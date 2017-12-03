using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;


namespace PagoAgilFrba.Repositorios
{
    public class Repo_empresas
    {

        const Int32 VACIO = -1;
        public static Repo_empresas instancia;
        public Int32 idEmpresaSeleccionada;
        public Boolean estadoEmpresaSeleccionada;
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

        public void setEstadoEmpresaSeleccionada(Boolean estado) {

            this.estadoEmpresaSeleccionada = estado;

        }

        public Int32 getIdEmpresaSeleccionada() {

            return idEmpresaSeleccionada;

        }

        public Boolean getEstadoEmpresa() {

            return estadoEmpresaSeleccionada;

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

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();
        
        
        }

        /*public Model.Empresa getEmpresa(String nombre) 
        {
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getEmpresaNombre");
            cmd.Parameters.Add("@Nombre_Empresa", SqlDbType.NVarChar).Value = nombre;

            DBhelper.abrirConexion();

            DataTable tablaEmpresa = DBhelper.obtenerTabla(cmd);

            Model.Empresa empresa = new Model.Empresa();

            foreach (DataRow row in tablaEmpresa.Rows)
            {
               empresa.set
                
                setar lo de empresa pero para eso necesito la clase vieja de empresa
                
              
            }

            DBhelper.cerrarConexion();

            return empresa;
        }*/

        public Model.Empresa getEmpresa(Int32 id)
        {
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getEmpresa");
            cmd.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = id;

            DBhelper.abrirConexion();

            DataTable tablaEmpresa = DBhelper.obtenerTabla(cmd);

            Model.Empresa empresa = new Model.Empresa();

            foreach (DataRow row in tablaEmpresa.Rows)
            {
                empresa.setId(id);
                empresa.setNombre((String)row["Nombre_Empresa"]);
                empresa.setCuit((String)row["Cuit"]);
                empresa.setFechaRendicion((DateTime)row["Fecha_Rendicion"]);

                Int32 idDomicilio = (Int32)row["idDomicilio"];
                empresa.setDomicilio(this.getDomiclio(idDomicilio));

                decimal idRubro = (decimal)row["IdRubro"];
                empresa.setRubro(this.getRubro(idRubro));

                empresa.setEstado(Convert.ToInt16(row["Estado_Empresa"]));

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
            cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = 0;

            DBhelper.abrirConexion();

            DBhelper.ejecutarProcedure(cmd);

            DBhelper.cerrarConexion();

        }


        private Model.Domicilio getDomiclio(Int32 id)
        {
            Model.Domicilio domicilio = new Model.Domicilio();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getDomicilio");
            cmd.Parameters.Add("@idDomicilio", SqlDbType.Int).Value = id;

            DataTable tabla = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tabla.Rows)
            {
                domicilio.setId(id);
                domicilio.setCod_Postal((String)row["Cod_Postal"]);
                domicilio.setDireccion((String)row["Direccion"]);
            }

            return domicilio;
        }

        private Model.Rubro getRubro(Decimal id)
        {
            Model.Rubro rubro = new Model.Rubro();

            SqlCommand cmd = DBhelper.crearCommand("qepd.getRubro");
            cmd.Parameters.Add("@idRubro", SqlDbType.Decimal).Value = id;

             DataTable tabla = DBhelper.obtenerTabla(cmd);

             foreach (DataRow row in tabla.Rows)
             {
                 rubro.setNro((decimal)row["Nro_Rubro"]);
                 rubro.setDescripcion((String)row["Descripcion_Rubro"]);
             }

             return rubro;
        }

    }
}
