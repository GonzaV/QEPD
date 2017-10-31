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
        public Modificar_rol()
        {
            InitializeComponent();
        }

        private void boton_agregar_funcionalidad_Click(object sender, EventArgs e)
        {
            new Agregar_funcionalidad().ShowDialog();
        }

        private void boton_eliminar_funcionalidad_Click(object sender, EventArgs e)
        {
            new Quitar_funcionalidad().ShowDialog();
        }
    }
}
