using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.ABM_Empresa
{
    public interface Listado_Empresa_Observer
    {
        void mostrarEmpresaElegidad(String empresaElegida);
        void setIdEmpresa(Int32 id);

   
    }
}
