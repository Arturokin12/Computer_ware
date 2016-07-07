namespace Computer_ware
{
    partial class OS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaOS = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btGuardarOS = new System.Windows.Forms.Button();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.LBEL8 = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tablaOS);
            this.groupBox1.Controls.Add(this.btGuardarOS);
            this.groupBox1.Controls.Add(this.cbTecnico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LBEL8);
            this.groupBox1.Controls.Add(this.txtOS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar O.S";
            // 
            // tablaOS
            // 
            this.tablaOS.AllowUserToAddRows = false;
            this.tablaOS.AllowUserToDeleteRows = false;
            this.tablaOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.Fecha,
            this.id_tecnico});
            this.tablaOS.Location = new System.Drawing.Point(7, 282);
            this.tablaOS.Name = "tablaOS";
            this.tablaOS.Size = new System.Drawing.Size(550, 161);
            this.tablaOS.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_os";
            this.ID.HeaderText = "O.S";
            this.ID.Name = "ID";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha_inicio";
            this.Fecha.HeaderText = "Fecha Inicio";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 120;
            // 
            // id_tecnico
            // 
            this.id_tecnico.DataPropertyName = "tecnico";
            this.id_tecnico.HeaderText = "Técnico";
            this.id_tecnico.Name = "id_tecnico";
            // 
            // btGuardarOS
            // 
            this.btGuardarOS.Location = new System.Drawing.Point(303, 187);
            this.btGuardarOS.Name = "btGuardarOS";
            this.btGuardarOS.Size = new System.Drawing.Size(109, 23);
            this.btGuardarOS.TabIndex = 8;
            this.btGuardarOS.Text = "Guardar";
            this.btGuardarOS.UseVisualStyleBackColor = true;
            this.btGuardarOS.Click += new System.EventHandler(this.btGuardarOS_Click);
            // 
            // cbTecnico
            // 
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(363, 128);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(123, 24);
            this.cbTecnico.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Técnico";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(144, 128);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(125, 24);
            this.cbCliente.TabIndex = 5;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(363, 72);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(123, 22);
            this.dtFecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // LBEL8
            // 
            this.LBEL8.AutoSize = true;
            this.LBEL8.Location = new System.Drawing.Point(89, 131);
            this.LBEL8.Name = "LBEL8";
            this.LBEL8.Size = new System.Drawing.Size(49, 16);
            this.LBEL8.TabIndex = 2;
            this.LBEL8.Text = "Cliente";
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(144, 72);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(125, 22);
            this.txtOS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero O.S";
            // 
            // OS
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Computer_ware.Properties.Resources.degradados_azules_1920x1200_127;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 494);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(604, 533);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(604, 533);
            this.Name = "OS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OS";
            this.Load += new System.EventHandler(this.OS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGuardarOS;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBEL8;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tecnico;
    }
}