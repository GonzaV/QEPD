using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Cliente
{
    public partial class abm_cliente : Form
    {

        
        public Model.Cliente clienteSeleccionado;

        public abm_cliente()
        {
            InitializeComponent();
            configurarComboBox();
        }

        private void comboBox_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox_clientes = (ComboBox)sender;
            this.clienteSeleccionado = (Model.Cliente)comboBox_clientes.SelectedValue;
            Model.Repo_cliente.getInstancia().setClienteSeleccionado(this.clienteSeleccionado);
        }

        public void configurarComboBox() {

            this.comboBox_clientes.ValueMember = "Objeto";
            this.comboBox_clientes.DisplayMember = "Nombre";
            this.comboBox_clientes.DataSource = Model.Repo_cliente.getInstancia().getClientes();
            this.comboBox_clientes.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void boton_crear_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Crear_cliente().ShowDialog();
            this.Close();
        }

        private void boton_modificar_cliente_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Modificar_cliente().ShowDialog();

        }
    }
}
