namespace PagoAgilFrba.ABM_Empresa
{
    partial class Baja_empresa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nombreEmpresaAEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CUITempresaAEliminar = new System.Windows.Forms.TextBox();
            this.button_cancelarBaja = new System.Windows.Forms.Button();
            this.button_aceptarBaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "La siguiente empresa sera dada de baja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // textBox_nombreEmpresaAEliminar
            // 
            this.textBox_nombreEmpresaAEliminar.Location = new System.Drawing.Point(97, 107);
            this.textBox_nombreEmpresaAEliminar.Name = "textBox_nombreEmpresaAEliminar";
            this.textBox_nombreEmpresaAEliminar.ReadOnly = true;
            this.textBox_nombreEmpresaAEliminar.Size = new System.Drawing.Size(130, 20);
            this.textBox_nombreEmpresaAEliminar.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "CUIT";
            // 
            // textBox_CUITempresaAEliminar
            // 
            this.textBox_CUITempresaAEliminar.Location = new System.Drawing.Point(97, 64);
            this.textBox_CUITempresaAEliminar.Name = "textBox_CUITempresaAEliminar";
            this.textBox_CUITempresaAEliminar.ReadOnly = true;
            this.textBox_CUITempresaAEliminar.Size = new System.Drawing.Size(130, 20);
            this.textBox_CUITempresaAEliminar.TabIndex = 10;
            // 
            // button_cancelarBaja
            // 
            this.button_cancelarBaja.Location = new System.Drawing.Point(162, 160);
            this.button_cancelarBaja.Name = "button_cancelarBaja";
            this.button_cancelarBaja.Size = new System.Drawing.Size(75, 23);
            this.button_cancelarBaja.TabIndex = 9;
            this.button_cancelarBaja.Text = "Cancelar";
            this.button_cancelarBaja.UseVisualStyleBackColor = true;
            this.button_cancelarBaja.Click += new System.EventHandler(this.button_cancelarBaja_Click);
            // 
            // button_aceptarBaja
            // 
            this.button_aceptarBaja.Location = new System.Drawing.Point(50, 160);
            this.button_aceptarBaja.Name = "button_aceptarBaja";
            this.button_aceptarBaja.Size = new System.Drawing.Size(75, 23);
            this.button_aceptarBaja.TabIndex = 8;
            this.button_aceptarBaja.Text = "Aceptar";
            this.button_aceptarBaja.UseVisualStyleBackColor = true;
            // 
            // Baja_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nombreEmpresaAEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CUITempresaAEliminar);
            this.Controls.Add(this.button_cancelarBaja);
            this.Controls.Add(this.button_aceptarBaja);
            this.Name = "Baja_empresa";
            this.Text = "Baja_empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nombreEmpresaAEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CUITempresaAEliminar;
        private System.Windows.Forms.Button button_cancelarBaja;
        private System.Windows.Forms.Button button_aceptarBaja;
    }
}