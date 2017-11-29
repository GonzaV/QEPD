using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Facturas_y_RegistrosDePago
{
    public partial class Crear_o_cobrar_facturas : Form, ABM_Empresa.Listado_Empresa_Observer, ABM_Cliente.Listado_Clientes_Observer
    {
        private Model.Factura_builder facturaBuilder;

        public Crear_o_cobrar_facturas(Model.Factura_builder facturaBuilder)
        {
            InitializeComponent();
            this.facturaBuilder = facturaBuilder;
        }

        private void boton_ingresar_items_Click(object sender, EventArgs e)
        {
            new Agregar_items(this).ShowDialog();
        }

        private void boton_crear_factura_Click(object sender, EventArgs e)
        {
            Model.Empresa empresaObj = Repositorios.Repo_empresas.getInstancia().getEmpresa(empresa.Text);
            Model.Cliente clienteObj = Model.Repo_cliente.getInstancia().getCliente(Convert.ToInt32(cliente.Text));
            facturaBuilder.build(numericUpDown1.Value, clienteObj, empresaObj, dateTimePicker2.Text);
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.Seleccion_funcionalidades().ShowDialog();
            this.Close();
        }

        public void setfacturaBuilder(Model.Factura_builder facturaBuilder)
        {
            this.facturaBuilder = facturaBuilder;
        }

        public Model.Factura_builder getfacturaBuilder()
        {
            return this.facturaBuilder;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ABM_Cliente.Listado_seleccion_clientes listado = new ABM_Cliente.Listado_seleccion_clientes();
            listado.setController(this);
            listado.ShowDialog();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            ABM_Empresa.Listado_seleccion_empresas listado = new ABM_Empresa.Listado_seleccion_empresas();
            listado.setController(this);
            listado.ShowDialog();
        }

        public void mostrarEmpresaElegidad(String empresaElegida)
        {
            this.empresa.Text = empresaElegida;
        }

        public void mostrarClienteElegido(String clienteElegido)
        {
            this.cliente.Text = clienteElegido;
        }

        public void modificarLabelTotal(String total)
        {
            this.label_total.Text = total;
        }
    }
}
