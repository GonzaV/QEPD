using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace PagoAgilFrba.ABM_Empresa
{
    public partial class Listado_seleccion_empresas : Form
    {

        public Boolean estado;
        public Int32 idEmpresa;
        public Model.Rubro rubroElegido;
        private Listado_Empresa_Observer controller;
        const Int32 VACIO = -1;
        public Listado_seleccion_empresas()
        {
            InitializeComponent();
            configuarComboBox();
            Repositorios.Repo_empresas.getInstancia().reiniciarEmpresaSeleccionada();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new abm_empresa().ShowDialog();
            this.Close();
        }

        private void button_Baja_empresa_Click(object sender, EventArgs e)
        {
            new Baja_empresa().ShowDialog();
        }

        public void configuarComboBox()
        {

           
            this.comboBox_rubros.ValueMember = "Objeto";
            this.comboBox_rubros.DisplayMember = "Descripcion";
            this.comboBox_rubros.DataSource = Repositorios.Repo_empresas.getInstancia().getRubros();
            this.comboBox_rubros.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button_filtrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = Utils.DBhelper.getInstancia().obtenerData("SELECT IdEmpresa, Nombre_Empresa, Cuit, Fecha_Rendicion, IdDomicilio, Estado_Empresa, IdRubro FROM QEPD.Empresa e JOIN QEPD.Rubro r ON r.Nro_Rubro = e.IdRubro WHERE Nombre_Empresa LIKE '%" + textBox_filtroNombre.Text + "%' AND Cuit LIKE '%" + textBox_filtroCuit.Text + "%' AND Descripcion_Rubro = '" + rubroElegido.getDescripcion() + "'");
            dataGrid_empresas.DataSource = tabla;
        }

        private void comboBox_rubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboboxRubros = (ComboBox)sender;
            rubroElegido = (Model.Rubro)comboboxRubros.SelectedValue;
        }

        private void boton_modificar_Click(object sender, EventArgs e)
        {

            if (Repositorios.Repo_empresas.getInstancia().getIdEmpresaSeleccionada() == VACIO) {

                MessageBox.Show("Por favor, seleccione de la grilla una empresa a modificar clickeando en cualquiera de sus atributos", "Seleccione empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }

            else {

            this.Hide();
            new Modificar_empresa().ShowDialog();
            this.Close();

            }
        }

        private void dataGrid_empresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                idEmpresa_seleccionada.Text = dataGrid_empresas.Rows[e.RowIndex].Cells["IdEmpresa"].Value.ToString();
                estado = (Boolean)dataGrid_empresas.Rows[e.RowIndex].Cells["Estado_Empresa"].Value;
                Repositorios.Repo_empresas.getInstancia().setEstadoEmpresaSeleccionada(estado);
                Repositorios.Repo_empresas.getInstancia().setIdEmpresaSeleccionada(Int32.Parse(idEmpresa_seleccionada.Text));

                if (controller != null)
                {
                    String nombreEmpresaElegida = dataGrid_empresas.Rows[e.RowIndex].Cells["Nombre_Empresa"].Value.ToString();
                    this.controller.mostrarEmpresaElegidad(nombreEmpresaElegida);
                }
                
        }

        public void setController(Listado_Empresa_Observer controller)
        {
            this.controller = controller;

        }

        public void ocultarBtnModificar()
        {
            boton_modificar.Visible = false;
        }
 
        public void ocultarBtnEliminar()
        {
            button_Baja_cliente.Visible = false;
        }

    }
}
