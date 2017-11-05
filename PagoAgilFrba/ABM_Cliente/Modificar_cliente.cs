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
    public partial class Modificar_cliente : Form
    {
        public Modificar_cliente()
        {
            InitializeComponent();
            Model.Repo_cliente.getInstancia().getClienteSeleccionado();
        }

        private void textBox_telefono_KeyPress(object sender, KeyPressEventArgs e){
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)){
                
                e.Handled = true;
            }
        }
        
        public void estaVacio(String textbox)
        {

            if (string.IsNullOrEmpty(textbox))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }

        }

        

        private void boton_modificar_Click(object sender, EventArgs e)
        {
                Model.Repo_cliente.getInstancia().modificarCliente(
                textBox_nombre.Text,
                textBox_apellido.Text,
                Convert.ToInt32(textBox_dni.Text),
                textBox_email.Text,
                Convert.ToInt32(textBox_telefono.Text),
                Convert.ToDateTime(textBox_fnacimiento.Text),
                textBox_direccion.Text,
                Convert.ToInt32(textBox_cp.Text));
        }
    }
}
