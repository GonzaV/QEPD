namespace PagoAgilFrba.Login
{
    partial class Seleccion_funcionalidades_admin
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_abm_empresa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_abm_sucursales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altas, bajas y modificaciones de roles de usuario";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "ABM Rol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.boton_abm_rol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altas, bajas y modiciaciones de empresas";
            // 
            // button_abm_empresa
            // 
            this.button_abm_empresa.Location = new System.Drawing.Point(97, 144);
            this.button_abm_empresa.Name = "button_abm_empresa";
            this.button_abm_empresa.Size = new System.Drawing.Size(95, 23);
            this.button_abm_empresa.TabIndex = 3;
            this.button_abm_empresa.Text = "ABM Empresa";
            this.button_abm_empresa.UseVisualStyleBackColor = true;
            this.button_abm_empresa.Click += new System.EventHandler(this.button_abm_empresa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Altas, bajas y modificaciones de sucursales:";
            // 
            // boton_abm_sucursales
            // 
            this.boton_abm_sucursales.Location = new System.Drawing.Point(97, 241);
            this.boton_abm_sucursales.Name = "boton_abm_sucursales";
            this.boton_abm_sucursales.Size = new System.Drawing.Size(95, 23);
            this.boton_abm_sucursales.TabIndex = 5;
            this.boton_abm_sucursales.Text = "ABM Sucursales";
            this.boton_abm_sucursales.UseVisualStyleBackColor = true;
            this.boton_abm_sucursales.Click += new System.EventHandler(this.boton_abm_sucursales_Click);
            // 
            // Seleccion_funcionalidades_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 285);
            this.Controls.Add(this.boton_abm_sucursales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_abm_empresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Seleccion_funcionalidades_admin";
            this.Text = "Seleccion_funcionalidades_admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_abm_empresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_abm_sucursales;
    }
}