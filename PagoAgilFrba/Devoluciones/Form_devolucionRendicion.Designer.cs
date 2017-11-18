namespace PagoAgilFrba.Devoluciones
{
    partial class Form_devolucionRendicion
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
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_filtroFechaRendicion = new System.Windows.Forms.TextBox();
            this.textBox_filtroEmpresa = new System.Windows.Forms.TextBox();
            this.label_filtroFechaRendicion = new System.Windows.Forms.Label();
            this.label_filtroNombreRendicion = new System.Windows.Forms.Label();
            this.label_filtroRendicion = new System.Windows.Forms.Label();
            this.button_devolucionRendicion = new System.Windows.Forms.Button();
            this.label_devolucionRendicion = new System.Windows.Forms.Label();
            this.richTextBox_devolucionRendicion = new System.Windows.Forms.RichTextBox();
            this.button_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 291;
            this.lineShape1.Y1 = 139;
            this.lineShape1.Y2 = 139;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(800, 341);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 237);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox_filtroFechaRendicion
            // 
            this.textBox_filtroFechaRendicion.Location = new System.Drawing.Point(150, 97);
            this.textBox_filtroFechaRendicion.Name = "textBox_filtroFechaRendicion";
            this.textBox_filtroFechaRendicion.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtroFechaRendicion.TabIndex = 10;
            // 
            // textBox_filtroEmpresa
            // 
            this.textBox_filtroEmpresa.Location = new System.Drawing.Point(150, 62);
            this.textBox_filtroEmpresa.Name = "textBox_filtroEmpresa";
            this.textBox_filtroEmpresa.Size = new System.Drawing.Size(100, 20);
            this.textBox_filtroEmpresa.TabIndex = 9;
            // 
            // label_filtroFechaRendicion
            // 
            this.label_filtroFechaRendicion.AutoSize = true;
            this.label_filtroFechaRendicion.Location = new System.Drawing.Point(23, 100);
            this.label_filtroFechaRendicion.Name = "label_filtroFechaRendicion";
            this.label_filtroFechaRendicion.Size = new System.Drawing.Size(70, 13);
            this.label_filtroFechaRendicion.TabIndex = 8;
            this.label_filtroFechaRendicion.Text = "Buscar fecha";
            // 
            // label_filtroNombreRendicion
            // 
            this.label_filtroNombreRendicion.AutoSize = true;
            this.label_filtroNombreRendicion.Location = new System.Drawing.Point(23, 65);
            this.label_filtroNombreRendicion.Name = "label_filtroNombreRendicion";
            this.label_filtroNombreRendicion.Size = new System.Drawing.Size(121, 13);
            this.label_filtroNombreRendicion.TabIndex = 7;
            this.label_filtroNombreRendicion.Text = "Buscar nombre empresa";
            // 
            // label_filtroRendicion
            // 
            this.label_filtroRendicion.AutoSize = true;
            this.label_filtroRendicion.Location = new System.Drawing.Point(21, 23);
            this.label_filtroRendicion.Name = "label_filtroRendicion";
            this.label_filtroRendicion.Size = new System.Drawing.Size(94, 13);
            this.label_filtroRendicion.TabIndex = 6;
            this.label_filtroRendicion.Text = "Filtro de busqueda";
            // 
            // button_devolucionRendicion
            // 
            this.button_devolucionRendicion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_devolucionRendicion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_devolucionRendicion.Location = new System.Drawing.Point(26, 254);
            this.button_devolucionRendicion.Name = "button_devolucionRendicion";
            this.button_devolucionRendicion.Size = new System.Drawing.Size(184, 23);
            this.button_devolucionRendicion.TabIndex = 13;
            this.button_devolucionRendicion.Text = "Devolver monto rendido";
            this.button_devolucionRendicion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_devolucionRendicion.UseVisualStyleBackColor = false;
            // 
            // label_devolucionRendicion
            // 
            this.label_devolucionRendicion.AutoSize = true;
            this.label_devolucionRendicion.Enabled = false;
            this.label_devolucionRendicion.Location = new System.Drawing.Point(23, 160);
            this.label_devolucionRendicion.Name = "label_devolucionRendicion";
            this.label_devolucionRendicion.Size = new System.Drawing.Size(94, 13);
            this.label_devolucionRendicion.TabIndex = 12;
            this.label_devolucionRendicion.Text = "Motivo devolucion";
            // 
            // richTextBox_devolucionRendicion
            // 
            this.richTextBox_devolucionRendicion.Location = new System.Drawing.Point(26, 176);
            this.richTextBox_devolucionRendicion.Name = "richTextBox_devolucionRendicion";
            this.richTextBox_devolucionRendicion.Size = new System.Drawing.Size(184, 57);
            this.richTextBox_devolucionRendicion.TabIndex = 11;
            this.richTextBox_devolucionRendicion.Text = "";
            // 
            // button_volver
            // 
            this.button_volver.Location = new System.Drawing.Point(26, 296);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 14;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // Form_devolucionRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_devolucionRendicion);
            this.Controls.Add(this.label_devolucionRendicion);
            this.Controls.Add(this.richTextBox_devolucionRendicion);
            this.Controls.Add(this.textBox_filtroFechaRendicion);
            this.Controls.Add(this.textBox_filtroEmpresa);
            this.Controls.Add(this.label_filtroFechaRendicion);
            this.Controls.Add(this.label_filtroNombreRendicion);
            this.Controls.Add(this.label_filtroRendicion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form_devolucionRendicion";
            this.Text = "Form_devolucionRendicion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_filtroFechaRendicion;
        private System.Windows.Forms.TextBox textBox_filtroEmpresa;
        private System.Windows.Forms.Label label_filtroFechaRendicion;
        private System.Windows.Forms.Label label_filtroNombreRendicion;
        private System.Windows.Forms.Label label_filtroRendicion;
        private System.Windows.Forms.Button button_devolucionRendicion;
        private System.Windows.Forms.Label label_devolucionRendicion;
        private System.Windows.Forms.RichTextBox richTextBox_devolucionRendicion;
        private System.Windows.Forms.Button button_volver;
    }
}