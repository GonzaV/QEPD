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
    public partial class Listado_seleccion_empresas : Form
    {
        public Listado_seleccion_empresas()
        {
            InitializeComponent();
        }

        private void button_Modificar_empresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Modificar_empresa().ShowDialog();
            this.Close();

        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new abm_empresa().ShowDialog();
            this.Close();
        }

        private void button_Baja_empresa_Click(object sender, EventArgs e)
        {
            new Baja_empresa().ShowDialog();
        }

        
    }
}
