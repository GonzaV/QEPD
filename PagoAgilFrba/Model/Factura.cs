using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class Factura
    {
        private List<ItemFactura> items = new List<ItemFactura>();

        private decimal nroFactura;
        private Cliente cliente;
        private Empresa empresa;
        private String fec_Alta;
        private String fec_Baja;

        public Factura(List<ItemFactura> items, decimal nroFactura, Cliente cliente, Empresa empresa, String fec_Alta, String fec_Baja)
        {
            this.items = items;
            this.nroFactura = nroFactura;
            this.cliente = cliente;
            this.empresa = empresa;
            this.fec_Alta = fec_Alta;
            this.fec_Baja = fec_Baja;
        }
    }
}
