namespace Computer_ware
{
    partial class VerOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerOS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTecnicoOS = new System.Windows.Forms.Label();
            this.lbFechaOS = new System.Windows.Forms.Label();
            this.lbClienteOS = new System.Windows.Forms.Label();
            this.lbidOS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tablaArticulos = new System.Windows.Forms.DataGridView();
            this.id_art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecnico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbTecnicoOS);
            this.groupBox1.Controls.Add(this.lbFechaOS);
            this.groupBox1.Controls.Add(this.lbClienteOS);
            this.groupBox1.Controls.Add(this.lbidOS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(323, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden de Servicio";
            // 
            // lbTecnicoOS
            // 
            this.lbTecnicoOS.AutoSize = true;
            this.lbTecnicoOS.Location = new System.Drawing.Point(123, 182);
            this.lbTecnicoOS.Name = "lbTecnicoOS";
            this.lbTecnicoOS.Size = new System.Drawing.Size(0, 16);
            this.lbTecnicoOS.TabIndex = 7;
            // 
            // lbFechaOS
            // 
            this.lbFechaOS.AutoSize = true;
            this.lbFechaOS.Location = new System.Drawing.Point(129, 136);
            this.lbFechaOS.Name = "lbFechaOS";
            this.lbFechaOS.Size = new System.Drawing.Size(0, 16);
            this.lbFechaOS.TabIndex = 6;
            // 
            // lbClienteOS
            // 
            this.lbClienteOS.AutoSize = true;
            this.lbClienteOS.Location = new System.Drawing.Point(129, 90);
            this.lbClienteOS.Name = "lbClienteOS";
            this.lbClienteOS.Size = new System.Drawing.Size(0, 16);
            this.lbClienteOS.TabIndex = 5;
            // 
            // lbidOS
            // 
            this.lbidOS.AutoSize = true;
            this.lbidOS.Location = new System.Drawing.Point(129, 41);
            this.lbidOS.Name = "lbidOS";
            this.lbidOS.Size = new System.Drawing.Size(0, 16);
            this.lbidOS.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Técnico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "id O.S";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tablaArticulos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(930, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artículos Asociados";
            // 
            // tablaArticulos
            // 
            this.tablaArticulos.AllowUserToAddRows = false;
            this.tablaArticulos.AllowUserToDeleteRows = false;
            this.tablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_art,
            this.marca,
            this.Modelo,
            this.Serie,
            this.Observacion,
            this.fecha_recepcion,
            this.Estado,
            this.Linea,
            this.tecnico,
            this.Atencion,
            this.id_os});
            this.tablaArticulos.Location = new System.Drawing.Point(18, 27);
            this.tablaArticulos.Name = "tablaArticulos";
            this.tablaArticulos.RowHeadersWidth = 15;
            this.tablaArticulos.Size = new System.Drawing.Size(906, 192);
            this.tablaArticulos.TabIndex = 1;
            // 
            // id_art
            // 
            this.id_art.DataPropertyName = "id_articulo";
            this.id_art.HeaderText = "#";
            this.id_art.Name = "id_art";
            this.id_art.ReadOnly = true;
            this.id_art.Width = 30;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.Width = 90;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 90;
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "serie";
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.Width = 90;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "observacion";
            this.Observacion.HeaderText = "Observación";
            this.Observacion.Name = "Observacion";
            this.Observacion.Width = 90;
            // 
            // fecha_recepcion
            // 
            this.fecha_recepcion.DataPropertyName = "fecha_recepcion";
            this.fecha_recepcion.HeaderText = "Fecha_recepcion";
            this.fecha_recepcion.Name = "fecha_recepcion";
            this.fecha_recepcion.Width = 90;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 90;
            // 
            // Linea
            // 
            this.Linea.DataPropertyName = "linea";
            this.Linea.HeaderText = "Línea";
            this.Linea.Name = "Linea";
            this.Linea.Width = 70;
            // 
            // tecnico
            // 
            this.tecnico.DataPropertyName = "nombre";
            this.tecnico.HeaderText = "Técnico";
            this.tecnico.Name = "tecnico";
            // 
            // Atencion
            // 
            this.Atencion.DataPropertyName = "descripcion";
            this.Atencion.HeaderText = "Atención";
            this.Atencion.Name = "Atencion";
            this.Atencion.Width = 90;
            // 
            // id_os
            // 
            this.id_os.DataPropertyName = "id_os";
            this.id_os.HeaderText = "O.S";
            this.id_os.Name = "id_os";
            this.id_os.Width = 60;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArtículoToolStripMenuItem,
            this.verClienteToolStripMenuItem,
            this.editarOSToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // agregarArtículoToolStripMenuItem
            // 
            this.agregarArtículoToolStripMenuItem.Name = "agregarArtículoToolStripMenuItem";
            this.agregarArtículoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.agregarArtículoToolStripMenuItem.Text = "Agregar Artículo";
            this.agregarArtículoToolStripMenuItem.Click += new System.EventHandler(this.agregarArtículoToolStripMenuItem_Click);
            // 
            // verClienteToolStripMenuItem
            // 
            this.verClienteToolStripMenuItem.Name = "verClienteToolStripMenuItem";
            this.verClienteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.verClienteToolStripMenuItem.Text = "Ver Cliente";
            this.verClienteToolStripMenuItem.Click += new System.EventHandler(this.verClienteToolStripMenuItem_Click);
            // 
            // editarOSToolStripMenuItem
            // 
            this.editarOSToolStripMenuItem.Name = "editarOSToolStripMenuItem";
            this.editarOSToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.editarOSToolStripMenuItem.Text = "Editar O.S";
            this.editarOSToolStripMenuItem.Click += new System.EventHandler(this.editarOSToolStripMenuItem_Click);
            // 
            // VerOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Computer_ware.Properties.Resources.smooth_ice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(971, 576);
            this.MinimumSize = new System.Drawing.Size(971, 576);
            this.Name = "VerOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerOS";
            this.Load += new System.EventHandler(this.VerOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaArticulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbTecnicoOS;
        private System.Windows.Forms.Label lbFechaOS;
        private System.Windows.Forms.Label lbClienteOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView tablaArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_art;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecnico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_os;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarOSToolStripMenuItem;
        public System.Windows.Forms.Label lbidOS;
    }
}