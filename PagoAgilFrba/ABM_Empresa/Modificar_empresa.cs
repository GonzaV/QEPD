using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Empresa
{
    public partial class Modificar_empresa : Form
    {
        public Modificar_empresa()
        {
            InitializeComponent();
        }

        private void boton_modificar_empresa_Click(object sender, EventArgs e)
        {

        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Listado_seleccion_empresas().ShowDialog();
            this.Close();
        }
    }
}
