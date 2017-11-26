namespace PagoAgilFrba.ABM_Empresa
{
    partial class Crear_empresa
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
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_cuit = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_rubro = new System.Windows.Forms.Label();
            this.textBox_CUIT = new System.Windows.Forms.TextBox();
            this.boton_crear_empresa = new System.Windows.Forms.Button();
            this.comboBox_rubro = new System.Windows.Forms.ComboBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_codigoPostal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos de la empresa a crear (todos los campos son obligatorios):";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(13, 54);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(47, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(78, 51);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 2;
            // 
            // label_cuit
            // 
            this.label_cuit.AutoSize = true;
            this.label_cuit.Location = new System.Drawing.Point(13, 87);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(35, 13);
            this.label_cuit.TabIndex = 3;
            this.label_cuit.Text = "CUIT:";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(32, 32);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(55, 13);
            this.label_direccion.TabIndex = 4;
            this.label_direccion.Text = "Dirección:";
            // 
            // label_rubro
            // 
            this.label_rubro.AutoSize = true;
            this.label_rubro.Location = new System.Drawing.Point(13, 122);
            this.label_rubro.Name = "label_rubro";
            this.label_rubro.Size = new System.Drawing.Size(39, 13);
            this.label_rubro.TabIndex = 5;
            this.label_rubro.Text = "Rubro:";
            // 
            // textBox_CUIT
            // 
            this.textBox_CUIT.Location = new System.Drawing.Point(78, 84);
            this.textBox_CUIT.Name = "textBox_CUIT";
            this.textBox_CUIT.Size = new System.Drawing.Size(100, 20);
            this.textBox_CUIT.TabIndex = 6;
            // 
            // boton_crear_empresa
            // 
            this.boton_crear_empresa.Location = new System.Drawing.Point(226, 294);
            this.boton_crear_empresa.Name = "boton_crear_empresa";
            this.boton_crear_empresa.Size = new System.Drawing.Size(75, 23);
            this.boton_crear_empresa.TabIndex = 7;
            this.boton_crear_empresa.Text = "Crear";
            this.boton_crear_empresa.UseVisualStyleBackColor = true;
            // 
            // comboBox_rubro
            // 
            this.comboBox_rubro.FormattingEnabled = true;
            this.comboBox_rubro.Location = new System.Drawing.Point(78, 119);
            this.comboBox_rubro.Name = "comboBox_rubro";
            this.comboBox_rubro.Size = new System.Drawing.Size(121, 21);
            this.comboBox_rubro.TabIndex = 8;
            this.comboBox_rubro.SelectedIndexChanged += new System.EventHandler(this.comboBox_rubro_SelectedIndexChanged);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(97, 29);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(100, 20);
            this.textBox_direccion.TabIndex = 9;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(61, 294);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 10;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_codigoPostal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_direccion);
            this.groupBox1.Controls.Add(this.label_direccion);
            this.groupBox1.Location = new System.Drawing.Point(26, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio";
            // 
            // textBox_codigoPostal
            // 
            this.textBox_codigoPostal.Location = new System.Drawing.Point(97, 55);
            this.textBox_codigoPostal.Name = "textBox_codigoPostal";
            this.textBox_codigoPostal.Size = new System.Drawing.Size(100, 20);
            this.textBox_codigoPostal.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo Postal:";
            // 
            // Crear_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.comboBox_rubro);
            this.Controls.Add(this.boton_crear_empresa);
            this.Controls.Add(this.textBox_CUIT);
            this.Controls.Add(this.label_rubro);
            this.Controls.Add(this.label_cuit);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Crear_empresa";
            this.Text = "Crear_empresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_cuit;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_rubro;
        private System.Windows.Forms.TextBox textBox_CUIT;
        private System.Windows.Forms.Button boton_crear_empresa;
        private System.Windows.Forms.ComboBox comboBox_rubro;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_codigoPostal;
        private System.Windows.Forms.Label label2;
    }
}