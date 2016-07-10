using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computer_ware.Modelo;
using Computer_ware.Controlador;

namespace Computer_ware
{
    public partial class VerOS : Form
    {
        public VerOS()
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

        WarehouseEntities ent = new WarehouseEntities();
        ControladorGen con = new ControladorGen();

        private void VerOS_Load(object sender, EventArgs e)
        {
            tablaArticulos.DataSource = con.buscarPorOS(lbidOS.Text);
            Orden_servicio o = ent.Orden_servicio.Find(Convert.ToInt32(lbidOS.Text));
            lbClienteOS.Text = ent.Cliente.Find(o.id_cliente).Nombre;
            lbFechaOS.Text = o.fecha_inicio.ToShortDateString();
            lbTecnicoOS.Text = ent.tecnico.Find(o.id_tecnico).Nombre;
        }

        private void agregarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Artículo a = new Artículo();
            a.txtOS.Text = lbidOS.Text;
            a.ShowDialog();
            tablaArticulos.DataSource = con.buscarPorOS(lbidOS.Text);
            Orden_servicio o = ent.Orden_servicio.Find(Convert.ToInt32(lbidOS.Text));
            lbClienteOS.Text = ent.Cliente.Find(o.id_cliente).Nombre;
            lbFechaOS.Text = o.fecha_inicio.ToShortDateString();
            lbTecnicoOS.Text = ent.tecnico.Find(o.id_tecnico).Nombre;
        }
    }
}
