using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PagoAgilFrba.Login_Seguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            
        }


        private void aceptarLogin_Click(object sender, EventArgs e)

        {
            this.Hide();
            new SeleccionRol.SeleccionRol().ShowDialog();
            this.Close();
            
        }




    }
}
