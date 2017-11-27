using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Rubro
    {

        public String descripcion;
        public decimal nro_rubro;

        public Rubro()
        {

        }

        public Rubro(String descripcion, decimal nro_rubro)
        {

            this.descripcion = descripcion;
            this.nro_rubro = nro_rubro;

        }

        public void setDescripcion(String descripcion)
        {

            this.descripcion = descripcion;

        }

        public void setNro(decimal nro)
        {

            this.nro_rubro = nro;

        }

        public String getDescripcion()
        {

            return descripcion;

        }

        public Rubro Objeto //Este metodo es el que usa el selector para seleccionar el objeto,
        {

            get
            {
                return this;
            }
        }

        public String Descripcion //Este metodo es el que usa el selector para mostrar los nombres del objeto
        {

            get
            {
                return descripcion;
            }
        }

    }
}
