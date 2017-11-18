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
            this.Hide();
            new Crear_sucursal().ShowDialog();
            this.Close();
        }

     

        private void button_Listado_seleccion_sucursales_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Listado_seleccion_sucursales().ShowDialog();
            this.Close();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.Seleccion_funcionalidades_admin().ShowDialog();
            this.Close();
        }
    }
}
