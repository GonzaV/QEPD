using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model{

    public class Domicilio{

        public String direccion;
        public String cod_postal;



        
        //getters

        public String getDireccion(){
            
            return this.direccion;
        }

        public String getCod_postal()
        {

            return this.cod_postal;
        }
    }
}
