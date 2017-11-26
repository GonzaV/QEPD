namespace PagoAgilFrba.ABM_Cliente
{
    partial class abm_cliente
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
            this.label_abm_cliente = new System.Windows.Forms.Label();
            this.boton_modificar_cliente = new System.Windows.Forms.Button();
            this.boton_crear_cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_abm_cliente
            // 
            this.label_abm_cliente.AutoSize = true;
            this.label_abm_cliente.Location = new System.Drawing.Point(60, 35);
            this.label_abm_cliente.Name = "label_abm_cliente";
            this.label_abm_cliente.Size = new System.Drawing.Size(148, 13);
            this.label_abm_cliente.TabIndex = 1;
            this.label_abm_cliente.Text = "Seleccione un cliente a crear:";
            // 
            // boton_modificar_cliente
            // 
            this.boton_modificar_cliente.Location = new System.Drawing.Point(63, 123);
            this.boton_modificar_cliente.Name = "boton_modificar_cliente";
            this.boton_modificar_cliente.Size = new System.Drawing.Size(136, 23);
            this.boton_modificar_cliente.TabIndex = 2;
            this.boton_modificar_cliente.Text = "Baja y Modificacion";
            this.boton_modificar_cliente.UseVisualStyleBackColor = true;
            this.boton_modificar_cliente.Click += new System.EventHandler(this.boton_modificar_cliente_Click);
            // 
            // boton_crear_cliente
            // 
            this.boton_crear_cliente.Location = new System.Drawing.Point(97, 51);
            this.boton_crear_cliente.Name = "boton_crear_cliente";
            this.boton_crear_cliente.Size = new System.Drawing.Size(75, 23);
            this.boton_crear_cliente.TabIndex = 5;
            this.boton_crear_cliente.Text = "Crear";
            this.boton_crear_cliente.UseVisualStyleBackColor = true;
            this.boton_crear_cliente.Click += new System.EventHandler(this.boton_crear_cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione un cliente a modificar o eliminar:";
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(22, 178);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 8;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // abm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 208);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_crear_cliente);
            this.Controls.Add(this.boton_modificar_cliente);
            this.Controls.Add(this.label_abm_cliente);
            this.Name = "abm_cliente";
            this.Text = "abm_cliente";
            this.Load += new System.EventHandler(this.abm_cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_abm_cliente;
        private System.Windows.Forms.Button boton_modificar_cliente;
        private System.Windows.Forms.Button boton_crear_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_volver;
    }
}