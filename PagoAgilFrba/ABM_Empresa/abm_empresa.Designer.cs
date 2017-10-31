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
            this.label_abm_empresa = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_modificar_empresa = new System.Windows.Forms.Button();
            this.boton_eliminar_empresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cree una nueva empresa:";
            // 
            // boton_crear_empresa
            // 
            this.boton_crear_empresa.Location = new System.Drawing.Point(107, 226);
            this.boton_crear_empresa.Name = "boton_crear_empresa";
            this.boton_crear_empresa.Size = new System.Drawing.Size(75, 23);
            this.boton_crear_empresa.TabIndex = 1;
            this.boton_crear_empresa.Text = "Crear";
            this.boton_crear_empresa.UseVisualStyleBackColor = true;
            this.boton_crear_empresa.Click += new System.EventHandler(this.boton_crear_empresa_Click);
            // 
            // label_abm_empresa
            // 
            this.label_abm_empresa.AutoSize = true;
            this.label_abm_empresa.Location = new System.Drawing.Point(23, 19);
            this.label_abm_empresa.Name = "label_abm_empresa";
            this.label_abm_empresa.Size = new System.Drawing.Size(228, 13);
            this.label_abm_empresa.TabIndex = 2;
            this.label_abm_empresa.Text = "Seleccione una empresa a modificar o eliminar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Esto es temporal, no se hace con selector";
            // 
            // boton_modificar_empresa
            // 
            this.boton_modificar_empresa.Location = new System.Drawing.Point(69, 107);
            this.boton_modificar_empresa.Name = "boton_modificar_empresa";
            this.boton_modificar_empresa.Size = new System.Drawing.Size(75, 23);
            this.boton_modificar_empresa.TabIndex = 5;
            this.boton_modificar_empresa.Text = "Modificar";
            this.boton_modificar_empresa.UseVisualStyleBackColor = true;
            this.boton_modificar_empresa.Click += new System.EventHandler(this.boton_modificar_empresa_Click);
            // 
            // boton_eliminar_empresa
            // 
            this.boton_eliminar_empresa.Location = new System.Drawing.Point(199, 107);
            this.boton_eliminar_empresa.Name = "boton_eliminar_empresa";
            this.boton_eliminar_empresa.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar_empresa.TabIndex = 6;
            this.boton_eliminar_empresa.Text = "Eliminar";
            this.boton_eliminar_empresa.UseVisualStyleBackColor = true;
            // 
            // abm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.boton_eliminar_empresa);
            this.Controls.Add(this.boton_modificar_empresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_abm_empresa);
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
        private System.Windows.Forms.Label label_abm_empresa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_modificar_empresa;
        private System.Windows.Forms.Button boton_eliminar_empresa;
    }
}