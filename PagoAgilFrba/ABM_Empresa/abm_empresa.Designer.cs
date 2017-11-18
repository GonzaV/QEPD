namespace PagoAgilFrba.ABM_Empresa
{
    partial class abm_empresa
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
            this.boton_crear_empresa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Listado_seleccion_empresas = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cree una nueva empresa:";
            // 
            // boton_crear_empresa
            // 
            this.boton_crear_empresa.Location = new System.Drawing.Point(118, 46);
            this.boton_crear_empresa.Name = "boton_crear_empresa";
            this.boton_crear_empresa.Size = new System.Drawing.Size(75, 23);
            this.boton_crear_empresa.TabIndex = 1;
            this.boton_crear_empresa.Text = "Crear";
            this.boton_crear_empresa.UseVisualStyleBackColor = true;
            this.boton_crear_empresa.Click += new System.EventHandler(this.boton_crear_empresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione una empresa a modificar o eliminar";
            // 
            // button_Listado_seleccion_empresas
            // 
            this.button_Listado_seleccion_empresas.Location = new System.Drawing.Point(116, 112);
            this.button_Listado_seleccion_empresas.Name = "button_Listado_seleccion_empresas";
            this.button_Listado_seleccion_empresas.Size = new System.Drawing.Size(75, 23);
            this.button_Listado_seleccion_empresas.TabIndex = 8;
            this.button_Listado_seleccion_empresas.Text = "Seleccionar";
            this.button_Listado_seleccion_empresas.UseVisualStyleBackColor = true;
            this.button_Listado_seleccion_empresas.Click += new System.EventHandler(this.button_Listado_seleccion_empresas_Click);
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(29, 164);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 9;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // abm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 209);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_Listado_seleccion_empresas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_crear_empresa);
            this.Controls.Add(this.label1);
            this.Name = "abm_empresa";
            this.Text = "abm_empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_crear_empresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Listado_seleccion_empresas;
        private System.Windows.Forms.Button button_volver;
    }
}