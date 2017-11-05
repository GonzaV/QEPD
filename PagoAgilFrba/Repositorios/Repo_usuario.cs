using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PagoAgilFrba.Model
{
    class Repo_usuario
    {
        public static Rol rolLoco = new Rol("Rol Loco",4);
        public static Rol rolAdmin = new Rol("Administrador", 1);
        public static List<Rol> listaDeRoles = new List<Rol>();
        public static Usuario usuario_creado = new Model.Usuario("a", "a",listaDeRoles);
        public static Repo_usuario instancia;

        public Usuario usuarioIngresado = new Usuario();
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static List<Usuario> listaDeUsuarios = new List<Usuario>();
        

        public static Repo_usuario getInstancia() {

            if (instancia != null)
            {
                return instancia;
            }
            else {
                instancia = new Repo_usuario();
                listaDeRoles.Add(rolLoco);
                listaDeRoles.Add(rolAdmin);
                listaDeUsuarios.Add(usuario_creado);
                return instancia;
            }
        }

        public int validarUsuario(String usuario, String contraseña) {

            
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.validarUsuario");
            cmd.Parameters.Add("@usuarioNombre", SqlDbType.NVarChar).Value = usuario;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = Encriptador.getInstancia().encriptar(contraseña);

            var valorDeRetorno = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            valorDeRetorno.Direction = ParameterDirection.ReturnValue;
          
            DBhelper.abrirConexion();

            DBhelper.obtenerRetornoProcedure(cmd);

            //DBhelper.cerrarConexion();

            return (int)valorDeRetorno.Value;
             
        }

        public Model.Usuario getUsuario(String nombre) {

            DataTable tablaUsuario;

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getUsuario");
            cmd.Parameters.Add("@usuarioNombre", SqlDbType.NVarChar).Value = nombre;

            DBhelper.abrirConexion();

            tablaUsuario = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaUsuario.Rows) {

                usuarioIngresado.setId((int)row["IdUsuario"]);
                usuarioIngresado.setNombre((String)row["Nombre_Usuario"]);
                usuarioIngresado.setEstado((Boolean)row["Estado_Usuario"]);
            
            }

            usuarioIngresado.setListaDeRoles(getRoles(usuarioIngresado.getId()));

            return usuarioIngresado;

        }

        public List<Model.Rol> getRoles(int idUsuario) {

            DataTable tablaRoles;
            List<Model.Rol> listaDeRoles = new List<Model.Rol>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getRoles");
            cmd.Parameters.Add("@IdUsuario", SqlDbType.NVarChar).Value = idUsuario;

            DBhelper.abrirConexion();

            tablaRoles = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaRoles.Rows) {

                Rol rol = new Rol();

                rol.setNombre((String)row["Nombre_Rol"]);
                rol.setId((Int32)row["IdRol"]);
                rol.setEstado(Convert.ToInt16(row["Estado_Rol"]));
                
                listaDeRoles.Add(rol);
            }

            return listaDeRoles;

        }



        public void agregarUsuarioALista(Usuario usuarioNuevo) {

            listaDeUsuarios.Add(usuarioNuevo);
        
        }

        public void setUsuario_creado(Usuario usuario)
        {
            usuario_creado = usuario;
        }

        public Usuario getUsuario_creado() {

            return usuario_creado;
        
        }

        public String obtenerNombreDeUsuarioCreado(){

            return usuario_creado.getNombre();

        }

        public String obtenerPasswordUsuarioCreado() {

            return usuario_creado.getPassword();

        }

        public List<Model.Rol> obtenerRolesUsuarioCreado() { 
        
            return usuario_creado.getListaDeRoles();
        
        }

        public List<Model.Usuario> getListaDeUsuarios()
        {

            return listaDeUsuarios;

        }

    }

}
