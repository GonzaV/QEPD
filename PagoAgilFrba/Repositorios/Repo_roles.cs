using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Repositorios
{
    class Repo_roles
    {

        public static Repo_roles instancia;

        public static Repo_roles getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_roles();
                return instancia;
            }
        }





    }
}
