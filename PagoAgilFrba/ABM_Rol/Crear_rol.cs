using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Rol
{
    public partial class Crear_rol : Form
    {
        public Model.Funcionalidad funcionalidadSeleccionada;
        public List<Model.Funcionalidad> funcionalidadesDisponibles = Repositorios.Repo_roles_func.getInstancia().getFuncionalidades();
        public List<Model.Funcionalidad> funcionalidadesAgregadas = new List<Model.Funcionalidad>();

        public Crear_rol()
        {
            InitializeComponent();
            configurarComboBox();
        }

        private void boton_agregar_funcionalidad_Click(object sender, EventArgs e)
        {
            funcionalidadesAgregadas.Add(funcionalidadSeleccionada);
            funcionalidadesDisponibles.Remove(funcionalidadSeleccionada);
            MessageBox.Show("Funcionalidad agregada, seleccione otra o cree el rol", "Funcionalidad agregada", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public void configurarComboBox()
        {

            this.comboBox_funcionalidades.ValueMember = "Objeto";
            this.comboBox_funcionalidades.DisplayMember = "Nombre";
            this.comboBox_funcionalidades.DataSource = funcionalidadesDisponibles;
            this.comboBox_funcionalidades.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void comboBox_funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectorDeFuncionalidad = (ComboBox)sender;
            funcionalidadSeleccionada = (Model.Funcionalidad)selectorDeFuncionalidad.SelectedValue;
        }

    }
}
