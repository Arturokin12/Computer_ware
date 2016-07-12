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
    public partial class Index : Form
    {
        public Index()
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
        WarehouseEntities ent = new WarehouseEntities();

        string id_mouseClick;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            groupBox2.Paint += PaintBorderlessGroupBox;

            tablaArticulos.DataSource = con.getArticulos();

            //cbCliente
            List<Cliente> clientes = con.getClientes();
            clientes.Insert(0, new Cliente { id_cliente = 0, Nombre = "Seleccione"});
            cbCliente.DataSource = clientes;
            cbCliente.ValueMember = "Nombre";
            cbCliente.DisplayMember = "Nombre";

            //cbAtencion
            BindingList<atencion> atenciones = new BindingList<atencion>(con.getAtenciones());
            atenciones.Insert(0, new atencion { id_atencion = 0, descripcion = "Seleccione"});
            cbAtencion.DataSource = atenciones;
            cbAtencion.ValueMember = "id_atencion";
            cbAtencion.DisplayMember = "descripcion";

            //cbtecnico
            BindingList<tecnico> tecnicos = new BindingList<tecnico>(con.getTecnicos());
            tecnicos.Insert(0, new tecnico { id_tecnico = 0, Nombre = "Seleccione"});
            cbTecnico.DataSource = tecnicos;
            cbTecnico.ValueMember = "nombre";
            cbTecnico.DisplayMember = "nombre";

            cbEstadoOT.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string cliente = cbCliente.SelectedValue.ToString();
            string atencion = cbAtencion.SelectedValue.ToString();
            string tecnico = cbTecnico.SelectedValue.ToString();
            string estadoot = cbEstadoOT.SelectedItem.ToString();
            string ESTADO = cbEstado.SelectedItem.ToString();

            if (cliente == "Seleccione")
            {
                cliente = "";
            }
            if (atencion == "Seleccione")
            {
                atencion = "";
            }
            if (tecnico == "Seleccione")
            {
                tecnico = "";
            }
            if (estadoot == "Seleccione")
            {
                estadoot = "";
            }
            if (ESTADO == "Seleccione")
            {
                ESTADO = "";
            }
            if (atencion == "0")
            {
                atencion = "";
            }
            Articulo art = new Articulo {
                marca = txtMarca.Text, modelo = txtModelo.Text, estado = ESTADO,
                serie = txtSerie.Text, Linea = txtLinea.Text, fecha_recepcion = Convert.ToDateTime(dtFechaOT.Text)
            };
            tablaArticulos.DataSource = con.buscarArticulos(art, atencion, tecnico,estadoot, cliente);
        }

        private void txtOS_TextChanged(object sender, EventArgs e)
        {
            tablaArticulos.DataSource = con.buscarPorOS(txtOS.Text);
        }

        private void tablaArticulos_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    id_mouseClick = tablaArticulos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    
                    contextMenuStrip1.Show(tablaArticulos, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //levantar ventana Agregar Artículo
            Artículo a = new Artículo();
            a.btGuardar.Visible = true;
            a.btEditar.Visible = false;
            a.ShowDialog();
            tablaArticulos.DataSource = con.getArticulos();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteIndex c = new ClienteIndex();
            c.ShowDialog();
        }

        private void técnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tecnicos t = new Tecnicos();
            t.ShowDialog();
            BindingList<tecnico> tecnicos = new BindingList<tecnico>(con.getTecnicos());
            tecnicos.Insert(0, new tecnico { id_tecnico = 0, Nombre = "Seleccione" });
            cbTecnico.DataSource = tecnicos;
            cbTecnico.ValueMember = "id_tecnico";
            cbTecnico.DisplayMember = "nombre";
        }

        private void oSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OS o = new OS();
            o.btEditar.Visible = false;
            o.btGuardarOS.Visible = true;
            o.ShowDialog();
        }

        private void editarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id_mouseClick != "")
            {
                string id_art = id_mouseClick;
                Artículo ar = new Artículo();
                ar.groupBox2.Enabled = false;
                ar.chkClose.Visible = false;
                ar.lbIDArt.Text = id_art;
                ar.btGuardar.Visible = false;
                ar.btEditar.Visible = true;
                ar.lbIDArt.Visible = true;
                ar.lbIdShow.Visible = true;
                ar.ShowDialog();
                tablaArticulos.DataSource = con.getArticulos();
            }
            
            //string marca;
            //string modelo;
            //string serie;
            //string obs;
            //string fecha;
            //string estado;
            //string linea;
            //string tecnico;
            //string atencion;
            //string os;
        }

        private void tablaArticulos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registrarEnvíoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnviarArt a = new EnviarArt();
            a.lbIDArticulo.Text = id_mouseClick;
            a.ShowDialog();
            tablaArticulos.DataSource = con.getArticulos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < tablaArticulos.Rows.Count; i++)
            //{
            //    try
            //    {
            //        ent.Articulo.Remove(ent.Articulo.Find(Convert.ToInt32(tablaArticulos.Rows[i].Cells[0].Value.ToString())));
            //        ent.SaveChanges();
            //    }
            //    catch (Exception)
            //    {
                    
            //    }
            //}
            //tablaArticulos.DataSource = con.getArticulos();
        }

        private void cambiarEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarEstadoArt ed = new EditarEstadoArt();
            ed.lbIdArt.Text = id_mouseClick;
            ed.ShowDialog();
            tablaArticulos.DataSource = con.getArticulos();
        }

        private void cambiarAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarAtencion c = new CambiarAtencion();
            c.lbIdArt.Text = id_mouseClick;
            c.ShowDialog();
            tablaArticulos.DataSource = con.getArticulos();
        }

        private void verClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCliente v = new VerCliente();
            var consulta = from a in ent.Articulo
                           join o in ent.Orden_servicio on a.id_os equals o.id_os
                           join c in ent.Cliente on o.id_cliente equals c.id_cliente
                           where a.id_articulo.ToString() == id_mouseClick
                           select c;
            if (consulta.ToList().Count == 1)
            {
                Cliente c = consulta.ToList().ElementAt(0);
                v.lbidCliente.Text = c.id_cliente+"";
                v.lbNombreCliente.Text = c.Nombre;
                v.lbRut.Text = c.Rut;
                v.lbDireccionCliente.Text = c.Direccion;
                v.lbComunaCliente.Text = c.Comuna;
                v.lbCiudad.Text = c.Ciudad;
                v.lbEstadoCliente.Text = c.Ciudad;
                v.ShowDialog();
            }else
            {
                MessageBox.Show("Ningún Cliente asociado a éste Artículo.", "Sin Cliente.");
            }
        }

        private void verOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerOS v = new VerOS();
            v.lbidOS.Text = ent.Articulo.Find(Convert.ToInt32(id_mouseClick)).id_os.ToString();
            v.ShowDialog();
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        
        private void PaintBorderlessGroupBox(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            box.Parent.BackColor = System.Drawing.Color.Black;
        }

        private void agregarOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OT o = new OT();
            o.lbidArt.Text = id_mouseClick;
            o.ShowDialog();
        }

        private void txtBuscarOT_TextChanged(object sender, EventArgs e)
        {
            tablaArticulos.DataSource = con.buscarPorOT(txtBuscarOT.Text);
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtLinea.Text = "";
            txtSerie.Text = "";
            cbAtencion.SelectedIndex = 0;
            cbCliente.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            cbEstadoOT.SelectedIndex = 0;
            cbTecnico.SelectedIndex = 0;
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            tablaArticulos.DataSource = con.getArticulos();
        }

        private void configuraciónesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion c = new Configuracion();
            c.ShowDialog();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bodega b = new Bodega();
            b.ShowDialog();
        }

        private void btBuscarFechas_Click(object sender, EventArgs e)
        {
            string fecha_desde = dtFechaOT.Text;
            string fecha_hasta = dtFechaHastaOT.Text;

            try
            {
                DateTime desde = Convert.ToDateTime(fecha_desde);
                DateTime hasta = Convert.ToDateTime(fecha_hasta);

                if (desde <= hasta)
                {
                    tablaArticulos.DataSource = con.buscarPorFechaArt(desde, hasta);
                }
            }
            catch (Exception)
            {
                
            }
            
        }
    }
}
