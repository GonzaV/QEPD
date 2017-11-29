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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label7 = new System.Windows.Forms.Label();
            this.boton_ingresar_items = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.boton_crear_factura = new System.Windows.Forms.Button();
            this.boton_registrar_pago = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.boton_cancelar = new System.Windows.Forms.Button();
            this.empresa = new System.Windows.Forms.TextBox();
            this.cliente = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos para crear la factura (estos campos son obligatorios):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Empresa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de factura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Items:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(492, 540);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 460;
            this.lineShape1.Y1 = 268;
            this.lineShape1.Y2 = 268;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ingrese los siguientes datos si tambien desea registrar un pago (*):";
            // 
            // boton_ingresar_items
            // 
            this.boton_ingresar_items.Location = new System.Drawing.Point(139, 196);
            this.boton_ingresar_items.Name = "boton_ingresar_items";
            this.boton_ingresar_items.Size = new System.Drawing.Size(121, 23);
            this.boton_ingresar_items.TabIndex = 16;
            this.boton_ingresar_items.Text = "Ingresar Items";
            this.boton_ingresar_items.UseVisualStyleBackColor = true;
            this.boton_ingresar_items.Click += new System.EventHandler(this.boton_ingresar_items_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha de venc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Importe a cobrar (*):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Sucursal (*):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(406, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "NO OLVIDAR DE CARGAR LA FECHA DE COBRO CON LA FECHA DEL SISTEMA";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(139, 352);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 395);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 24;
            // 
            // boton_crear_factura
            // 
            this.boton_crear_factura.Location = new System.Drawing.Point(31, 457);
            this.boton_crear_factura.Name = "boton_crear_factura";
            this.boton_crear_factura.Size = new System.Drawing.Size(160, 23);
            this.boton_crear_factura.TabIndex = 25;
            this.boton_crear_factura.Text = "Crear factura";
            this.boton_crear_factura.UseVisualStyleBackColor = true;
            this.boton_crear_factura.Click += new System.EventHandler(this.boton_crear_factura_Click);
            // 
            // boton_registrar_pago
            // 
            this.boton_registrar_pago.Location = new System.Drawing.Point(285, 457);
            this.boton_registrar_pago.Name = "boton_registrar_pago";
            this.boton_registrar_pago.Size = new System.Drawing.Size(160, 23);
            this.boton_registrar_pago.TabIndex = 26;
            this.boton_registrar_pago.Text = "Crear factura y registrar pago";
            this.boton_registrar_pago.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Total:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(139, 230);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(295, 13);
            this.label_total.TabIndex = 28;
            this.label_total.Text = "Este label se actualiza con el total segun los items agregados";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 110);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 29;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(139, 155);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(31, 505);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.Size = new System.Drawing.Size(75, 23);
            this.boton_cancelar.TabIndex = 32;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // empresa
            // 
            this.empresa.Enabled = false;
            this.empresa.Location = new System.Drawing.Point(138, 83);
            this.empresa.Name = "empresa";
            this.empresa.Size = new System.Drawing.Size(121, 20);
            this.empresa.TabIndex = 33;
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(138, 52);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(121, 20);
            this.cliente.TabIndex = 34;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(265, 50);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(74, 22);
            this.btnCliente.TabIndex = 35;
            this.btnCliente.Text = "Seleccionar";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.No;
            this.btnEmpresa.Enabled = false;
            this.btnEmpresa.Location = new System.Drawing.Point(265, 83);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(74, 22);
            this.btnEmpresa.TabIndex = 36;
            this.btnEmpresa.Text = "Seleccionar";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // Crear_o_cobrar_facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 540);
            this.Controls.Add(this.btnEmpresa);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.empresa);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.boton_registrar_pago);
            this.Controls.Add(this.boton_crear_factura);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.boton_ingresar_items);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Enabled = false;
            this.Name = "Crear_o_cobrar_facturas";
            this.Text = "Crear_o_cobrar_facturas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button boton_ingresar_items;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button boton_crear_factura;
        private System.Windows.Forms.Button boton_registrar_pago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button boton_cancelar;
        private System.Windows.Forms.TextBox empresa;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnEmpresa;
    }
}