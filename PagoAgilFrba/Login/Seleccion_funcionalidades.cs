﻿using System;
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

            if (Model.Repo_usuario.getInstancia().getUsuario().getRolActivo() == "Administrador") {

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
            new ABM_Facturas_y_RegistrosDePago.Crear_o_cobrar_facturas().ShowDialog();
            this.Close();
        }

        private void boton_cobrar_facturas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ABM_Facturas_y_RegistrosDePago.Cobrar_facturas().ShowDialog();
            this.Close();
        }

    }
}
