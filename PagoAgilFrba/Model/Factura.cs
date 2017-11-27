using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    class Factura
    {
        private List<ItemFactura> items = new List<ItemFactura>();

        private decimal nroFactura;
        private Cliente cliente;
        private Empresa empresa;
        private String fec_Alta;
        private String fec_Baja;
    }
}
