using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace PagoAgilFrba.ABM_Empresa
{
    public partial class Modificar_empresa : Form
    {

        const String HABILITADO = "True";
        const String INHABILITADO = "False";

        public Modificar_empresa()
        {
            InitializeComponent();
            configurarComboBox();
            configurarCheckBoxes();
        }

        private void boton_modificar_empresa_Click(object sender, EventArgs e)
        {
            Repositorios.Repo_empresas.getInstancia().modificarEmpresa(textBox_nombre.Text, textBox_cuit.Text, textBox_direccion.Text, (String)comboBox_rubros.SelectedValue);
            MessageBox.Show("Empresa modificada con éxito", "Empresa modificada", MessageBoxButtons.OK);
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Listado_seleccion_empresas().ShowDialog();
            this.Close();
        }

        public void configurarComboBox()
        {

            this.comboBox_rubros.ValueMember = "Descripcion";
            this.comboBox_rubros.DisplayMember = "Descripcion";
            this.comboBox_rubros.DataSource = Repositorios.Repo_empresas.getInstancia().getRubros();
            this.comboBox_rubros.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public void configurarCheckBoxes()
        {


            if (Repositorios.Repo_empresas.getInstancia().getEstadoEmpresa().ToString() == HABILITADO)

            {

                checkBox_habilitar.Enabled = false;

            }

            else checkBox_inhabilitar.Enabled = false;

        }
        
    }
}
