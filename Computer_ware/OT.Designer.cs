namespace Computer_ware
{
    partial class OT
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbidArt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEstadoOT = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFechaTer = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cbAtencion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaOT = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_termino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaOT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btGuardar);
            this.groupBox2.Controls.Add(this.lbidArt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbEstadoOT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtFechaTer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtFechaInicio);
            this.groupBox2.Controls.Add(this.cbAtencion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbTecnico);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(98, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "O.T";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(391, 280);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(85, 33);
            this.btGuardar.TabIndex = 33;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lbidArt
            // 
            this.lbidArt.AutoSize = true;
            this.lbidArt.Location = new System.Drawing.Point(98, 110);
            this.lbidArt.Name = "lbidArt";
            this.lbidArt.Size = new System.Drawing.Size(0, 16);
            this.lbidArt.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "id Artículo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(211, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "Datos de Orden de Trabajo";
            // 
            // cbEstadoOT
            // 
            this.cbEstadoOT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoOT.FormattingEnabled = true;
            this.cbEstadoOT.Items.AddRange(new object[] {
            "Pendiente",
            "Terminado"});
            this.cbEstadoOT.Location = new System.Drawing.Point(97, 230);
            this.cbEstadoOT.Name = "cbEstadoOT";
            this.cbEstadoOT.Size = new System.Drawing.Size(168, 24);
            this.cbEstadoOT.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(325, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Término";
            // 
            // dtFechaTer
            // 
            this.dtFechaTer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaTer.Location = new System.Drawing.Point(391, 167);
            this.dtFechaTer.Name = "dtFechaTer";
            this.dtFechaTer.Size = new System.Drawing.Size(168, 22);
            this.dtFechaTer.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Inicio";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(391, 104);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(168, 22);
            this.dtFechaInicio.TabIndex = 24;
            // 
            // cbAtencion
            // 
            this.cbAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtencion.FormattingEnabled = true;
            this.cbAtencion.Location = new System.Drawing.Point(97, 168);
            this.cbAtencion.Name = "cbAtencion";
            this.cbAtencion.Size = new System.Drawing.Size(168, 24);
            this.cbAtencion.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Atención";
            // 
            // cbTecnico
            // 
            this.cbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(391, 227);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(168, 24);
            this.cbTecnico.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Técnico";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tablaOT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes de Trabajo relacionadas al artículo";
            // 
            // tablaOT
            // 
            this.tablaOT.AllowUserToAddRows = false;
            this.tablaOT.AllowUserToDeleteRows = false;
            this.tablaOT.AllowUserToResizeRows = false;
            this.tablaOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaOT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.articulo,
            this.tecnico,
            this.estado,
            this.Fecha_inicio,
            this.Fecha_termino,
            this.id_atencion});
            this.tablaOT.Location = new System.Drawing.Point(7, 22);
            this.tablaOT.Name = "tablaOT";
            this.tablaOT.ReadOnly = true;
            this.tablaOT.Size = new System.Drawing.Size(771, 166);
            this.tablaOT.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_ot";
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // articulo
            // 
            this.articulo.DataPropertyName = "articulo";
            this.articulo.HeaderText = "Articulo";
            this.articulo.Name = "articulo";
            this.articulo.ReadOnly = true;
            // 
            // tecnico
            // 
            this.tecnico.DataPropertyName = "tecnico";
            this.tecnico.HeaderText = "Técnico";
            this.tecnico.Name = "tecnico";
            this.tecnico.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // Fecha_inicio
            // 
            this.Fecha_inicio.DataPropertyName = "fecha_inicio";
            this.Fecha_inicio.HeaderText = "Inicio";
            this.Fecha_inicio.Name = "Fecha_inicio";
            this.Fecha_inicio.ReadOnly = true;
            // 
            // Fecha_termino
            // 
            this.Fecha_termino.DataPropertyName = "fecha_termino";
            this.Fecha_termino.HeaderText = "Termino";
            this.Fecha_termino.Name = "Fecha_termino";
            this.Fecha_termino.ReadOnly = true;
            // 
            // id_atencion
            // 
            this.id_atencion.DataPropertyName = "atencion";
            this.id_atencion.HeaderText = "Atencion";
            this.id_atencion.Name = "id_atencion";
            this.id_atencion.ReadOnly = true;
            // 
            // OT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Computer_ware.Properties.Resources.smooth_ice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(825, 625);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(825, 625);
            this.Name = "OT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OT";
            this.Load += new System.EventHandler(this.OT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaOT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbEstadoOT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFechaTer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.ComboBox cbAtencion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTecnico;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbidArt;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_termino;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_atencion;
    }
}