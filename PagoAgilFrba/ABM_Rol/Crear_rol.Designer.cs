﻿namespace PagoAgilFrba.ABM_Rol
{
    partial class Crear_rol
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.boton_agregar_funcionalidad = new System.Windows.Forms.Button();
            this.boton_crear_rol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos del nuevo rol (todos los campos son obligatorios):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Funcionalidad:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(103, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // boton_agregar_funcionalidad
            // 
            this.boton_agregar_funcionalidad.Location = new System.Drawing.Point(253, 92);
            this.boton_agregar_funcionalidad.Name = "boton_agregar_funcionalidad";
            this.boton_agregar_funcionalidad.Size = new System.Drawing.Size(75, 23);
            this.boton_agregar_funcionalidad.TabIndex = 5;
            this.boton_agregar_funcionalidad.Text = "Agregar";
            this.boton_agregar_funcionalidad.UseVisualStyleBackColor = true;
            this.boton_agregar_funcionalidad.Click += new System.EventHandler(this.boton_agregar_funcionalidad_Click);
            // 
            // boton_crear_rol
            // 
            this.boton_crear_rol.Location = new System.Drawing.Point(253, 177);
            this.boton_crear_rol.Name = "boton_crear_rol";
            this.boton_crear_rol.Size = new System.Drawing.Size(75, 23);
            this.boton_crear_rol.TabIndex = 6;
            this.boton_crear_rol.Text = "Crear";
            this.boton_crear_rol.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TOCAR BOTON AGREGAR PARA ENTENDER EL FUNCIONAMIENTO";
            // 
            // Crear_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 229);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boton_crear_rol);
            this.Controls.Add(this.boton_agregar_funcionalidad);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Crear_rol";
            this.Text = "Crear_rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button boton_agregar_funcionalidad;
        private System.Windows.Forms.Button boton_crear_rol;
        private System.Windows.Forms.Label label4;
    }
}