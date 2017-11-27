using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Facturas_y_RegistrosDePago
{
    public partial class Crear_o_cobrar_facturas : Form
    {
        public Crear_o_cobrar_facturas()
        {
            InitializeComponent();
        }

        private void boton_ingresar_items_Click(object sender, EventArgs e)
        {
            
            new Agregar_items().ShowDialog();

        }

        private void boton_crear_factura_Click(object sender, EventArgs e)
        {
            //new Model.Factura_builder().build(numericUpDown1.Value, , , dateTimePicker1.Text, dateTimePicker2.Text);
            
        }

        private void boton_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login.Seleccion_funcionalidades().ShowDialog();
            this.Close();
        }

    }
}
