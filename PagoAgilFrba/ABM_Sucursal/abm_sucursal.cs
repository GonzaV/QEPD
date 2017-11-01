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
    public partial class abm_sucursal : Form
    {
        public abm_sucursal()
        {
            InitializeComponent();
        }

        private void boton_crear_sucursal_Click(object sender, EventArgs e)
        {
            new Crear_sucursal().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Modificar_sucursal().ShowDialog();
        }
    }
}
