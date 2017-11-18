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
    public partial class Listado_seleccion_sucursales : Form
    {
        public Listado_seleccion_sucursales()
        {
            InitializeComponent();
        }

        private void button_Modificar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Modificar_sucursal().ShowDialog();
            this.Close();
        }

        private void button_Baja_cliente_Click(object sender, EventArgs e)
        {
            new Baja_sucursal().ShowDialog();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new abm_sucursal().ShowDialog();
            this.Close();
        }
    }
}
