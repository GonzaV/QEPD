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
        private decimal dniCliente;
        private Int32 idEmpresa;
        private DataTable dataTable;

        public Crear_o_cobrar_facturas(Model.Factura_builder facturaBuilder)
        {
            InitializeComponent();
            this.facturaBuilder = facturaBuilder;
            this.iniciarDataTable();
        }


        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.Seleccion_funcionalidades().ShowDialog();
            this.Close();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            
            ABM_Empresa.Listado_seleccion_empresas listado = new ABM_Empresa.Listado_seleccion_empresas();
            listado.setController(this);
            listado.ocultarBtnModificar();
            listado.ocultarBtnEliminar();
            listado.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ABM_Cliente.Listado_seleccion_clientes listado = new ABM_Cliente.Listado_seleccion_clientes();
            listado.setController(this);
            listado.ocultarBtnModificar();
            listado.ocultarBtnEliminar();
            listado.ShowDialog();
        }

        private void boton_crear_factura_Click(object sender, EventArgs e)
        {
            Model.Empresa empresaObj = Repositorios.Repo_empresas.getInstancia().getEmpresa(idEmpresa);
            Model.Cliente clienteObj = Model.Repo_cliente.getInstancia().getCliente(dniCliente);
            facturaBuilder.build(numericUpDown1.Value, clienteObj, empresaObj, dateTimePicker2.Value);
     
        }

        private void boton_ingresar_items_Click(object sender, EventArgs e)
        {
            new Agregar_items(this).ShowDialog();
        }




        public void mostrarEmpresaElegidad(String empresaElegida)
        {
            //this.empresa.Enabled = true;
            this.empresa.Text = empresaElegida;
        }

        public void mostrarClienteElegido(String clienteElegido)
        {
            //this.cliente.Enabled = true;
            this.cliente.Text = clienteElegido;
        }

        public void modificarLabelTotal(String total)
        {
            this.label_total.Text = total;
        }

        public void agregarFilaGrid(String des, decimal cant, decimal monto)
        {
            DataRow row = dataTable.NewRow();
            row["Descripcion"] = des;
            row["Cantidad"] = cant;
            row["Monto"] = monto;

            dataTable.Rows.Add(row);
            dataGridView1.DataSource = dataTable;
        }

        private void iniciarDataTable()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("Descripcion", typeof(String));
            dataTable.Columns.Add("Cantidad", typeof(decimal));
            dataTable.Columns.Add("Monto", typeof(decimal));
        }




        public void setfacturaBuilder(Model.Factura_builder facturaBuilder)
        {
            this.facturaBuilder = facturaBuilder;
        }

        public Model.Factura_builder getfacturaBuilder()
        {
            return this.facturaBuilder;
        }

        public void setIdEmpresa(Int32 id)
        {
            this.idEmpresa = id;
        }

        public void setDniCliente(decimal dni)
        {
            this.dniCliente = dni;
        }

        public DataTable getDataTable()
        {
            return dataTable;
        }

        public void setDataTable(DataTable dt)
        {
            this.dataTable = dt;
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

      

    
    }
}
