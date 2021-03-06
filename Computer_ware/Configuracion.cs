﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_ware.Controlador;
using Computer_ware.Modelo;

namespace Computer_ware
{
    public partial class Configuracion : Form
    {

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
            base.WndProc(ref m);
        }

        public Configuracion()
        {
            InitializeComponent();
        }

        ControladorGen c = new ControladorGen();
        WarehouseEntities ent = new WarehouseEntities();

        private void btCambiar_Click(object sender, EventArgs e)
        {
            if (c.login(txtPass.Text))
            {
                if (txtNew.Text == txtNew2.Text)
                {
                    try
                    {
                        ent.Database.ExecuteSqlCommand("update admin set contraseña = '"+txtNew2.Text+"' where contraseña = '"+txtPass.Text+"'");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cambiar Contraseña \n \n "+ex.InnerException.ToString().Substring(0,100), "Error Crítico!");
                    }
                }else
                {
                    MessageBox.Show("Contraseñas no coinciden","Error");
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta!");
            }
        }
    }
}
