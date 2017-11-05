using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Login.SeleccionRol
{
    public partial class SeleccionRol : Form
    {

        public String rolSeleccionado;
        public List<Model.Rol> listaDeRoles = Model.Repo_usuario.getInstancia().usuarioIngresado.getListaDeRoles();
        

        public SeleccionRol()
        {
            InitializeComponent();
            configuarComboBox();

        }

        private void selectorDeRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox selectorDeRol = (ComboBox)sender;
            this.rolSeleccionado = (String)selectorDeRol.SelectedValue;

        }

        private void boton_aceptar_rol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Model.Repo_usuario.getInstancia().getUsuario_creado().setRolActivo(rolSeleccionado);
            new Seleccion_funcionalidades().ShowDialog();
            System.Diagnostics.Debug.WriteLine(rolSeleccionado);
            this.Close();
        }

        public void configuarComboBox(){
            this.selectorDeRol.ValueMember = "Nombre";
            this.selectorDeRol.DisplayMember = "Nombre";
            this.selectorDeRol.DataSource = listaDeRoles;
            this.selectorDeRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
