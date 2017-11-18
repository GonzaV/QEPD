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
   public class Repo_roles_func
    {

        public Model.Rol rolSeleccionado;
        public static Repo_roles_func instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_roles_func getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_roles_func();
                return instancia;
            }
        }

        public List<Model.Rol> getRoles() {

            DataTable tablaRoles;
            List<Model.Rol> listaDeRoles = new List<Model.Rol>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getRoles");

            DBhelper.abrirConexion();

            tablaRoles = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaRoles.Rows)
            {

                Model.Rol rol = new Model.Rol();

                rol.setNombre((String)row["Nombre_Rol"]);
                rol.setId((Int32)row["IdRol"]);
                rol.setEstado(Convert.ToInt16(row["Estado_Rol"]));

                listaDeRoles.Add(rol);
            }

            return listaDeRoles;

        }

        public List<Model.Funcionalidad> getFuncionalidadesDelRol()
        {

            DataTable tablaFuncRol;
            List<Model.Funcionalidad> listaDeFunc = new List<Model.Funcionalidad>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getFuncionalidadesDeUnRol");
            cmd.Parameters.Add("@rolId", SqlDbType.Int).Value = rolSeleccionado.getId();

            DBhelper.abrirConexion();

            tablaFuncRol = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaFuncRol.Rows)
            {

                Model.Funcionalidad funcionalidad = new Model.Funcionalidad();

                funcionalidad.setNombre((String)row["Nombre_Funcionalidad"]);
                funcionalidad.setId((Int32)row["IdFuncionalidad"]);


                listaDeFunc.Add(funcionalidad);
            }

            return listaDeFunc;

        }

        public void modificarNombreRol(String nuevoNombre) {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.modificarRol");
            cmd.Parameters.Add("@rolId", SqlDbType.Int).Value = rolSeleccionado.getId();
            cmd.Parameters.Add("@rolNombreNuevo", SqlDbType.NVarChar).Value = nuevoNombre;

            DBhelper.abrirConexion();

            DBhelper.obtenerRetornoProcedure(cmd);

            DBhelper.cerrarConexion();
        
        }

        public void inhabilitarRol() {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.eliminarRol");
            cmd.Parameters.Add("@rolId", SqlDbType.Int).Value = rolSeleccionado.getId();

            DBhelper.abrirConexion();

            DBhelper.obtenerRetornoProcedure(cmd);

            DBhelper.cerrarConexion();
        
        }

        public void habilitarRol()
        {

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.habilitarRol");
            cmd.Parameters.Add("@rolId", SqlDbType.Int).Value = rolSeleccionado.getId();

            DBhelper.abrirConexion();

            DBhelper.obtenerRetornoProcedure(cmd);

            DBhelper.cerrarConexion();

        }

        public List<Model.Funcionalidad> getFuncionalidades()
        {

            DataTable tablaFuncionalidades;
            List<Model.Funcionalidad> listaFuncionalidades = new List<Model.Funcionalidad>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getFuncionalidades");

            DBhelper.abrirConexion();

            tablaFuncionalidades = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaFuncionalidades.Rows)
            {

                Model.Funcionalidad funcionalidad = new Model.Funcionalidad();

                funcionalidad.setNombre((String)row["Nombre_Funcionalidad"]);
                funcionalidad.setId((Int32)row["IdFuncionalidad"]);
                

                listaFuncionalidades.Add(funcionalidad);
            }

            return listaFuncionalidades;

        }

        public void setRolSeleccionado(Model.Rol rol) {

            this.rolSeleccionado = rol;
        
        }

        public Model.Rol getRolSeleccionado() {

            return this.rolSeleccionado;
        
        }



    }
}
