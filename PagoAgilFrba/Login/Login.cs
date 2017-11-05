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
        int valorValidacion = 0;
        //public Model.Repo_usuario repo_usuarios = Model.Repo_usuario.getInstancia();
        public const Int16 BLOQUEADO = 0;
        public const Int32 MAXLOGSFALLIDOS = 4;


        public Login()
        {
            InitializeComponent();
            
        }


        private void aceptarLogin_Click(object sender, EventArgs e)

        {
            valorValidacion = validarUsuario();
            if ( valorValidacion == 1)

           {
                this.Hide();
                Model.Repo_usuario.getInstancia().getUsuario(textBoxUsuario.Text);
                new SeleccionRol.SeleccionRol().ShowDialog();
                this.Close();
           }

           else {

              Model.Repo_usuario.getInstancia().getUsuarioIngresado().sumarIntentoDeLogFallido();
              this.Hide();
              MessageBox.Show("Contraseña o usuario incorrectos", "Error de credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
              new Login().ShowDialog();

           }
            
            
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public int validarUsuario() {

            if (Model.Repo_usuario.getInstancia().getCantidadDeLogsFallidosUsuario() <= 4)
            {

            int valorValidacion = Model.Repo_usuario.getInstancia().validarUsuario(textBoxUsuario.Text, textBoxPassword.Text);

            return valorValidacion;
        
            }

            else {

                if (Model.Repo_usuario.getInstancia().getUsuarioIngresado().getEstado() != 0)
                {

                    this.Hide();
                    Model.Repo_usuario.getInstancia().bloquearUsuario();
                    MessageBox.Show("Usuario bloqueado por exceder el límite de logs fallidos, consulte un administrador", "Usuario bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return 0;

                }
                
                else {
                this.Hide();
                MessageBox.Show("El usuario se encuentra bloqueado por exceder el límite de logs fallidos, consulte un administrador","Usuario bloqueado",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();

                return 0;

                }

            }


        }


    }
}
