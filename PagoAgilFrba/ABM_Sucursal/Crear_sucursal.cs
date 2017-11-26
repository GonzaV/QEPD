using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Sucursal
{
    public partial class Crear_sucursal : Form
    {
        public Crear_sucursal()
        {
            InitializeComponent();
        }

        private void Crear_sucursal_Load(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new abm_sucursal().ShowDialog();
            this.Close();
        }
    }
}
