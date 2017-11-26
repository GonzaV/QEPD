namespace PagoAgilFrba.ABM_Cliente
{
    partial class Baja_cliente
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
            this.button_aceptarBaja = new System.Windows.Forms.Button();
            this.button_cancelarBaja = new System.Windows.Forms.Button();
            this.textBox_DNIClienteAEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_aceptarBaja
            // 
            this.button_aceptarBaja.Location = new System.Drawing.Point(48, 134);
            this.button_aceptarBaja.Name = "button_aceptarBaja";
            this.button_aceptarBaja.Size = new System.Drawing.Size(75, 23);
            this.button_aceptarBaja.TabIndex = 0;
            this.button_aceptarBaja.Text = "Aceptar";
            this.button_aceptarBaja.UseVisualStyleBackColor = true;
            // 
            // button_cancelarBaja
            // 
            this.button_cancelarBaja.Location = new System.Drawing.Point(160, 134);
            this.button_cancelarBaja.Name = "button_cancelarBaja";
            this.button_cancelarBaja.Size = new System.Drawing.Size(75, 23);
            this.button_cancelarBaja.TabIndex = 1;
            this.button_cancelarBaja.Text = "Cancelar";
            this.button_cancelarBaja.UseVisualStyleBackColor = true;
            this.button_cancelarBaja.Click += new System.EventHandler(this.button_cancelarBaja_Click);
            // 
            // textBox_DNIClienteAEliminar
            // 
            this.textBox_DNIClienteAEliminar.Location = new System.Drawing.Point(95, 38);
            this.textBox_DNIClienteAEliminar.Name = "textBox_DNIClienteAEliminar";
            this.textBox_DNIClienteAEliminar.ReadOnly = true;
            this.textBox_DNIClienteAEliminar.Size = new System.Drawing.Size(130, 20);
            this.textBox_DNIClienteAEliminar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "El siguiente cliente sera dado de baja:";
            // 
            // Baja_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_DNIClienteAEliminar);
            this.Controls.Add(this.button_cancelarBaja);
            this.Controls.Add(this.button_aceptarBaja);
            this.Name = "Baja_cliente";
            this.Text = "Baja_cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_aceptarBaja;
        private System.Windows.Forms.Button button_cancelarBaja;
        private System.Windows.Forms.TextBox textBox_DNIClienteAEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}