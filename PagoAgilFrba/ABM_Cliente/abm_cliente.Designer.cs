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
            this.comboBox_clientes = new System.Windows.Forms.ComboBox();
            this.label_abm_cliente = new System.Windows.Forms.Label();
            this.boton_modificar_cliente = new System.Windows.Forms.Button();
            this.boton_eliminar_cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_crear_cliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_clientes
            // 
            this.comboBox_clientes.FormattingEnabled = true;
            this.comboBox_clientes.Location = new System.Drawing.Point(26, 63);
            this.comboBox_clientes.Name = "comboBox_clientes";
            this.comboBox_clientes.Size = new System.Drawing.Size(121, 21);
            this.comboBox_clientes.TabIndex = 0;
            this.comboBox_clientes.SelectedIndexChanged += new System.EventHandler(this.comboBox_clientes_SelectedIndexChanged);
            // 
            // label_abm_cliente
            // 
            this.label_abm_cliente.AutoSize = true;
            this.label_abm_cliente.Location = new System.Drawing.Point(23, 29);
            this.label_abm_cliente.Name = "label_abm_cliente";
            this.label_abm_cliente.Size = new System.Drawing.Size(213, 13);
            this.label_abm_cliente.TabIndex = 1;
            this.label_abm_cliente.Text = "Seleccione un cliente a modificar o eliminar:";
            // 
            // boton_modificar_cliente
            // 
            this.boton_modificar_cliente.Location = new System.Drawing.Point(48, 110);
            this.boton_modificar_cliente.Name = "boton_modificar_cliente";
            this.boton_modificar_cliente.Size = new System.Drawing.Size(75, 23);
            this.boton_modificar_cliente.TabIndex = 2;
            this.boton_modificar_cliente.Text = "Modificar";
            this.boton_modificar_cliente.UseVisualStyleBackColor = true;
            this.boton_modificar_cliente.Click += new System.EventHandler(this.boton_modificar_cliente_Click);
            // 
            // boton_eliminar_cliente
            // 
            this.boton_eliminar_cliente.Location = new System.Drawing.Point(172, 110);
            this.boton_eliminar_cliente.Name = "boton_eliminar_cliente";
            this.boton_eliminar_cliente.Size = new System.Drawing.Size(75, 23);
            this.boton_eliminar_cliente.TabIndex = 3;
            this.boton_eliminar_cliente.Text = "Eliminar";
            this.boton_eliminar_cliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cree un nuevo cliente:";
            // 
            // boton_crear_cliente
            // 
            this.boton_crear_cliente.Location = new System.Drawing.Point(111, 211);
            this.boton_crear_cliente.Name = "boton_crear_cliente";
            this.boton_crear_cliente.Size = new System.Drawing.Size(75, 23);
            this.boton_crear_cliente.TabIndex = 5;
            this.boton_crear_cliente.Text = "Crear";
            this.boton_crear_cliente.UseVisualStyleBackColor = true;
            this.boton_crear_cliente.Click += new System.EventHandler(this.boton_crear_cliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Esto es temporal, no se hace con selector";
            // 
            // abm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_crear_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_eliminar_cliente);
            this.Controls.Add(this.boton_modificar_cliente);
            this.Controls.Add(this.label_abm_cliente);
            this.Controls.Add(this.comboBox_clientes);
            this.Name = "abm_cliente";
            this.Text = "abm_cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_clientes;
        private System.Windows.Forms.Label label_abm_cliente;
        private System.Windows.Forms.Button boton_modificar_cliente;
        private System.Windows.Forms.Button boton_eliminar_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_crear_cliente;
        private System.Windows.Forms.Label label2;
    }
}