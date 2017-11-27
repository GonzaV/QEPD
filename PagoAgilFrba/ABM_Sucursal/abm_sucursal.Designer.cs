namespace PagoAgilFrba.ABM_Sucursal
{
    partial class abm_sucursal
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
            this.boton_crear_sucursal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Listado_seleccion_sucursales = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una sucursal a modificar o eliminar:";
            // 
            // boton_crear_sucursal
            // 
            this.boton_crear_sucursal.Location = new System.Drawing.Point(99, 51);
            this.boton_crear_sucursal.Name = "boton_crear_sucursal";
            this.boton_crear_sucursal.Size = new System.Drawing.Size(75, 24);
            this.boton_crear_sucursal.TabIndex = 5;
            this.boton_crear_sucursal.Text = "Crear";
            this.boton_crear_sucursal.UseVisualStyleBackColor = true;
            this.boton_crear_sucursal.Click += new System.EventHandler(this.boton_crear_sucursal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cree una nueva sucursal:";
            // 
            // button_Listado_seleccion_sucursales
            // 
            this.button_Listado_seleccion_sucursales.Location = new System.Drawing.Point(99, 138);
            this.button_Listado_seleccion_sucursales.Name = "button_Listado_seleccion_sucursales";
            this.button_Listado_seleccion_sucursales.Size = new System.Drawing.Size(75, 23);
            this.button_Listado_seleccion_sucursales.TabIndex = 7;
            this.button_Listado_seleccion_sucursales.Text = "Seleccionar";
            this.button_Listado_seleccion_sucursales.UseVisualStyleBackColor = true;
            this.button_Listado_seleccion_sucursales.Click += new System.EventHandler(this.button_Listado_seleccion_sucursales_Click);
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(41, 173);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 8;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // abm_sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 208);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_Listado_seleccion_sucursales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_crear_sucursal);
            this.Controls.Add(this.label1);
            this.Name = "abm_sucursal";
            this.Text = "abm_sucursal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_crear_sucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Listado_seleccion_sucursales;
        private System.Windows.Forms.Button button_volver;
    }
}