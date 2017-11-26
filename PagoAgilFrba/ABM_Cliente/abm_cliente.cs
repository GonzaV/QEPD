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
    public partial class abm_cliente : Form
    {

        
        public Model.Cliente clienteSeleccionado;

        public abm_cliente()
        {
            InitializeComponent();
            
        }


        private void boton_crear_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Crear_cliente().ShowDialog();
            this.Close();
        }

        private void boton_modificar_cliente_Click(object sender, EventArgs e)
        {

            this.Hide();
            new Listado_seleccion_clientes().ShowDialog();
            this.Close();

        }

  /*      private void boton_eliminar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Listado_seleccion_clientes().ShowDialog();
            this.Close();
        } */

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.Seleccion_funcionalidades().ShowDialog();
            this.Close();
        }

        private void abm_cliente_Load(object sender, EventArgs e)
        {

        }

    }
}
