﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Empresa
{
    public partial class abm_empresa : Form
    {
        public abm_empresa()
        {
            InitializeComponent();
        }

        private void boton_crear_empresa_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Crear_empresa().ShowDialog();
            this.Close();
        }

        private void button_Listado_seleccion_empresas_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Listado_seleccion_empresas().ShowDialog();
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
