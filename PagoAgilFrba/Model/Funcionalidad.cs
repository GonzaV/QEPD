using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{

    public class Funcionalidad
    {

        public String nombre;
        public Int32 id;

        public Funcionalidad() { }

        public void setNombre(String nombre) {

            this.nombre = nombre;
        
        }

        public void setId(Int32 id) {

            this.id = id;
        
        }

        public string Nombre 
        {

            get
            {
                return nombre;
            }
        }


        public Funcionalidad Objeto
        {

            get
            {
                return this;
            }
        }
    }
}
