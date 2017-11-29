using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Repositorios
{
    class RepoPagos
    {
        private static RepoPagos instancia;

        public static RepoPagos getInstancia()
        {
            if (instancia != null)
            {
                instancia = new RepoPagos();
            }
            return instancia;
        }

        private Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();


    }
}
