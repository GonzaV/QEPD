using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Usuario
    {
        public String nombre;
        public String password;
        public Int32 id;
        public Boolean estado;
        public List<Rol> listaDeRoles = new List<Rol>();

    }
}
