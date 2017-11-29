using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Login
{
    public partial class Seleccion_funcionalidades : Form
    {

        const int IDADMIN = 1;

        public Seleccion_funcionalidades()
        {
            InitializeComponent();
            determinarHabilitacionFuncionesAdmin();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            new Seleccion_funcionalidades_admin().ShowDialog();
            this.Close();

        }

        public void determinarHabilitacionFuncionesAdmin() {

            if (Model.Repo_usuario.getInstancia().getUsuarioIngresado().getRolActivo().getId() == IDADMIN) {

                linkLabel1.Enabled = true;
            
            }

            else {

                linkLabel1.Enabled = false;
            
            }
        
        }

        private void boton_abm_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ABM_Cliente.abm_cliente().ShowDialog();
            this.Close();
        }

        private void boton_crear_y_cobrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ABM_Facturas_y_RegistrosDePago.Crear_o_cobrar_facturas(new Model.Factura_builder()).ShowDialog();
            this.Close();
        }

        private void boton_cobrar_facturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ABM_Facturas_y_RegistrosDePago.Cobrar_facturas().ShowDialog();
            this.Close();
        }

        private void boton_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SeleccionRol.SeleccionRol().ShowDialog();
            this.Close();
        }

        private void button_devolucionFacturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Devoluciones.Form_devolucionPago().ShowDialog();
            this.Close();
        }

    }
}
