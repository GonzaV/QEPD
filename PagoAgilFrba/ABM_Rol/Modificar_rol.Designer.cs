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
            this.boton_modificar = new System.Windows.Forms.Button();
            this.checkBox_habilitar = new System.Windows.Forms.CheckBox();
            this.checkBox_inhabilitar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boton_cancelar = new System.Windows.Forms.Button();
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
            this.boton_eliminar_funcionalidad.Text = "Quitar";
            this.boton_eliminar_funcionalidad.UseVisualStyleBackColor = true;
            this.boton_eliminar_funcionalidad.Click += new System.EventHandler(this.boton_eliminar_funcionalidad_Click);
            // 
            // boton_modificar
            // 
            this.boton_modificar.Location = new System.Drawing.Point(135, 296);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(75, 23);
            this.boton_modificar.TabIndex = 6;
            this.boton_modificar.Text = "Modificar";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // checkBox_habilitar
            // 
            this.checkBox_habilitar.AutoSize = true;
            this.checkBox_habilitar.Location = new System.Drawing.Point(16, 245);
            this.checkBox_habilitar.Name = "checkBox_habilitar";
            this.checkBox_habilitar.Size = new System.Drawing.Size(64, 17);
            this.checkBox_habilitar.TabIndex = 7;
            this.checkBox_habilitar.Text = "Habilitar";
            this.checkBox_habilitar.UseVisualStyleBackColor = true;
            // 
            // checkBox_inhabilitar
            // 
            this.checkBox_inhabilitar.AutoSize = true;
            this.checkBox_inhabilitar.Location = new System.Drawing.Point(135, 245);
            this.checkBox_inhabilitar.Name = "checkBox_inhabilitar";
            this.checkBox_inhabilitar.Size = new System.Drawing.Size(71, 17);
            this.checkBox_inhabilitar.TabIndex = 8;
            this.checkBox_inhabilitar.Text = "Inhabilitar";
            this.checkBox_inhabilitar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Habilite/Inhabilite el rol:";
            // 
            // boton_cancelar
            // 
            this.boton_cancelar.Location = new System.Drawing.Point(16, 296);
            this.boton_cancelar.Name = "boton_cancelar";
            this.boton_cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boton_cancelar.Size = new System.Drawing.Size(75, 23);
            this.boton_cancelar.TabIndex = 10;
            this.boton_cancelar.Text = "Cancelar";
            this.boton_cancelar.UseVisualStyleBackColor = true;
            this.boton_cancelar.Click += new System.EventHandler(this.boton_cancelar_Click);
            // 
            // Modificar_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 343);
            this.Controls.Add(this.boton_cancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_inhabilitar);
            this.Controls.Add(this.checkBox_habilitar);
            this.Controls.Add(this.boton_modificar);
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
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.CheckBox checkBox_habilitar;
        private System.Windows.Forms.CheckBox checkBox_inhabilitar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button boton_cancelar;
    }
}