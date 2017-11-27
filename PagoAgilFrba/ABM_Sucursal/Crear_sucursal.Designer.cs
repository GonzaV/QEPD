namespace PagoAgilFrba.ABM_Sucursal
{
    partial class Crear_sucursal
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
            this.boton_crear_sucursal = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.numeric_cp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos de la nueva sucursal (todos los campos son obligatorios):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo Postal:";
            // 
            // boton_crear_sucursal
            // 
            this.boton_crear_sucursal.Location = new System.Drawing.Point(207, 193);
            this.boton_crear_sucursal.Name = "boton_crear_sucursal";
            this.boton_crear_sucursal.Size = new System.Drawing.Size(75, 23);
            this.boton_crear_sucursal.TabIndex = 4;
            this.boton_crear_sucursal.Text = "Crear";
            this.boton_crear_sucursal.UseVisualStyleBackColor = true;
            this.boton_crear_sucursal.Click += new System.EventHandler(this.boton_crear_sucursal_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(94, 57);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 5;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(94, 94);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(100, 20);
            this.textBox_direccion.TabIndex = 6;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(94, 193);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 8;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // numeric_cp
            // 
            this.numeric_cp.Location = new System.Drawing.Point(94, 129);
            this.numeric_cp.Name = "numeric_cp";
            this.numeric_cp.Size = new System.Drawing.Size(100, 20);
            this.numeric_cp.TabIndex = 9;
            // 
            // Crear_sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 249);
            this.Controls.Add(this.numeric_cp);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.boton_crear_sucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Crear_sucursal";
            this.Text = "Crear_sucursal";
            this.Load += new System.EventHandler(this.Crear_sucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton_crear_sucursal;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.NumericUpDown numeric_cp;
    }
}