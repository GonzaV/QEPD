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
    public partial class Baja_sucursal : Form
    {
        public Baja_sucursal()
        {
            InitializeComponent();
        }

        private void button_cancelarBaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        
    }
}
