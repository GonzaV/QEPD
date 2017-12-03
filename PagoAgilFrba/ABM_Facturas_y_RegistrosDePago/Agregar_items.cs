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
    public partial class Agregar_items : Form
    {
        private Model.Factura_builder facturaBuilder;
        private ABM_Facturas_y_RegistrosDePago.Crear_o_cobrar_facturas miViewFacturas;

        public Agregar_items(ABM_Facturas_y_RegistrosDePago.Crear_o_cobrar_facturas miViewFacturas)
        {
            InitializeComponent();
            this.miViewFacturas = miViewFacturas;
            facturaBuilder = this.miViewFacturas.getfacturaBuilder();
            this.miViewFacturas.modificarLabelTotal(Convert.ToString(facturaBuilder.getItems().Sum(x => x.getMonto())));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            facturaBuilder.agregarItemFactura(textBox1.Text, numericUpDown1.Value, numericUpDown2.Value);
            miViewFacturas.setfacturaBuilder(this.facturaBuilder);
        }

    

    }
}
