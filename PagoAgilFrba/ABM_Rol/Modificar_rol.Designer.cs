namespace PagoAgilFrba.ABM_Rol
{
    partial class Modificar_rol
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.boton_agregar_funcionalidad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boton_eliminar_funcionalidad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos que desee reemplazar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(66, 62);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 2;
            // 
            // boton_agregar_funcionalidad
            // 
            this.boton_agregar_funcionalidad.Location = new System.Drawing.Point(16, 163);
            this.boton_agregar_funcionalidad.Name = "boton_agregar_funcionalidad";
            this.boton_agregar_funcionalidad.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar_funcionalidad.TabIndex = 3;
            this.boton_agregar_funcionalidad.Text = "Agregar";
            this.boton_agregar_funcionalidad.UseVisualStyleBackColor = true;
            this.boton_agregar_funcionalidad.Click += new System.EventHandler(this.boton_agregar_funcionalidad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agregue o quite funcionalidades:";
            // 
            // boton_eliminar_funcionalidad
            // 
            this.boton_eliminar_funcionalidad.Location = new System.Drawing.Point(135, 163);
            this.boton_eliminar_funcionalidad.Name = "boton_eliminar_funcionalidad";
            this.boton_eliminar_funcionalidad.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar_funcionalidad.TabIndex = 5;
            this.boton_eliminar_funcionalidad.Text = "Eliminar";
            this.boton_eliminar_funcionalidad.UseVisualStyleBackColor = true;
            this.boton_eliminar_funcionalidad.Click += new System.EventHandler(this.boton_eliminar_funcionalidad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Modificar_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boton_eliminar_funcionalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton_agregar_funcionalidad);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modificar_rol";
            this.Text = "Modificar_rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Button boton_agregar_funcionalidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button boton_eliminar_funcionalidad;
        private System.Windows.Forms.Button button1;
    }
}