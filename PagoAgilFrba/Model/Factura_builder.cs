using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Factura_builder
    {
        private List<ItemFactura> items = new List<ItemFactura>();

        public void agregarItemFactura(String descripcion, decimal cantidad, decimal monto)
        {
            items.Add(new ItemFactura(descripcion, cantidad, monto));
        }
      
       public void build(decimal nroFactura, Cliente cliente, Empresa empresa, String fec_Alta, String fec_Baja)
       {
           using (System.Transactions.TransactionScope updateTransaction =
           new System.Transactions.TransactionScope())
           {
               Repositorios.Repo_facturas.getInstancia().crearFactura(items, nroFactura, cliente, empresa, fec_Alta, fec_Baja);
               updateTransaction.Complete();
           }
           
       }
    }
}
