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
       public Int16 estado;
       private List<Funcionalidad> listaDeFuncionalidades = new List<Funcionalidad>();

       public Rol(String nombre, Int32 id){

           setNombre(nombre);
           setId(id);
           setEstado(1);

        }

       public Rol() { }


       public String getNombre()
       {
           return this.nombre;
       }


       public string Nombre //Este metodo es el que usa el selector para mostrar los nombres del objeto,
                            //quiza se pueda borrar el otro getter
       {

           get
           {
               return nombre;
           }
       }


       public Rol Objeto

       {

           get
           {
               return this;
           }
       }


       public Int32 Id//Este metodo es el que usa el selector para el id del rol luego de clickear su nombre,
                        //quiza se pueda borrar el otro getter
       {

           get
           {
               return id;
           }
       }


       public Int32 getId()
        {
            return this.id;
        }

       public Int16 getEstado()
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

       public void setEstado(Int16 estado) {

           this.estado = estado;

       }
       

        
    }
}
