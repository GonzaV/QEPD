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
    public partial class Crear_empresa : Form
    {
        public Crear_empresa()
        {
            InitializeComponent();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new abm_empresa().ShowDialog();
            this.Close();
        }
    }
}
