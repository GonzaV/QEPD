namespace PagoAgilFrba.ABM_Rol
{
    partial class abm_rol
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boton_eliminar_rol = new System.Windows.Forms.Button();
            this.boton_modificar_rol = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_crear_rol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un rol a modificar o eliminar:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Esto si se hace con un selector";
            // 
            // boton_eliminar_rol
            // 
            this.boton_eliminar_rol.Location = new System.Drawing.Point(130, 109);
            this.boton_eliminar_rol.Name = "boton_eliminar_rol";
            this.boton_eliminar_rol.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar_rol.TabIndex = 3;
            this.boton_eliminar_rol.Text = "Eliminar";
            this.boton_eliminar_rol.UseVisualStyleBackColor = true;
            // 
            // boton_modificar_rol
            // 
            this.boton_modificar_rol.Location = new System.Drawing.Point(16, 109);
            this.boton_modificar_rol.Name = "boton_modificar_rol";
            this.boton_modificar_rol.Size = new System.Drawing.Size(75, 23);
            this.boton_modificar_rol.TabIndex = 4;
            this.boton_modificar_rol.Text = "Modificar";
            this.boton_modificar_rol.UseVisualStyleBackColor = true;
            this.boton_modificar_rol.Click += new System.EventHandler(this.boton_modificar_rol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crear un nuevo rol:";
            // 
            // boton_crear_rol
            // 
            this.boton_crear_rol.Location = new System.Drawing.Point(110, 215);
            this.boton_crear_rol.Name = "boton_crear_rol";
            this.boton_crear_rol.Size = new System.Drawing.Size(75, 23);
            this.boton_crear_rol.TabIndex = 6;
            this.boton_crear_rol.Text = "Crear";
            this.boton_crear_rol.UseVisualStyleBackColor = true;
            this.boton_crear_rol.Click += new System.EventHandler(this.boton_crear_rol_Click);
            // 
            // abm_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 261);
            this.Controls.Add(this.boton_crear_rol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_modificar_rol);
            this.Controls.Add(this.boton_eliminar_rol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "abm_rol";
            this.Text = "abm_rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boton_eliminar_rol;
        private System.Windows.Forms.Button boton_modificar_rol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_crear_rol;
    }
}