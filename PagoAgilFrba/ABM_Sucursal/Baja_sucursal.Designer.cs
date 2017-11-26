namespace PagoAgilFrba.ABM_Sucursal
{
    partial class Baja_sucursal
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
            this.textBox_nombreSucursalAEliminar = new System.Windows.Forms.TextBox();
            this.button_cancelarBaja = new System.Windows.Forms.Button();
            this.button_aceptarBaja = new System.Windows.Forms.Button();
            this.textBox_CPSucursalAEliminar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "La siguiente sucursal sera dada de baja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // textBox_nombreSucursalAEliminar
            // 
            this.textBox_nombreSucursalAEliminar.Location = new System.Drawing.Point(101, 47);
            this.textBox_nombreSucursalAEliminar.Name = "textBox_nombreSucursalAEliminar";
            this.textBox_nombreSucursalAEliminar.ReadOnly = true;
            this.textBox_nombreSucursalAEliminar.Size = new System.Drawing.Size(130, 20);
            this.textBox_nombreSucursalAEliminar.TabIndex = 19;
            // 
            // button_cancelarBaja
            // 
            this.button_cancelarBaja.Location = new System.Drawing.Point(146, 118);
            this.button_cancelarBaja.Name = "button_cancelarBaja";
            this.button_cancelarBaja.Size = new System.Drawing.Size(75, 23);
            this.button_cancelarBaja.TabIndex = 16;
            this.button_cancelarBaja.Text = "Cancelar";
            this.button_cancelarBaja.UseVisualStyleBackColor = true;
            this.button_cancelarBaja.Click += new System.EventHandler(this.button_cancelarBaja_Click);
            // 
            // button_aceptarBaja
            // 
            this.button_aceptarBaja.Location = new System.Drawing.Point(54, 118);
            this.button_aceptarBaja.Name = "button_aceptarBaja";
            this.button_aceptarBaja.Size = new System.Drawing.Size(75, 23);
            this.button_aceptarBaja.TabIndex = 15;
            this.button_aceptarBaja.Text = "Aceptar";
            this.button_aceptarBaja.UseVisualStyleBackColor = true;
            // 
            // textBox_CPSucursalAEliminar
            // 
            this.textBox_CPSucursalAEliminar.Location = new System.Drawing.Point(102, 75);
            this.textBox_CPSucursalAEliminar.Name = "textBox_CPSucursalAEliminar";
            this.textBox_CPSucursalAEliminar.ReadOnly = true;
            this.textBox_CPSucursalAEliminar.Size = new System.Drawing.Size(130, 20);
            this.textBox_CPSucursalAEliminar.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Codigo Postal";
            // 
            // Baja_sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_CPSucursalAEliminar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nombreSucursalAEliminar);
            this.Controls.Add(this.button_cancelarBaja);
            this.Controls.Add(this.button_aceptarBaja);
            this.Name = "Baja_sucursal";
            this.Text = "Baja_sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nombreSucursalAEliminar;
        private System.Windows.Forms.Button button_cancelarBaja;
        private System.Windows.Forms.Button button_aceptarBaja;
        private System.Windows.Forms.TextBox textBox_CPSucursalAEliminar;
        private System.Windows.Forms.Label label1;
    }
}