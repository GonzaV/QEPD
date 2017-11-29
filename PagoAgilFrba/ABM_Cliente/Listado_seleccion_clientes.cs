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
    public partial class Listado_seleccion_clientes : Form
    {

        const String CHECKED = "True";

        public Listado_seleccion_clientes()
        {
            InitializeComponent();
        }

        private void button_Modificar_cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Modificar_cliente().ShowDialog();
            this.Close();
        }

        private void button_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new abm_cliente().ShowDialog();
            this.Close();
        }

        private void button_Baja_cliente_Click(object sender, EventArgs e)
        {
            new Baja_cliente().ShowDialog();
        }

        private void boton_filtrar_Click(object sender, EventArgs e)
        {
            Boolean estado;

            if(checkBox_filtroActivos.Checked.ToString() == CHECKED) {
                
                estado = true;
            
            }

            else{
            
                estado = false;

            }

            DataTable tablaClientesFiltrados = Model.Repo_cliente.getInstancia().getTablaClientesFiltrados(textBox_filtroNombre.Text, textBox_filtroDNI.Text, estado);
            dataGrid_clientes.DataSource = tablaClientesFiltrados;

        }

        private void dataGrid_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente_seleccionado.Text = dataGrid_clientes.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString();
            //estado = (Boolean)dataGrid_empresas.Rows[e.RowIndex].Cells["Estado_Empresa"].Value;
            //Repositorios.Repo_empresas.getInstancia().setEstadoEmpresaSeleccionada(estado);
            //Repositorios.Repo_empresas.getInstancia().setIdEmpresaSeleccionada(Int32.Parse(idEmpresa_seleccionada.Text));

        }

    }
}
