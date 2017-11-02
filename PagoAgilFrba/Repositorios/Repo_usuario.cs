using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    class Repo_usuario
    {
        public static Rol rolLoco = new Rol("Rol Loco",4);
        public static Rol rolAdmin = new Rol("Administrador", 1);
        public static List<Rol> listaDeRoles = new List<Rol>();
        public static Usuario usuario_creado = new Model.Usuario("a", "a",listaDeRoles);
        public static Repo_usuario instancia;

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

        public void agregarUsuario(Usuario usuarioNuevo) {

            listaDeUsuarios.Add(usuarioNuevo);
        
        }

        public void setUsuario(Usuario usuario)
        {
            usuario_creado = usuario;
        }

        public Usuario getUsuario() {

            return usuario_creado;
        
        }

        public String obtenerNombreDeUsuarioLoggeado(){

            return usuario_creado.getNombre();

        }

        public String obtenerPasswordUsuario() {

            return usuario_creado.getPassword();

        }

        public List<Model.Rol> obtenerRolesUsuario() { 
        
            return usuario_creado.getListaDeRoles();
        
        }

        public List<Model.Usuario> getListaDeUsuarios()
        {

            return listaDeUsuarios;

        }

    }

}
