using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_ware
{
    public partial class VerCliente : Form
    {
        public VerCliente()
        {
            InitializeComponent();
        }

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

        private void VerCliente_Load(object sender, EventArgs e)
        {

        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ClienteIndex c = new ClienteIndex();
            c.txtBuscarNombre.Text = lbNombreCliente.Text;
            c.ShowDialog();
            //this.Close();
        }

        private void ordenesDeServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            OS o = new OS();
            o.txtBuscar.Text = lbNombreCliente.Text;
            o.ShowDialog();
            //this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerOS o = new VerOS();
        }
    }
}
