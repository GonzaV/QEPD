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
    public partial class abm_rol : Form
    {

        public Model.Rol rolSeleccionado;

        public abm_rol()
        {
            
            InitializeComponent();
            configurarComboBox();
            
        }

        private void boton_crear_rol_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Crear_rol().ShowDialog();
            this.Close();
        }

        private void boton_modificar_rol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Repositorios.Repo_roles.getInstancia().setRolSeleccionado(rolSeleccionado);
            new Modificar_rol().ShowDialog();
            this.Close();
        }

        private void comboBox_roles_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox selectorDeRol = (ComboBox)sender;
            rolSeleccionado = (Model.Rol)selectorDeRol.SelectedValue;

        }

        public void configurarComboBox() {

            this.comboBox_roles.ValueMember = "Objeto";
            this.comboBox_roles.DisplayMember = "Nombre";
            this.comboBox_roles.DataSource = Repositorios.Repo_roles.getInstancia().getRoles();
            this.comboBox_roles.DropDownStyle = ComboBoxStyle.DropDownList;
        
        }
    }
}
