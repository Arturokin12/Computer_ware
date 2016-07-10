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
using Computer_ware.Modelo;

namespace Computer_ware
{
    public partial class OS : Form
    {
        public OS()
        {
            InitializeComponent();
        }

        ControladorGen con = new ControladorGen();
        WarehouseEntities ent = new WarehouseEntities();

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

        private void OS_Load(object sender, EventArgs e)
        {
            //cbCliente
            BindingList<Cliente> clientes = new BindingList<Cliente>(con.getClientes());
            clientes.Insert(0, new Cliente { id_cliente = 0, Nombre = "Seleccione" });
            cbCliente.DataSource = clientes;
            cbCliente.ValueMember = "id_cliente";
            cbCliente.DisplayMember = "Nombre";

            //cbtecnico
            BindingList<tecnico> tecnicos = new BindingList<tecnico>(con.getTecnicos());
            tecnicos.Insert(0, new tecnico { id_tecnico = 0, Nombre = "Seleccione" });
            cbTecnico.DataSource = tecnicos;
            cbTecnico.ValueMember = "id_tecnico";
            cbTecnico.DisplayMember = "nombre";

            if (txtBuscar.Text == "")
            {
                try
                {
                    var consulta = from o in ent.Orden_servicio
                                   join c in ent.Cliente on o.id_cliente equals c.id_cliente
                                   join t in ent.tecnico on o.id_tecnico equals t.id_tecnico
                                   select new Orden_Serv
                                   {
                                       id_os = o.id_os,
                                       cliente = c.Nombre,
                                       fecha_inicio = o.fecha_inicio,
                                       tecnico = t.Nombre
                                   };
                    BindingList<Orden_Serv> lista = new BindingList<Orden_Serv>(consulta.ToList<Orden_Serv>());
                    List<Orden_Serv> lista2 = new List<Orden_Serv>();
                    tablaOS.DataSource = lista;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos." + ex.InnerException, "Error Crítico");
                }
            }
            else
            {
                try
                {
                    var consulta = from o in ent.Orden_servicio
                                   join c in ent.Cliente on o.id_cliente equals c.id_cliente
                                   join t in ent.tecnico on o.id_tecnico equals t.id_tecnico
                                   where c.Nombre.Contains(txtBuscar.Text) || t.Nombre.Contains(txtBuscar.Text)
                                   select new
                                   {
                                       o.id_os,
                                       cliente = c.Nombre,
                                       o.fecha_inicio,
                                       tecnico = t.Nombre
                                   };
                    tablaOS.DataSource = new BindingList<object>(consulta.ToList<object>());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar O.S" + ex.InnerException, "Error Crítico");
                }
            }

        }

        private void btGuardarOS_Click(object sender, EventArgs e)
        {
            string id_os = txtOS.Text;
            string fecha_inicio = dtFecha.Text;
            if (cbCliente.SelectedIndex != 0 && cbTecnico.SelectedIndex != 0 && id_os != "")
            {
                string id_tecnico = cbTecnico.SelectedValue.ToString();
                string id_cliente = cbCliente.SelectedValue.ToString();
                DateTime nueva = DateTime.Now;
                string f = fecha_inicio + " " + nueva.Hour + ":" + nueva.Minute + ":" + nueva.Second + "." + nueva.Millisecond;
                DateTime fecha = Convert.ToDateTime(f);
                Orden_servicio o = new Orden_servicio
                {
                    id_os = Convert.ToInt32(id_os),
                    fecha_inicio = fecha,
                    id_cliente = Convert.ToInt32(id_cliente),
                    id_tecnico = Convert.ToInt32(id_tecnico)
                };
                try
                {
                    ent.Orden_servicio.Add(o);
                    ent.SaveChanges();
                    MessageBox.Show("Agregado!", "Éxito al guardar");
                    var consulta = from or in ent.Orden_servicio
                                   join c in ent.Cliente on or.id_cliente equals c.id_cliente
                                   join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                                   select new
                                   {
                                       or.id_os,
                                       cliente = c.Nombre,
                                       or.fecha_inicio,
                                       tecnico = t.Nombre
                                   };
                    tablaOS.DataSource = new BindingList<object>(consulta.ToList<object>());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al guardar, puede que la os ya exista. \n \n" + ex.InnerException.ToString());
                }
            }
        }

        private void txtOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var consulta = from o in ent.Orden_servicio
                               join c in ent.Cliente
  on o.id_cliente equals c.id_cliente
                               join t in ent.tecnico
on o.id_tecnico equals t.id_tecnico
                               where
c.Nombre.Contains(txtBuscar.Text) || t.Nombre.Contains(txtBuscar.Text)
                               select new
                               {
                                   o.id_os,
                                   cliente = c.Nombre,
                                   o.fecha_inicio,
                                   tecnico = t.Nombre
                               };
                tablaOS.DataSource = new BindingList<object>(consulta.ToList<object>());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar O.S" + ex.InnerException, "Error Crítico");
            }
        }
    }
}
