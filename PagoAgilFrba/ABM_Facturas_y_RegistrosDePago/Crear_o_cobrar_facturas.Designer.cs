namespace PagoAgilFrba.ABM_Facturas_y_RegistrosDePago
{
    partial class Crear_o_cobrar_facturas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrarItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empresa = new System.Windows.Forms.TextBox();
            this.boton_ingresar_items = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_total = new System.Windows.Forms.Label();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.boton_crear_factura = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(13, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(408, 187);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 138);
            this.dataGridView1.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrarItem);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.empresa);
            this.groupBox1.Controls.Add(this.boton_ingresar_items);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label_total);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(409, 261);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos para crear la factura (estos campos son obligatorios)";
            // 
            // btnBorrarItem
            // 
            this.btnBorrarItem.Location = new System.Drawing.Point(265, 184);
            this.btnBorrarItem.Name = "btnBorrarItem";
            this.btnBorrarItem.Size = new System.Drawing.Size(96, 23);
            this.btnBorrarItem.TabIndex = 37;
            this.btnBorrarItem.Text = "Borrar Item";
            this.btnBorrarItem.UseVisualStyleBackColor = true;
            this.btnBorrarItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de factura:";
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEmpresa.Location = new System.Drawing.Point(287, 102);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(74, 22);
            this.btnEmpresa.TabIndex = 36;
            this.btnEmpresa.Text = "Seleccionar";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCliente.Location = new System.Drawing.Point(287, 69);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(74, 22);
            this.btnCliente.TabIndex = 35;
            this.btnCliente.Text = "Seleccionar";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empresa:";
            // 
            // cliente
            // 
            this.cliente.Cursor = System.Windows.Forms.Cursors.No;
            this.cliente.Enabled = false;
            this.cliente.Location = new System.Drawing.Point(160, 71);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(121, 20);
            this.cliente.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Items:";
            // 
            // empresa
            // 
            this.empresa.Cursor = System.Windows.Forms.Cursors.No;
            this.empresa.Enabled = false;
            this.empresa.Location = new System.Drawing.Point(160, 102);
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(121, 20);
            this.empresa.TabIndex = 33;
            // 
            // boton_ingresar_items
            // 
            this.boton_ingresar_items.Location = new System.Drawing.Point(160, 184);
            this.boton_ingresar_items.Name = "boton_ingresar_items";
            this.boton_ingresar_items.Size = new System.Drawing.Size(95, 23);
            this.boton_ingresar_items.TabIndex = 16;
            this.boton_ingresar_items.Text = "Ingresar Item";
            this.boton_ingresar_items.UseVisualStyleBackColor = true;
            this.boton_ingresar_items.Click += new System.EventHandler(this.boton_ingresar_items_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha de venc:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Location = new System.Drawing.Point(161, 143);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 31;
            this.dateTimePicker2.Value = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Total:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDown1.Location = new System.Drawing.Point(161, 39);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 29;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(161, 218);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(34, 13);
            this.label_total.TabIndex = 28;
            this.label_total.Text = "         ";
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.boton_cancelar.Location = new System.Drawing.Point(117, 473);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boton_cancelar.Size = new System.Drawing.Size(75, 23);
            this.boton_cancelar.TabIndex = 42;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // boton_crear_factura
            // 
            this.boton_crear_factura.Cursor = System.Windows.Forms.Cursors.Default;
            this.boton_crear_factura.Location = new System.Drawing.Point(227, 473);
            this.boton_crear_factura.Name = "boton_crear_factura";
            this.boton_crear_factura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boton_crear_factura.Size = new System.Drawing.Size(80, 23);
            this.boton_crear_factura.TabIndex = 41;
            this.boton_crear_factura.Text = "Crear factura";
            this.boton_crear_factura.UseVisualStyleBackColor = true;
            this.boton_crear_factura.Click += new System.EventHandler(this.boton_crear_factura_Click);
            // 
            // Crear_o_cobrar_facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 518);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.boton_crear_factura);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Crear_o_cobrar_facturas";
            this.Text = "Crear_o_cobrar_facturas";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empresa;
        private System.Windows.Forms.Button boton_ingresar_items;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.Button boton_crear_factura;
        private System.Windows.Forms.Button btnBorrarItem;

    }
}