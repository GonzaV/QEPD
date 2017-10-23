using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Usuario
    {
        public String nombre;
        public String password;
        public Int32 id;
        public Boolean estado;
        public List<Rol> listaDeRoles = new List<Rol>();
        public String rolActivo;

        public Usuario(String nombre, String password, List<Rol> listaDeRoles) {

            this.nombre = nombre;
            this.password = password;
            this.listaDeRoles = listaDeRoles;
        
        }

        public String getRolActivo() {

            return this.rolActivo;

        }

        public void setRolActivo(String rolActivo){

            this.rolActivo = rolActivo;

        }

        public String getNombre() {

            return this.nombre;

        }

        public String getPassword() {

            return this.password;

        }

        public List<Rol> getListaDeRoles() { 
        
            return this.listaDeRoles;

        }

    }
}
