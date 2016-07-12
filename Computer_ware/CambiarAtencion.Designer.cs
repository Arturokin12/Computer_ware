namespace Computer_ware
{
    partial class CambiarAtencion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarAtencion));
            this.lbIdArt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btlisto = new System.Windows.Forms.Button();
            this.cbAtencion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIdArt
            // 
            this.lbIdArt.AutoSize = true;
            this.lbIdArt.Location = new System.Drawing.Point(185, 13);
            this.lbIdArt.Name = "lbIdArt";
            this.lbIdArt.Size = new System.Drawing.Size(0, 13);
            this.lbIdArt.TabIndex = 3;
            this.lbIdArt.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btlisto);
            this.groupBox1.Controls.Add(this.cbAtencion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar Atención";
            // 
            // btlisto
            // 
            this.btlisto.Location = new System.Drawing.Point(285, 42);
            this.btlisto.Name = "btlisto";
            this.btlisto.Size = new System.Drawing.Size(87, 24);
            this.btlisto.TabIndex = 2;
            this.btlisto.Text = "Listo";
            this.btlisto.UseVisualStyleBackColor = true;
            this.btlisto.Click += new System.EventHandler(this.btlisto_Click);
            // 
            // cbAtencion
            // 
            this.cbAtencion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtencion.FormattingEnabled = true;
            this.cbAtencion.Items.AddRange(new object[] {
            "Seleccione",
            "En laboratorio",
            "Reparado",
            "Enviado"});
            this.cbAtencion.Location = new System.Drawing.Point(105, 42);
            this.cbAtencion.Name = "cbAtencion";
            this.cbAtencion.Size = new System.Drawing.Size(162, 24);
            this.cbAtencion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atención:";
            // 
            // CambiarAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Computer_ware.Properties.Resources.smooth_ice;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 133);
            this.Controls.Add(this.lbIdArt);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(431, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(431, 172);
            this.Name = "CambiarAtencion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarAtencion";
            this.Load += new System.EventHandler(this.CambiarAtencion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbIdArt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btlisto;
        private System.Windows.Forms.ComboBox cbAtencion;
        private System.Windows.Forms.Label label1;
    }
}