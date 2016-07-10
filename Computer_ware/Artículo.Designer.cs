namespace Computer_ware
{
    partial class Artículo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Artículo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btEditar = new System.Windows.Forms.Button();
            this.chkClose = new System.Windows.Forms.CheckBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lbIDArt = new System.Windows.Forms.Label();
            this.lbIdShow = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAtencion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.Obs = new System.Windows.Forms.Label();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.chkClose);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.lbIDArt);
            this.groupBox1.Controls.Add(this.lbIdShow);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Controls.Add(this.txtOS);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbAtencion);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtLinea);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.Obs);
            this.groupBox1.Controls.Add(this.cbTecnico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artículo";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(284, 36);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(121, 22);
            this.dtFecha.TabIndex = 33;
            this.dtFecha.Visible = false;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(463, 166);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(147, 26);
            this.btEditar.TabIndex = 32;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // chkClose
            // 
            this.chkClose.AutoSize = true;
            this.chkClose.Checked = true;
            this.chkClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkClose.Location = new System.Drawing.Point(627, 170);
            this.chkClose.Name = "chkClose";
            this.chkClose.Size = new System.Drawing.Size(128, 20);
            this.chkClose.TabIndex = 31;
            this.chkClose.Text = "Cerrar al guardar";
            this.chkClose.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Seleccione",
            "En laboratorio",
            "Reparado",
            "Enviado"});
            this.cbEstado.Location = new System.Drawing.Point(284, 124);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 30;
            // 
            // lbIDArt
            // 
            this.lbIDArt.AutoSize = true;
            this.lbIDArt.Location = new System.Drawing.Point(159, 36);
            this.lbIDArt.Name = "lbIDArt";
            this.lbIDArt.Size = new System.Drawing.Size(0, 16);
            this.lbIDArt.TabIndex = 29;
            this.lbIDArt.Visible = false;
            // 
            // lbIdShow
            // 
            this.lbIdShow.AutoSize = true;
            this.lbIdShow.Location = new System.Drawing.Point(26, 36);
            this.lbIdShow.Name = "lbIdShow";
            this.lbIdShow.Size = new System.Drawing.Size(119, 16);
            this.lbIdShow.TabIndex = 28;
            this.lbIdShow.Text = "ID Artículo a editar:";
            this.lbIdShow.Visible = false;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(452, 166);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(147, 26);
            this.btGuardar.TabIndex = 26;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(284, 168);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(121, 22);
            this.txtOS.TabIndex = 25;
            this.txtOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOS_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "O.S";
            // 
            // cbAtencion
            // 
            this.cbAtencion.FormattingEnabled = true;
            this.cbAtencion.Location = new System.Drawing.Point(722, 124);
            this.cbAtencion.Name = "cbAtencion";
            this.cbAtencion.Size = new System.Drawing.Size(145, 24);
            this.cbAtencion.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(649, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Atención";
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(498, 126);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(121, 22);
            this.txtLinea.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Línea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(79, 124);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(121, 68);
            this.txtObs.TabIndex = 14;
            // 
            // Obs
            // 
            this.Obs.AutoSize = true;
            this.Obs.Location = new System.Drawing.Point(26, 129);
            this.Obs.Name = "Obs";
            this.Obs.Size = new System.Drawing.Size(33, 16);
            this.Obs.TabIndex = 13;
            this.Obs.Text = "Obs";
            // 
            // cbTecnico
            // 
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(722, 84);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(145, 24);
            this.cbTecnico.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Técnico";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(498, 84);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(121, 22);
            this.txtSerie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serie";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(284, 84);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(121, 22);
            this.txtModelo.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(79, 84);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 22);
            this.txtMarca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca ";
            // 
            // Artículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Computer_ware.Properties.Resources.smooth_ice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 248);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(933, 287);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(933, 287);
            this.Name = "Artículo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículo";
            this.Load += new System.EventHandler(this.Artículo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label Obs;
        private System.Windows.Forms.ComboBox cbTecnico;
        public System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAtencion;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbIDArt;
        public System.Windows.Forms.Label lbIdShow;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.CheckBox chkClose;
        public System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.TextBox txtOS;
    }
}