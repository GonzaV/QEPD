using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
   public class Sucursal
    {

       public decimal codigo_postal;
       public String direccion;
       public String nombre;

       public Sucursal() { }

       public void setCodigo_postal(decimal cp) {

           this.codigo_postal = cp;
       
       }

       public void setDireccion(String direccion) {

           this.direccion = direccion;
       
       }

       public void setNombre(String nombre) {

           this.nombre = nombre;

       }

    }
}
