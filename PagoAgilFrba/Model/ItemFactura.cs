using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Model
{
    public class ItemFactura
    {
        private String descripcion;

        private decimal cantidad;

        private decimal monto;
  

        public ItemFactura(String descripcion, decimal cantidad, decimal monto)
        {
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.monto = monto;
        }

        public String getDescripcion()
        {
            return descripcion;
        }

        public decimal getCantidad()
        {
            return cantidad;
        }

        public decimal getMonto()
        {
            return monto;
        }



    }
}
