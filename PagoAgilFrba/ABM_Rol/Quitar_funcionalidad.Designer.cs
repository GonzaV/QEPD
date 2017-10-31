namespace PagoAgilFrba.ABM_Rol
{
    partial class Quitar_funcionalidad
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.boton_quitar_funcionalidad = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija una funcionalidad a quitar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // boton_quitar_funcionalidad
            // 
            this.boton_quitar_funcionalidad.Location = new System.Drawing.Point(175, 66);
            this.boton_quitar_funcionalidad.Name = "boton_quitar_funcionalidad";
            this.boton_quitar_funcionalidad.Size = new System.Drawing.Size(75, 23);
            this.boton_quitar_funcionalidad.TabIndex = 2;
            this.boton_quitar_funcionalidad.Text = "Quitar";
            this.boton_quitar_funcionalidad.UseVisualStyleBackColor = true;
            this.boton_quitar_funcionalidad.Click += new System.EventHandler(this.boton_quitar_funcionalidad_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Hecho";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Quitar_funcionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.boton_quitar_funcionalidad);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Quitar_funcionalidad";
            this.Text = "Quitar_funcionalidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button boton_quitar_funcionalidad;
        private System.Windows.Forms.Button button2;
    }
}