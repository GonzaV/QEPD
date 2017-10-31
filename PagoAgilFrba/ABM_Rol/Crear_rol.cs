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
        public Crear_rol()
        {
            InitializeComponent();
        }

        private void boton_agregar_funcionalidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad agregada, seleccione otra o cree el rol", "Funcionalidad agregada", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
