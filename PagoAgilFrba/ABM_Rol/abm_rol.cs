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
        public abm_rol()
        {
            InitializeComponent();
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
            new Modificar_rol().ShowDialog();
            this.Close();
        }
    }
}
