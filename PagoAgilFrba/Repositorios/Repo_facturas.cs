using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

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

        public void crearFactura(List<Model.ItemFactura> items, decimal nroFactura, Model.Cliente cliente, Model.Empresa empresa, String fec_Baja)
        {
            DBhelper.crearConexion();

            DBhelper.abrirConexion();

            foreach(Model.ItemFactura i in items)
            {
                 this.crearItemFactura(i, nroFactura);
            }

            SqlCommand cmd = DBhelper.crearCommand("QEPD.newFactura");
            cmd.Parameters.Add("@nroFactura", SqlDbType.Decimal).Value = Convert.ToDecimal(nroFactura);
            cmd.Parameters.Add("@fecha_vto", SqlDbType.DateTime).Value = Convert.ToDateTime(fec_Baja);
            /*cmd.Parameters.Add("@idEmpresa", SqlDbType.Int).Value = empresa.getId();*/      /////////////////////////getId agregar
            cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = cliente.getId();

            cmd.ExecuteNonQuery();
           
            DBhelper.cerrarConexion();
        }

        private void crearItemFactura(Model.ItemFactura item, decimal nroFactura)
        {
            String descripcion = item.getDescripcion();
            decimal cantidad = item.getCantidad();
            decimal monto = item.getMonto();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.newRenglonFactura");
            cmd.Parameters.Add("@idFactura", SqlDbType.Decimal).Value = Convert.ToDecimal(nroFactura);
            cmd.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = Convert.ToDecimal(cantidad);
            cmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = Convert.ToDecimal(monto);
            cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = descripcion;

            cmd.ExecuteNonQuery();
        }
    }
}
