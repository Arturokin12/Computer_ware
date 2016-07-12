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
        string id_editar = "";

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
            

            if (txtBuscar.Text == "")
            {
                try
                {
                    var consulta = from o in ent.Orden_servicio
                                   join c in ent.Cliente on o.id_cliente equals c.id_cliente
                                   select new Orden_Serv
                                   {
                                       id_os = o.id_os,
                                       cliente = c.Nombre,
                                       fecha_inicio = o.fecha_inicio
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
                                   where c.Nombre.Contains(txtBuscar.Text)
                                   select new
                                   {
                                       o.id_os,
                                       cliente = c.Nombre,
                                       o.fecha_inicio
                                   };
                    tablaOS.DataSource = new BindingList<object>(consulta.ToList<object>());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar O.S" + ex.InnerException, "Error Crítico");
                }
            }
            if (txtOS.Text != "")
            {
                Orden_servicio o = ent.Orden_servicio.Find(Convert.ToInt32(txtOS.Text));
                cbCliente.SelectedValue = o.id_cliente;
            }
        }

        private void btGuardarOS_Click(object sender, EventArgs e)
        {
            string id_os = txtOS.Text;
            string fecha_inicio = dtFecha.Text;
            if (cbCliente.SelectedIndex != 0 && id_os != "")
            {
                string id_cliente = cbCliente.SelectedValue.ToString();
                DateTime nueva = DateTime.Now;
                string f = fecha_inicio + " " + nueva.Hour + ":" + nueva.Minute + ":" + nueva.Second + "." + nueva.Millisecond;
                DateTime fecha = Convert.ToDateTime(f);
                Orden_servicio o = new Orden_servicio
                {
                    id_os = Convert.ToInt32(id_os),
                    fecha_inicio = fecha,
                    id_cliente = Convert.ToInt32(id_cliente)
                };
                try
                {
                    ent.Orden_servicio.Add(o);
                    ent.SaveChanges();
                    var consulta = from or in ent.Orden_servicio
                                   join c in ent.Cliente on or.id_cliente equals c.id_cliente
                                   select new
                                   {
                                       or.id_os,
                                       cliente = c.Nombre,
                                       or.fecha_inicio
                                   };
                    tablaOS.DataSource = new BindingList<object>(consulta.ToList<object>());
                    txtOS.Text = "";
                    cbCliente.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al guardar, puede que la os ya exista. \n \n" + ex.InnerException.ToString().Substring(0,100));
                }
            }else
            {
                MessageBox.Show("Ingrese todos los datos.", "Datos insuficientes");
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
                               join c in ent.Cliente on o.id_cliente equals c.id_cliente
                               where c.Nombre.Contains(txtBuscar.Text)
                               select new
                               {
                                   o.id_os,
                                   cliente = c.Nombre,
                                   o.fecha_inicio
                               };
                tablaOS.DataSource = new BindingList<object>(consulta.ToList<object>());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar O.S" + ex.InnerException, "Error Crítico");
            }
        }

        private void tablaOS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string os = "";
                string cliente = "";
                string fecha_inicio = "";
                string tecnico = "";

                if (tablaOS.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    os = tablaOS.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                if (tablaOS.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    cliente = tablaOS.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                if (tablaOS.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    fecha_inicio = tablaOS.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                if (tablaOS.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    tecnico = tablaOS.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                if (os != "" && cliente != "" && fecha_inicio != "" && tecnico != "")
                {
                    Orden_servicio o = ent.Orden_servicio.Find(Convert.ToInt32(os));
                    
                }
            }
        }

        private void editarOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orden_servicio o = ent.Orden_servicio.Find(Convert.ToInt32(id_editar));
            groupBox1.Text = "Editar O.S N° " + o.id_os;
            txtOS.Text = o.id_os.ToString();
            cbCliente.SelectedValue = o.id_cliente;
            btCancelarEdit.Visible = true;
            btEditar.Visible = true;
            btGuardarOS.Visible = false;
            dtFecha.Text = o.fecha_inicio.ToShortDateString();
        }

        private void tablaOS_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    id_editar = tablaOS.Rows[e.RowIndex].Cells[0].Value.ToString();
                    lbidOS.Text = id_editar;
                    Orden_servicio o = ent.Orden_servicio.Find(Convert.ToInt32(id_editar));
                    contextMenuStrip1.Show(this.tablaOS, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (txtOS.Text != "" && cbCliente.SelectedIndex != 0)
            {
                Orden_servicio o = ent.Orden_servicio.Find(Convert.ToInt32(txtOS.Text));
                if (txtOS.Text.Equals(lbidOS.Text))
                {
                    try
                    {
                        o.id_cliente = Convert.ToInt32(cbCliente.SelectedValue.ToString());
                        o.fecha_inicio = Convert.ToDateTime(dtFecha.Text);
                        ent.SaveChanges();
                        var consulta = from or in ent.Orden_servicio
                                       join c in ent.Cliente on or.id_cliente equals c.id_cliente
                                       select new
                                       {
                                           or.id_os,
                                           cliente = c.Nombre,
                                           or.fecha_inicio
                                       };
                        tablaOS.DataSource = new BindingList<object>(consulta.ToList<object>());
                        btGuardarOS.Visible = true;
                        btEditar.Visible = false;
                        txtOS.Text = "";
                        cbCliente.SelectedIndex = 0;
                        dtFecha.Text = DateTime.Now.Date.ToShortDateString();
                        groupBox1.Text = "Agregar O.S";
                        btCancelarEdit.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Crítico al editar O.S \n \n \n"+ex.InnerException,"Error Crítico");
                    }
                }else
                {
                    if (o == null)
                    {
                        try
                        {
                            ent.Database.ExecuteSqlCommand("Update orden_servicio set id_os = " + txtOS.Text + ", id_cliente = " + cbCliente.SelectedValue.ToString() + ", fecha_inicio = '" + dtFecha.Text + "' where id_os = " + lbidOS.Text + ";");
                            var consulta = from or in ent.Orden_servicio
                                           join c in ent.Cliente on or.id_cliente equals c.id_cliente
                                           select new
                                           {
                                               or.id_os,
                                               cliente = c.Nombre,
                                               or.fecha_inicio
                                           };
                            tablaOS.DataSource = new BindingList<object>(consulta.ToList<object>());
                            btGuardarOS.Visible = true;
                            btEditar.Visible = false;
                            txtOS.Text = "";
                            cbCliente.SelectedIndex = 0;
                            dtFecha.Text = DateTime.Now.Date.ToShortDateString();
                            groupBox1.Text = "Agregar O.S";
                            btCancelarEdit.Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al editar O.S."+ex.InnerException, "Error Crítico al editar");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("El id de la O.S ya existe, ingrese uno nuevamente.", "O.S Ya existe");
                    }
                }
            }else
            {
                MessageBox.Show("Ingrese todos los valores.", "Datos insuficientes.");
            }
        }

        private void btCancelarEdit_Click(object sender, EventArgs e)
        {
            btGuardarOS.Visible = true;
            btEditar.Visible = false;
            txtOS.Text = "";
            cbCliente.SelectedIndex = 0;
            dtFecha.Text = DateTime.Now.Date.ToShortDateString();
            groupBox1.Text = "Agregar O.S";
            btCancelarEdit.Visible = false;
        }
    }
}
