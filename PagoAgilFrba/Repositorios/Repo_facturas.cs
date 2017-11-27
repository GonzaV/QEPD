using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Repositorios
{
    public class Repo_facturas
    {
        private static Repo_facturas instancia;

        public static Repo_facturas getInstancia(){
            if (instancia != null)
            {
                instancia = new Repo_facturas();
            }
            return instancia;
        }

        private Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public void crearFactura(List<Model.ItemFactura> items, decimal nroFactura, Model.Cliente cliente, Model.Empresa empresa, String fec_Alta, String fec_Baja)
        {
            DBhelper.crearConexion();



            DBhelper.cerrarConexion();
        }

        private void crearItemFactura(Model.ItemFactura item, decimal nroFactura)
        {
            ;
        }
    }
}
