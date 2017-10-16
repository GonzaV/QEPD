namespace PagoAgilFrba.Login_Seguridad.SeleccionRol
{
    partial class SeleccionRol
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
            this.selectorDeRol = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Rol";
            // 
            // selectorDeRol
            // 
            this.selectorDeRol.FormattingEnabled = true;
            this.selectorDeRol.Location = new System.Drawing.Point(46, 49);
            this.selectorDeRol.Name = "selectorDeRol";
            this.selectorDeRol.Size = new System.Drawing.Size(188, 24);
            this.selectorDeRol.TabIndex = 1;
            this.selectorDeRol.SelectedIndexChanged += new System.EventHandler(this.selectorDeRol_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(93, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SeleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectorDeRol);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionRol";
            this.Text = "SeleccionRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectorDeRol;
        private System.Windows.Forms.Button button1;
    }
}