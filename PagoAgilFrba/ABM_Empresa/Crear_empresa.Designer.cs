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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_cuit = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_rubro = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boton_crear_empresa = new System.Windows.Forms.Button();
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
            this.label_nombre.Location = new System.Drawing.Point(16, 54);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(47, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label_cuit
            // 
            this.label_cuit.AutoSize = true;
            this.label_cuit.Location = new System.Drawing.Point(16, 87);
            this.label_cuit.Name = "label_cuit";
            this.label_cuit.Size = new System.Drawing.Size(35, 13);
            this.label_cuit.TabIndex = 3;
            this.label_cuit.Text = "CUIT:";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(16, 122);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(55, 13);
            this.label_direccion.TabIndex = 4;
            this.label_direccion.Text = "Dirección:";
            // 
            // label_rubro
            // 
            this.label_rubro.AutoSize = true;
            this.label_rubro.Location = new System.Drawing.Point(16, 160);
            this.label_rubro.Name = "label_rubro";
            this.label_rubro.Size = new System.Drawing.Size(39, 13);
            this.label_rubro.TabIndex = 5;
            this.label_rubro.Text = "Rubro:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // boton_crear_empresa
            // 
            this.boton_crear_empresa.Location = new System.Drawing.Point(266, 226);
            this.boton_crear_empresa.Name = "boton_crear_empresa";
            this.boton_crear_empresa.Size = new System.Drawing.Size(75, 23);
            this.boton_crear_empresa.TabIndex = 7;
            this.boton_crear_empresa.Text = "Crear";
            this.boton_crear_empresa.UseVisualStyleBackColor = true;
            // 
            // Crear_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 261);
            this.Controls.Add(this.boton_crear_empresa);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_rubro);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_cuit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Crear_empresa";
            this.Text = "Crear_empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_cuit;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_rubro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button boton_crear_empresa;
    }
}