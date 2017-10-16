using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Login_Seguridad.SeleccionRol
{
    public partial class SeleccionRol : Form
    {

        public List<Int32> listita = new List<Int32>();
        

        public SeleccionRol()
        {
            InitializeComponent();
            listita.Add(54);
            listita.Add(88);
            this.selectorDeRol.DataSource = listita;
           // this.selectorDeRol.DisplayMember = "Name";
           // this.selectorDeRol.ValueMember = "Value";
            this.selectorDeRol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void selectorDeRol_SelectedIndexChanged(object sender, EventArgs e)
        {




        }
    }
}
