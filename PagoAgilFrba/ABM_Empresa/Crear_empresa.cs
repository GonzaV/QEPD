using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Empresa
{
    public partial class Crear_empresa : Form
    {

        public Model.Rubro rubroSeleccionado;

        public Crear_empresa()
        {
            InitializeComponent();
            configuarComboBox();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new abm_empresa().ShowDialog();
            this.Close();
        }

        private void comboBox_rubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectorDeRubro = (ComboBox)sender;
            rubroSeleccionado = (Model.Rubro)selectorDeRubro.SelectedValue;
        }


        public void configuarComboBox()
        {
            this.comboBox_rubro.ValueMember = "Objeto";
            this.comboBox_rubro.DisplayMember = "Descripcion";
            this.comboBox_rubro.DataSource = Repositorios.Repo_empresas.getInstancia().getRubros();
            this.comboBox_rubro.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void boton_crear_empresa_Click(object sender, EventArgs e)
        {
            Repositorios.Repo_empresas.getInstancia().crearEmpresa(textBox_nombre.Text, textBox_CUIT.Text, textBox_direccion.Text, rubroSeleccionado.getDescripcion());
            MessageBox.Show("Empresa creada con éxito", "Empresa creada", MessageBoxButtons.OK);
        }
    }
}
