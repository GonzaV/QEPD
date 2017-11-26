namespace PagoAgilFrba.Rendiciones
{
    partial class Form_rendicion
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
            this.comboBox_empresasParaRendir = new System.Windows.Forms.ComboBox();
            this.button_rendir = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresas a rendir el dia de hoy:";
            // 
            // comboBox_empresasParaRendir
            // 
            this.comboBox_empresasParaRendir.FormattingEnabled = true;
            this.comboBox_empresasParaRendir.Location = new System.Drawing.Point(41, 67);
            this.comboBox_empresasParaRendir.Name = "comboBox_empresasParaRendir";
            this.comboBox_empresasParaRendir.Size = new System.Drawing.Size(194, 21);
            this.comboBox_empresasParaRendir.TabIndex = 1;
            // 
            // button_rendir
            // 
            this.button_rendir.Location = new System.Drawing.Point(71, 104);
            this.button_rendir.Name = "button_rendir";
            this.button_rendir.Size = new System.Drawing.Size(137, 23);
            this.button_rendir.TabIndex = 2;
            this.button_rendir.Text = "Ejecutar Rendicion";
            this.button_rendir.UseVisualStyleBackColor = true;
            this.button_rendir.Click += new System.EventHandler(this.button_rendir_Click);
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(27, 148);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 3;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // Form_rendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_rendir);
            this.Controls.Add(this.comboBox_empresasParaRendir);
            this.Controls.Add(this.label1);
            this.Name = "Form_rendicion";
            this.Text = "Form_rendicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_empresasParaRendir;
        private System.Windows.Forms.Button button_rendir;
        private System.Windows.Forms.Button button_volver;
    }
}