using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Cliente
{
    public partial class Listado_seleccion_clientes : Form
    {
         Listado_Clientes_Observer controller;

        public Listado_seleccion_clientes()
        {
            InitializeComponent();
        }

        private void button_Modificar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Modificar_cliente().ShowDialog();
            this.Close();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new abm_cliente().ShowDialog();
            this.Close();
        }

        private void button_Baja_cliente_Click(object sender, EventArgs e)
        {
            new Baja_cliente().ShowDialog();
        }

        public void setController(Listado_Clientes_Observer controller)
        {
            this.controller = controller;
        }
    }
}
