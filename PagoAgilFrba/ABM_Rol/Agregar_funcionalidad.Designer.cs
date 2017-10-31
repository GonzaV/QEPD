namespace PagoAgilFrba.ABM_Rol
{
    partial class Agregar_funcionalidad
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
            this.boton_agregar_funcionalidad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija una funcionalidad a agregar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // boton_agregar_funcionalidad
            // 
            this.boton_agregar_funcionalidad.Location = new System.Drawing.Point(170, 66);
            this.boton_agregar_funcionalidad.Name = "boton_agregar_funcionalidad";
            this.boton_agregar_funcionalidad.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar_funcionalidad.TabIndex = 2;
            this.boton_agregar_funcionalidad.Text = "Agregar";
            this.boton_agregar_funcionalidad.UseVisualStyleBackColor = true;
            this.boton_agregar_funcionalidad.Click += new System.EventHandler(this.boton_agregar_funcionalidad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hecho";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Agregar_funcionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boton_agregar_funcionalidad);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Agregar_funcionalidad";
            this.Text = "Agregar_funcionalidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button boton_agregar_funcionalidad;
        private System.Windows.Forms.Button button1;
    }
}