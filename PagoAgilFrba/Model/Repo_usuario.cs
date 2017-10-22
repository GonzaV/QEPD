using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    class Repo_usuario
    {
        public static Rol rolNuevo = new Rol("Rol Loco",4);
        public static List<Rol> listaDeRoles = new List<Rol>();
        public Usuario usuario_creado = new Model.Usuario("a", "a",listaDeRoles);
        public static Repo_usuario instancia;

        public static Repo_usuario getInstancia() {

            if (instancia != null)
            {
                return instancia;
            }
            else {
               
                instancia = new Repo_usuario();
                listaDeRoles.Add(rolNuevo);
                return instancia;
            }
        }

        public void setUsuario(Usuario usuario)
        {
            usuario_creado = usuario;
        }

        public Usuario getUsuario() {

            return this.usuario_creado;
        
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

    }

}
