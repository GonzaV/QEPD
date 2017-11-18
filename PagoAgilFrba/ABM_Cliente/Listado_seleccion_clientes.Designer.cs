namespace PagoAgilFrba.ABM_Cliente
{
    partial class Listado_seleccion_clientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_filtroNombre = new System.Windows.Forms.TextBox();
            this.textBox_filtroDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idCliente_seleccionado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Modificar_cliente = new System.Windows.Forms.Button();
            this.button_Baja_cliente = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.checkBox_filtroActivos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_filtroActivos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idCliente_seleccionado);
            this.groupBox1.Controls.Add(this.textBox_filtroDNI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_filtroNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Clientes";
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
            // textBox_filtroNombre
            // 
            this.textBox_filtroNombre.Location = new System.Drawing.Point(57, 27);
            this.textBox_filtroNombre.Name = "textBox_filtroNombre";
            this.textBox_filtroNombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtroNombre.TabIndex = 1;
            // 
            // textBox_filtroDNI
            // 
            this.textBox_filtroDNI.Location = new System.Drawing.Point(57, 62);
            this.textBox_filtroDNI.Name = "textBox_filtroDNI";
            this.textBox_filtroDNI.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtroDNI.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI";
            // 
            // idCliente_seleccionado
            // 
            this.idCliente_seleccionado.Location = new System.Drawing.Point(336, 61);
            this.idCliente_seleccionado.Name = "idCliente_seleccionado";
            this.idCliente_seleccionado.ReadOnly = true;
            this.idCliente_seleccionado.Size = new System.Drawing.Size(121, 20);
            this.idCliente_seleccionado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Cliente seleccionado";
            // 
            // button_Modificar_cliente
            // 
            this.button_Modificar_cliente.Location = new System.Drawing.Point(283, 353);
            this.button_Modificar_cliente.Name = "button_Modificar_cliente";
            this.button_Modificar_cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Modificar_cliente.TabIndex = 2;
            this.button_Modificar_cliente.Text = "Modificar";
            this.button_Modificar_cliente.UseVisualStyleBackColor = true;
            this.button_Modificar_cliente.Click += new System.EventHandler(this.button_Modificar_cliente_Click);
            // 
            // button_Baja_cliente
            // 
            this.button_Baja_cliente.Location = new System.Drawing.Point(394, 353);
            this.button_Baja_cliente.Name = "button_Baja_cliente";
            this.button_Baja_cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Baja_cliente.TabIndex = 3;
            this.button_Baja_cliente.Text = "Eliminar";
            this.button_Baja_cliente.UseVisualStyleBackColor = true;
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(41, 353);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 4;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // checkBox_filtroActivos
            // 
            this.checkBox_filtroActivos.AutoSize = true;
            this.checkBox_filtroActivos.Location = new System.Drawing.Point(336, 27);
            this.checkBox_filtroActivos.Name = "checkBox_filtroActivos";
            this.checkBox_filtroActivos.Size = new System.Drawing.Size(61, 17);
            this.checkBox_filtroActivos.TabIndex = 7;
            this.checkBox_filtroActivos.Text = "Activos";
            this.checkBox_filtroActivos.UseVisualStyleBackColor = true;
            // 
            // Listado_seleccion_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 388);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_Baja_cliente);
            this.Controls.Add(this.button_Modificar_cliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listado_seleccion_clientes";
            this.Text = "Listado_seleccion_clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idCliente_seleccionado;
        private System.Windows.Forms.TextBox textBox_filtroDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_filtroNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Modificar_cliente;
        private System.Windows.Forms.Button button_Baja_cliente;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.CheckBox checkBox_filtroActivos;
    }
}