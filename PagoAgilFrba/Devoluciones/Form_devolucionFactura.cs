using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Devoluciones
{
    public partial class Form_devolucionFactura : Form
    {
        public Form_devolucionFactura()
        {
            InitializeComponent();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.Seleccion_funcionalidades().ShowDialog();
            this.Close();
        }
    }
}
