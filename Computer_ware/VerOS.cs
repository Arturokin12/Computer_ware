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
        }

        private void agregarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Artículo a = new Artículo();
            a.txtOS.Text = lbidOS.Text;
            a.btEditar.Visible = false;
            a.btGuardar.Visible = true;
            a.ShowDialog();
            tablaArticulos.DataSource = con.buscarPorOS(lbidOS.Text);
            Orden_servicio o = ent.Orden_servicio.Find(Convert.ToInt32(lbidOS.Text));
            lbClienteOS.Text = ent.Cliente.Find(o.id_cliente).Nombre;
            lbFechaOS.Text = o.fecha_inicio.ToShortDateString();
        }

        private void verClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCliente v = new VerCliente();
            var consulta = from a in ent.Articulo
                           join o in ent.Orden_servicio on a.id_os equals o.id_os
                           join c in ent.Cliente on o.id_cliente equals c.id_cliente
                           where c.Nombre.Equals(lbClienteOS.Text)
                           select c;
            if (consulta.ToList().ElementAt(0) != null)
            {
                Cliente c = consulta.ToList().ElementAt(0);
                v.lbidCliente.Text = c.id_cliente + "";
                v.lbNombreCliente.Text = c.Nombre;
                v.lbRut.Text = c.Rut;
                v.lbDireccionCliente.Text = c.Direccion;
                v.lbComunaCliente.Text = c.Comuna;
                v.lbCiudad.Text = c.Ciudad;
                v.lbEstadoCliente.Text = c.Ciudad;
                v.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ningún Cliente asociado a éste Artículo.", "Sin Cliente.");
            }
        }

        private void editarOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orden_servicio o = ent.Orden_servicio.Find(Convert.ToInt32(lbidOS.Text));
            OS O_S = new OS();
            O_S.btGuardarOS.Visible = false;
            O_S.btEditar.Visible = true;
            O_S.btCancelarEdit.Visible = true;
            O_S.txtOS.Text = o.id_os.ToString();
            O_S.cbCliente.SelectedValue = o.id_cliente;
            O_S.dtFecha.Text = o.fecha_inicio.Date.ToShortDateString();
            O_S.ShowDialog();
        }
    }
}
