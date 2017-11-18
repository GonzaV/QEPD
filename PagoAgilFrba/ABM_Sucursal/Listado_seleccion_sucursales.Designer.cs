namespace PagoAgilFrba.ABM_Sucursal
{
    partial class Listado_seleccion_sucursales
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
            this.label3 = new System.Windows.Forms.Label();
            this.idSucursal_seleccionada = new System.Windows.Forms.TextBox();
            this.textBox_filtroCpSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_filtroNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_filtroDireccionSucursal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(64, 356);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 14;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button_Baja_cliente
            // 
            this.button_Baja_cliente.Location = new System.Drawing.Point(417, 356);
            this.button_Baja_cliente.Name = "button_Baja_cliente";
            this.button_Baja_cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Baja_cliente.TabIndex = 13;
            this.button_Baja_cliente.Text = "Eliminar";
            this.button_Baja_cliente.UseVisualStyleBackColor = true;
            this.button_Baja_cliente.Click += new System.EventHandler(this.button_Baja_cliente_Click);
            // 
            // button_Modificar_cliente
            // 
            this.button_Modificar_cliente.Location = new System.Drawing.Point(306, 356);
            this.button_Modificar_cliente.Name = "button_Modificar_cliente";
            this.button_Modificar_cliente.Size = new System.Drawing.Size(75, 23);
            this.button_Modificar_cliente.TabIndex = 12;
            this.button_Modificar_cliente.Text = "Modificar";
            this.button_Modificar_cliente.UseVisualStyleBackColor = true;
            this.button_Modificar_cliente.Click += new System.EventHandler(this.button_Modificar_cliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_filtroDireccionSucursal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.idSucursal_seleccionada);
            this.groupBox1.Controls.Add(this.textBox_filtroCpSucursal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_filtroNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 123);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Sucursales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID Empresa seleccionada";
            // 
            // idSucursal_seleccionada
            // 
            this.idSucursal_seleccionada.Location = new System.Drawing.Point(145, 97);
            this.idSucursal_seleccionada.Name = "idSucursal_seleccionada";
            this.idSucursal_seleccionada.ReadOnly = true;
            this.idSucursal_seleccionada.Size = new System.Drawing.Size(121, 20);
            this.idSucursal_seleccionada.TabIndex = 5;
            // 
            // textBox_filtroCpSucursal
            // 
            this.textBox_filtroCpSucursal.Location = new System.Drawing.Point(342, 30);
            this.textBox_filtroCpSucursal.Name = "textBox_filtroCpSucursal";
            this.textBox_filtroCpSucursal.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtroCpSucursal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo Postal";
            // 
            // textBox_filtroNombre
            // 
            this.textBox_filtroNombre.Location = new System.Drawing.Point(118, 30);
            this.textBox_filtroNombre.Name = "textBox_filtroNombre";
            this.textBox_filtroNombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtroNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(474, 185);
            this.dataGridView1.TabIndex = 10;
            // 
            // textBox_filtroDireccionSucursal
            // 
            this.textBox_filtroDireccionSucursal.Location = new System.Drawing.Point(342, 63);
            this.textBox_filtroDireccionSucursal.Name = "textBox_filtroDireccionSucursal";
            this.textBox_filtroDireccionSucursal.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtroDireccionSucursal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion";
            // 
            // Listado_seleccion_sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 408);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_Baja_cliente);
            this.Controls.Add(this.button_Modificar_cliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Listado_seleccion_sucursales";
            this.Text = "Listado_seleccion_sucursales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_Baja_cliente;
        private System.Windows.Forms.Button button_Modificar_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idSucursal_seleccionada;
        private System.Windows.Forms.TextBox textBox_filtroCpSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_filtroNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_filtroDireccionSucursal;
        private System.Windows.Forms.Label label4;
    }
}