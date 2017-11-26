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
    public partial class Agregar_funcionalidad : Form
    {

        public Model.Funcionalidad funcionalidadSeleccionada;
        public List<Model.Funcionalidad> listaFunc = Repositorios.Repo_roles_func.getInstancia().getFuncionalidades();
        public List<Model.Funcionalidad> listaFuncRolActual = Repositorios.Repo_roles_func.getInstancia().getFuncionalidadesDelRol();
        public List<Model.Funcionalidad> listaFuncDisponibles = new List<Model.Funcionalidad>();


        public Agregar_funcionalidad()
        {

            InitializeComponent();
            listaFuncDisponibles = listaFunc.Except(listaFuncRolActual).ToList(); //NO ESTA FUNCIONANDO EL EXCEPT, HAY QUE HACER FOR EACH
            configuarComboBox();

        }

        private void boton_agregar_funcionalidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad agregada, agregue más o precione 'Hecho'", "Funcionalidad agregada", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public void configuarComboBox()
        {
            this.selector_de_funcionalidad.ValueMember = "Objeto";
            this.selector_de_funcionalidad.DisplayMember = "Nombre";
            this.selector_de_funcionalidad.DataSource = listaFuncDisponibles;
            this.selector_de_funcionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void selector_de_funcionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectorDeRol = (ComboBox)sender;
            this.funcionalidadSeleccionada = (Model.Funcionalidad)selector_de_funcionalidad.SelectedValue;
        }

    }
}
