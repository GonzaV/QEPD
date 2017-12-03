using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model{

    public class Domicilio{

        public String direccion;
        public String cod_postal;
        private Int32 id;


        public String getDireccion()
        {

            return this.direccion;
        }

        public String getCod_postal()
        {

            return this.cod_postal;
        }

        public Int32 getId()
        {
            return this.id;
        }

        public void setId(Int32 id)
        {
            this.id = id;
        }

        public void setCod_Postal(String cod_postal)
        {
            this.cod_postal = cod_postal;
        }

        public void setDireccion(String direccion)
        {
            this.direccion = direccion;
        }
    }
}
