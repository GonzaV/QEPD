using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Rol
    {

       public String nombre;
       public Int32 id;
       public Boolean estado;

       public void rol(String nombre, Int32 id){

           setNombre(nombre);
           setId(id);
           setEstado(true);

        }


       public String getNombre()
       {
           return this.nombre;
       }

       public Int32 getId()
        {
            return this.id;
        }

       public Boolean getEstado()
        {
            return this.estado;
        }

       public void setNombre(String nombre)
       {
           this.nombre = nombre;
       }

       public void setId(Int32 id) {

           this.id = id;

       }

       public void setEstado(Boolean estado) {

           this.estado = estado;

       }
       

        
    }
}
