﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ABM_Rol
{
    public partial class Quitar_funcionalidad : Form
    {
        public Quitar_funcionalidad()
        {
            InitializeComponent();
        }

        private void boton_quitar_funcionalidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad quitada, quite más o precione 'Hecho'", "Funcionalidad quitada", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
