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

        public List<Model.Usuario> listaDeUsuarios = Model.Repo_usuario.getInstancia().getListaDeUsuarios();
        public Model.Usuario usuarioSeleccionado;

        public abm_cliente()
        {
            InitializeComponent();
            configurarComboBox();
        }

        private void comboBox_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox comboBox_clientes = (ComboBox)sender;
            this.usuarioSeleccionado = (Model.Usuario)comboBox_clientes.SelectedValue;
            
        }

        public void configurarComboBox() {

            this.comboBox_clientes.ValueMember = "ObjetoUsuario";
            this.comboBox_clientes.DisplayMember = "Nombre";
            this.comboBox_clientes.DataSource = listaDeUsuarios;
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
