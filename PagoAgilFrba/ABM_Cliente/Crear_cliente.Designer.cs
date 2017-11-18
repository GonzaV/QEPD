namespace PagoAgilFrba.ABM_Cliente
{
    partial class Crear_cliente
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
            this.label_crear_cliente = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_dni = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_dni = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label_fecha_nac = new System.Windows.Forms.Label();
            this.textBox_fnacimiento = new System.Windows.Forms.TextBox();
            this.button_crearCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.label_direccion = new System.Windows.Forms.Label();
            this.textBox_cp = new System.Windows.Forms.TextBox();
            this.label_cp = new System.Windows.Forms.Label();
            this.button_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_crear_cliente
            // 
            this.label_crear_cliente.AutoSize = true;
            this.label_crear_cliente.Location = new System.Drawing.Point(27, 13);
            this.label_crear_cliente.Name = "label_crear_cliente";
            this.label_crear_cliente.Size = new System.Drawing.Size(330, 13);
            this.label_crear_cliente.TabIndex = 0;
            this.label_crear_cliente.Text = "Ingrese los datos del nuevo cliente (todos los datos son obligatorios):";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(27, 83);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(47, 13);
            this.label_apellido.TabIndex = 1;
            this.label_apellido.Text = "Apellido:";
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.Location = new System.Drawing.Point(27, 116);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(29, 13);
            this.label_dni.TabIndex = 2;
            this.label_dni.Text = "DNI:";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(27, 149);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(29, 13);
            this.label_mail.TabIndex = 3;
            this.label_mail.Text = "Mail:";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Location = new System.Drawing.Point(27, 182);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(52, 13);
            this.label_telefono.TabIndex = 4;
            this.label_telefono.Text = "Teléfono:";
            this.label_telefono.Click += new System.EventHandler(this.label_telefono_Click);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(27, 48);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(47, 13);
            this.label_nombre.TabIndex = 5;
            this.label_nombre.Text = "Nombre:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(108, 45);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 6;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(108, 80);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_apellido.TabIndex = 7;
            // 
            // textBox_dni
            // 
            this.textBox_dni.Location = new System.Drawing.Point(108, 113);
            this.textBox_dni.Name = "textBox_dni";
            this.textBox_dni.Size = new System.Drawing.Size(100, 20);
            this.textBox_dni.TabIndex = 8;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(108, 146);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(100, 20);
            this.textBox_mail.TabIndex = 9;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(108, 179);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(100, 20);
            this.textBox_telefono.TabIndex = 10;
            // 
            // label_fecha_nac
            // 
            this.label_fecha_nac.AutoSize = true;
            this.label_fecha_nac.Location = new System.Drawing.Point(27, 215);
            this.label_fecha_nac.Name = "label_fecha_nac";
            this.label_fecha_nac.Size = new System.Drawing.Size(75, 13);
            this.label_fecha_nac.TabIndex = 11;
            this.label_fecha_nac.Text = "F. Nacimiento:";
            // 
            // textBox_fnacimiento
            // 
            this.textBox_fnacimiento.Location = new System.Drawing.Point(108, 212);
            this.textBox_fnacimiento.Name = "textBox_fnacimiento";
            this.textBox_fnacimiento.Size = new System.Drawing.Size(100, 20);
            this.textBox_fnacimiento.TabIndex = 12;
            // 
            // button_crearCliente
            // 
            this.button_crearCliente.Location = new System.Drawing.Point(282, 363);
            this.button_crearCliente.Name = "button_crearCliente";
            this.button_crearCliente.Size = new System.Drawing.Size(75, 23);
            this.button_crearCliente.TabIndex = 13;
            this.button_crearCliente.Text = "Crear";
            this.button_crearCliente.UseVisualStyleBackColor = true;
            this.button_crearCliente.Click += new System.EventHandler(this.button_crearCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Direccion calle nro piso depto y localidad";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(408, 398);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 78;
            this.lineShape1.X2 = 327;
            this.lineShape1.Y1 = 253;
            this.lineShape1.Y2 = 253;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(148, 290);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(100, 20);
            this.textBox_direccion.TabIndex = 17;
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(68, 292);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(55, 13);
            this.label_direccion.TabIndex = 16;
            this.label_direccion.Text = "Direccion:";
            this.label_direccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_cp
            // 
            this.textBox_cp.Location = new System.Drawing.Point(148, 326);
            this.textBox_cp.Name = "textBox_cp";
            this.textBox_cp.Size = new System.Drawing.Size(100, 20);
            this.textBox_cp.TabIndex = 19;
            // 
            // label_cp
            // 
            this.label_cp.AutoSize = true;
            this.label_cp.Location = new System.Drawing.Point(68, 328);
            this.label_cp.Name = "label_cp";
            this.label_cp.Size = new System.Drawing.Size(72, 13);
            this.label_cp.TabIndex = 18;
            this.label_cp.Text = "Código Postal";
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(48, 363);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 20;
            this.button_volver.Text = "Cancelar";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // Crear_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 398);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.textBox_cp);
            this.Controls.Add(this.label_cp);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_crearCliente);
            this.Controls.Add(this.textBox_fnacimiento);
            this.Controls.Add(this.label_fecha_nac);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_dni);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.label_dni);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_crear_cliente);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Crear_cliente";
            this.Text = "Crear_cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_crear_cliente;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_dni;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label_fecha_nac;
        private System.Windows.Forms.TextBox textBox_fnacimiento;
        private System.Windows.Forms.Button button_crearCliente;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.TextBox textBox_cp;
        private System.Windows.Forms.Label label_cp;
        private System.Windows.Forms.Button button_volver;
    }
}