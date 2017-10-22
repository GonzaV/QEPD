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

        public List<Model.Rol> listaDeRoles = Model.Repo_usuario.getInstancia().obtenerRolesUsuario();
        

        public SeleccionRol()
        {
            InitializeComponent();
            this.selectorDeRol.DataSource = listaDeRoles;
            this.selectorDeRol.DisplayMember = "Nombre";
            //this.selectorDeRol.ValueMember = "id";
            this.selectorDeRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void selectorDeRol_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Seleccion_funcionalidades().ShowDialog();
            this.Close();
        }
    }
}
