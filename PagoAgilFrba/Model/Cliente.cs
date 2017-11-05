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
        public DateTime fecha_nac;
        public String email;
        public Int32 telefono;
        public Int32 estado;
        public Domicilio domicilio;


        //getters
        public String getNombre(){

            return this.nombre;

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

        public DateTime getFecha_nac(){

            return this.fecha_nac;

        }
        public String getEmail(){

            return this.email;

        }

        public Int32 getTelefono(){

            return this.telefono;

        }

        public Int32 getEstado(){

            return this.estado;

        }

        public Domicilio getDomicilio(){

            return this.domicilio;
        }

    }
    
}
