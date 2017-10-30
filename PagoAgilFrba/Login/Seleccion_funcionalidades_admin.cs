using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Login
{
    public partial class Seleccion_funcionalidades_admin : Form
    {
        public Seleccion_funcionalidades_admin()
        {
            InitializeComponent();
        }

        private void boton_abm_rol_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ABM_Rol.Seleccion_accion_abm_rol().ShowDialog();
            this.Close();
        }

        private void button_abm_empresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ABM_Empresa.abm_empresa().ShowDialog();
            this.Close();
        }


    }
}
