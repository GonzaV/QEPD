using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Empresa
    {
        private Int32 id;
        private String nombre;
        private String cuit;
        private String fecha_Rendicion;
        private Domicilio domicilio;
        private Rubro rubro;
        private Int16 estado;

        public Int32 getId()
        {
            return id;
        }

        public String getNombre()
        {
            return nombre;
        }

        public String getCuit()
        {
            return cuit;
        }

        public String getFechaRendicion()
        {
            return fecha_Rendicion;
        }

        public Domicilio getDomicilio()
        {
            return domicilio;
        }

        public Rubro getRubro()
        {
            return rubro;
        }

        public Int16 getEstado()
        {
            return estado;
        }

        public void setId(Int32 id)
        {
            this.id = id;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setCuit(String cuit)
        {
            this.cuit = cuit;
        }

        public void setFechaRendicion(String fecha)
        {
            this.fecha_Rendicion = fecha;
        }

        public void setDomicilio(Domicilio domicilio)
        {
            this.domicilio = domicilio;
        }

        public void setRubro(Rubro rubro)
        {
            this.rubro = rubro;
        }

        public void setEstado(Int16 estado)
        {
            this.estado = estado;
        }



    }
}
