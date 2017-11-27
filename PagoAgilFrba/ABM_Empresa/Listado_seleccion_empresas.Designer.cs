namespace PagoAgilFrba.ABM_Empresa
{
    partial class Listado_seleccion_empresas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_volver = new System.Windows.Forms.Button();
            this.button_Baja_cliente = new System.Windows.Forms.Button();
            this.button_Modificar_cliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_rubros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idEmpresa_seleccionada = new System.Windows.Forms.TextBox();
            this.textBox_filtroCuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_filtroNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_empresas = new System.Windows.Forms.DataGridView();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(84, 403);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 9;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button_Baja_cliente
            // 
            this.button_Baja_cliente.Location = new System.Drawing.Point(435, 403);
            this.button_Baja_cliente.Name = "button_Baja_cliente";
            this.button_Baja_cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Baja_cliente.TabIndex = 8;
            this.button_Baja_cliente.Text = "Eliminar";
            this.button_Baja_cliente.UseVisualStyleBackColor = true;
            this.button_Baja_cliente.Click += new System.EventHandler(this.button_Baja_empresa_Click);
            // 
            // button_Modificar_cliente
            // 
            this.button_Modificar_cliente.Location = new System.Drawing.Point(333, 403);
            this.button_Modificar_cliente.Name = "button_Modificar_cliente";
            this.button_Modificar_cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Modificar_cliente.TabIndex = 7;
            this.button_Modificar_cliente.Text = "Modificar";
            this.button_Modificar_cliente.UseVisualStyleBackColor = true;
            this.button_Modificar_cliente.Click += new System.EventHandler(this.button_Modificar_empresa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_rubros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idEmpresa_seleccionada);
            this.groupBox1.Controls.Add(this.textBox_filtroCuit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_filtroNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 102);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Empresas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rubro";
            // 
            // comboBox_rubros
            // 
            this.comboBox_rubros.FormattingEnabled = true;
            this.comboBox_rubros.Location = new System.Drawing.Point(336, 27);
            this.comboBox_rubros.Name = "comboBox_rubros";
            this.comboBox_rubros.Size = new System.Drawing.Size(121, 21);
            this.comboBox_rubros.TabIndex = 7;
            this.comboBox_rubros.SelectedIndexChanged += new System.EventHandler(this.comboBox_rubros_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Empresa seleccionada";
            // 
            // idEmpresa_seleccionada
            // 
            this.idEmpresa_seleccionada.Location = new System.Drawing.Point(336, 61);
            this.idEmpresa_seleccionada.Name = "idEmpresa_seleccionada";
            this.idEmpresa_seleccionada.ReadOnly = true;
            this.idEmpresa_seleccionada.Size = new System.Drawing.Size(121, 20);
            this.idEmpresa_seleccionada.TabIndex = 5;
            // 
            // textBox_filtroCuit
            // 
            this.textBox_filtroCuit.Location = new System.Drawing.Point(57, 62);
            this.textBox_filtroCuit.Name = "textBox_filtroCuit";
            this.textBox_filtroCuit.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtroCuit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT";
            // 
            // textBox_filtroNombre
            // 
            this.textBox_filtroNombre.Location = new System.Drawing.Point(57, 27);
            this.textBox_filtroNombre.Name = "textBox_filtroNombre";
            this.textBox_filtroNombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtroNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dataGrid_empresas
            // 
            this.dataGrid_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_empresas.Location = new System.Drawing.Point(53, 189);
            this.dataGrid_empresas.Name = "dataGrid_empresas";
            this.dataGrid_empresas.Size = new System.Drawing.Size(474, 185);
            this.dataGrid_empresas.TabIndex = 5;
            // 
            // button_filtrar
            // 
            this.button_filtrar.Location = new System.Drawing.Point(389, 132);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(121, 23);
            this.button_filtrar.TabIndex = 10;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.button_filtrar_Click);
            // 
            // Listado_seleccion_empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 447);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_Baja_cliente);
            this.Controls.Add(this.button_Modificar_cliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid_empresas);
            this.Name = "Listado_seleccion_empresas";
            this.Text = "Listado_seleccion_empresas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_empresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_Baja_cliente;
        private System.Windows.Forms.Button button_Modificar_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_rubros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idEmpresa_seleccionada;
        private System.Windows.Forms.TextBox textBox_filtroCuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_filtroNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_empresas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_filtrar;
    }
}