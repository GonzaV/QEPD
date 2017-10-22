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
    public partial class Login : Form
    {

        String contraseñaIngresada;
        String usuarioIngresado;

        public Login()
        {
            InitializeComponent();
            
        }


        private void aceptarLogin_Click(object sender, EventArgs e)

        {
            this.Hide();
            if (Model.Repo_usuario.getInstancia().obtenerNombreDeUsuarioLoggeado() == this.usuarioIngresado && Model.Repo_usuario.getInstancia().obtenerPasswordUsuario() == this.contraseñaIngresada)
            {
                new SeleccionRol.SeleccionRol().ShowDialog();
            }
            else { 
                
                //aca deberia tirar el label de que el usuario o contraseña son incorrectos
                this.Close();

            }
            this.Close();
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxContraseña = (TextBox)sender;
            this.contraseñaIngresada = textBoxContraseña.Text;
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            TextBox textBoxUsuario = (TextBox)sender;
            this.usuarioIngresado = textBoxUsuario.Text;
        }

     






    }
}
