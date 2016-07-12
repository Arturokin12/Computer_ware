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
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.Obs = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAtencion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEstadoOT = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtFechaTer = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.txtLinea);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.Obs);
            this.groupBox1.Controls.Add(this.txtSerie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(337, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artículo";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(383, 48);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(167, 22);
            this.dtFecha.TabIndex = 33;
            this.dtFecha.Visible = false;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(146, 346);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(182, 40);
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
            this.chkClose.Location = new System.Drawing.Point(393, 355);
            this.chkClose.Name = "chkClose";
            this.chkClose.Size = new System.Drawing.Size(128, 20);
            this.chkClose.TabIndex = 31;
            this.chkClose.Text = "Cerrar al guardar";
            this.chkClose.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Seleccione",
            "En laboratorio",
            "Reparado",
            "Enviado"});
            this.cbEstado.Location = new System.Drawing.Point(383, 138);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(167, 24);
            this.cbEstado.TabIndex = 30;
            // 
            // lbIDArt
            // 
            this.lbIDArt.AutoSize = true;
            this.lbIDArt.Location = new System.Drawing.Point(158, 48);
            this.lbIDArt.Name = "lbIDArt";
            this.lbIDArt.Size = new System.Drawing.Size(0, 16);
            this.lbIDArt.TabIndex = 29;
            this.lbIDArt.Visible = false;
            // 
            // lbIdShow
            // 
            this.lbIdShow.AutoSize = true;
            this.lbIdShow.Location = new System.Drawing.Point(25, 48);
            this.lbIdShow.Name = "lbIdShow";
            this.lbIdShow.Size = new System.Drawing.Size(119, 16);
            this.lbIdShow.TabIndex = 28;
            this.lbIdShow.Text = "ID Artículo a editar:";
            this.lbIdShow.Visible = false;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(135, 346);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(182, 40);
            this.btGuardar.TabIndex = 26;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(383, 196);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(167, 22);
            this.txtOS.TabIndex = 25;
            this.txtOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOS_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "O.S";
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(383, 254);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(167, 22);
            this.txtLinea.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Línea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(78, 138);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(165, 68);
            this.txtObs.TabIndex = 14;
            // 
            // Obs
            // 
            this.Obs.AutoSize = true;
            this.Obs.Location = new System.Drawing.Point(25, 143);
            this.Obs.Name = "Obs";
            this.Obs.Size = new System.Drawing.Size(33, 16);
            this.Obs.TabIndex = 13;
            this.Obs.Text = "Obs";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(78, 257);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(165, 22);
            this.txtSerie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Serie";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(383, 90);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(167, 22);
            this.txtModelo.TabIndex = 3;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(78, 91);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(165, 22);
            this.txtMarca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca ";
            // 
            // cbAtencion
            // 
            this.cbAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtencion.FormattingEnabled = true;
            this.cbAtencion.Location = new System.Drawing.Point(97, 168);
            this.cbAtencion.Name = "cbAtencion";
            this.cbAtencion.Size = new System.Drawing.Size(168, 21);
            this.cbAtencion.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Atención";
            // 
            // cbTecnico
            // 
            this.cbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTecnico.FormattingEnabled = true;
            this.cbTecnico.Location = new System.Drawing.Point(97, 107);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(168, 21);
            this.cbTecnico.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Técnico";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "O.T";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(64, 50);
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
            this.cbEstadoOT.Size = new System.Drawing.Size(168, 21);
            this.cbEstadoOT.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Término";
            // 
            // dtFechaTer
            // 
            this.dtFechaTer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaTer.Location = new System.Drawing.Point(97, 354);
            this.dtFechaTer.Name = "dtFechaTer";
            this.dtFechaTer.Size = new System.Drawing.Size(168, 20);
            this.dtFechaTer.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Inicio";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(97, 291);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(168, 20);
            this.dtFechaInicio.TabIndex = 24;
            // 
            // Artículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Computer_ware.Properties.Resources.smooth_ice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(933, 287);
            this.Name = "Artículo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículo";
            this.Load += new System.EventHandler(this.Artículo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        public System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        public System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtFechaTer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbEstadoOT;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox chkClose;
    }
}