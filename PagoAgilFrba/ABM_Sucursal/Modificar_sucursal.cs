﻿using System;
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
    public partial class Modificar_sucursal : Form
    {
        public Modificar_sucursal()
        {
            InitializeComponent();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Listado_seleccion_sucursales().ShowDialog();
            this.Close();
        }
    }
}
