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
        public Int16 estado;
        public List<Rol> listaDeRoles = new List<Rol>();
        public String rolActivo;

        public Usuario(String nombre, String password, List<Rol> listaDeRoles) {

            this.nombre = nombre;
            this.password = password;
            this.listaDeRoles = listaDeRoles;
        
        }

        public Usuario()
        {


        }

        public String getRolActivo() {

            return this.rolActivo;

        }

        public Usuario ObjetoUsuario //Este metodo es el que usa el selector para seleccionar el objeto,
                                    
        {

            get
            {
                return this;
            }
        }

        public String Nombre //Este metodo es el que usa el selector para mostrar los nombres del objeto
        {

            get
            {
                return nombre + " " + "Id:" + id;
            }
        }

        public void setRolActivo(String rolActivo){

            this.rolActivo = rolActivo;

        }

        public void setNombre(String nombre) {

            this.nombre = nombre;
        
        }

        public void setPassword(String psw)
        {

            this.password = psw;

        }

        public void setId(Int32 id)
        {

            this.id = id;

        }

        public Int32 getId() {

            return this.id;
        
        }

        public void setEstado(Int16 estado) {

            this.estado = estado;
        
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

        public void setListaDeRoles(List<Rol> listaDeRoles) {

            this.listaDeRoles = listaDeRoles;
        
        }

    }
}
