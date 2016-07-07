using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_ware.Controlador;

namespace Computer_ware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ControladorGen c = new ControladorGen();

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (c.login(txtPass.Text))
            {
                Index i = new Index();
                this.Hide();
                i.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta!");
            }
        }

        private void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btEntrar_Click(sender, e);
            }
        }
    }
}
