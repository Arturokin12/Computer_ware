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
    public partial class ClienteIndex : Form
    {
        public ClienteIndex()
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

        ControladorGen con = new ControladorGen();

        private void btGuardar_Click(object sender, EventArgs e)
        {

        }

        private void ClienteIndex_Load(object sender, EventArgs e)
        {

        }
    }
}
