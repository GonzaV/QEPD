using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Repositorios
{
    class Repo_facturas
    {
        private static Repo_facturas instancia;

        public static Repo_facturas getInstancia(){
            if (instancia != null)
            {
                instancia = new Repo_facturas();
            }
            return instancia;
        }
    }
}
