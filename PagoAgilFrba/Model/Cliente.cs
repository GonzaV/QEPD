using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model{

    public class Cliente{

        public String nombre;
        public String apellido;
        public Int32 id;
        public Int32 dni;
        public DateTime fnacimiento;
        public String email;
        public Int32 telefono;
        public Int16 estado;
        public Domicilio domicilio;
       


        //getters
        public String getNombre(){

            return this.nombre;

        }

        public String Nombre 
        {

            get
            {
                return nombre + " " + apellido ;
            }
        }

        public Cliente Objeto
        {

            get
            {
                return this;
            }
        }

        public String getApellido(){

            return this.apellido;

        }

        public Int32 getId(){

            return this.id;

        }

        public Int32 getDni(){

            return this.dni;

        }

        public DateTime getFnacimiento(){

            return this.fnacimiento;

        }
        public String getEmail(){

            return this.email;

        }

        public Int32 getTelefono(){

            return this.telefono;

        }

        public Int16 getEstado(){

            return this.estado;

        }

        public Domicilio getDomicilio(){

            return this.domicilio;
        }

        //SETTERS

        public void setNombre(String nombre)
        {

            this.nombre = nombre;

        }

        public void setApellido(String apellido)
        {

            this.apellido = apellido;

        }

        public void setId(Int32 id)
        {

            this.id = id;

        }

        public void setDni(Int32 dni)
        {

            this.dni = dni;

        }

        public void setFnacimiento(DateTime fnacimiento)
        {

            this.fnacimiento = fnacimiento;

        }
        public void setEmail(String email)
        {

            this.email = email;

        }

        public void setTelefono(Int32 telefono)
        {

            this.telefono = telefono;

        }

        public void setEstado(Int16 estado)
        {

            this.estado = estado;

        }

        public void setDomicilio(Domicilio domicilio)
        {

            this.domicilio = domicilio;

        }

    }
    
}
