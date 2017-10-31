﻿using System;
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
    public partial class Crear_cliente : Form
    {
        public Crear_cliente()
        {
            InitializeComponent();
        }

        private void label_telefono_Click(object sender, EventArgs e)
        {

        }

        private void textBox_nombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            String mensajeDeError;

            if(!ValidarNombreOApellido(textBox_nombre.Text, out mensajeDeError)){
            
            e.Cancel = true; //cancela el evento
            textBox_nombre.SelectAll();

            }

        }

        public bool ValidarNombreOApellido(String nombreOApellido, out String mensajeDeError) {

            if (nombreOApellido.Length == 0) {

                mensajeDeError = "Debe ingresar un nombre";
                return false;

            }

            mensajeDeError = "";
            return true;

        }
    }
}