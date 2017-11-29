using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.ABM_Cliente
{
    public interface Listado_Clientes_Observer
    {
        void mostrarClienteElegido(String clienteElegido);
    }
}
