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
    public partial class Modificar_rol : Form
    {

        public const Int16 HABILITADO = 1;
        public const String CHECKED = "True";

        public Modificar_rol()
        {
            InitializeComponent();
            configurarCheckBoxes();
        }

        private void boton_agregar_funcionalidad_Click(object sender, EventArgs e)
        {
            new Agregar_funcionalidad().ShowDialog();
        }

        private void boton_eliminar_funcionalidad_Click(object sender, EventArgs e)
        {
            new Quitar_funcionalidad().ShowDialog();
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {
            Repositorios.Repo_roles_func.getInstancia().modificarNombreRol(textBox_nombre.Text);
            
            if(checkBox_inhabilitar.Checked.ToString() == CHECKED)
            {

                Repositorios.Repo_roles_func.getInstancia().inhabilitarRol();

            }
        }

        public void configurarCheckBoxes() {

            if (Repositorios.Repo_roles_func.getInstancia().getRolSeleccionado().getEstado() == HABILITADO)
            {

                checkBox_habilitar.Enabled = false;

            }

            else checkBox_inhabilitar.Enabled = false;
        
        }

    }
}
