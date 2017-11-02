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

        public Usuario usuarioIngresado {get; set;}
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

            SqlCommand cmd = DBhelper.crearCommand("validarUsuario");
            cmd.Parameters.Add(usuario, contraseña);

            DBhelper.abrirConexion();

            return (int)DBhelper.obtenerReader(cmd);
             
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
