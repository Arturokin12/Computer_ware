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

        ControladorGen con = new ControladorGen();
        WarehouseEntities ent = new WarehouseEntities();

        string id_mouseClick;

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Index_Load(object sender, EventArgs e)
        {
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
            cbAtencion.ValueMember = "descripcion";
            cbAtencion.DisplayMember = "descripcion";

            //cbtecnico
            BindingList<tecnico> tecnicos = new BindingList<tecnico>(con.getTecnicos());
            tecnicos.Insert(0, new tecnico { id_tecnico = 0, Nombre = "Seleccione"});
            cbTecnico.DataSource = tecnicos;
            cbTecnico.ValueMember = "nombre";
            cbTecnico.DisplayMember = "nombre";
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string cliente = cbCliente.SelectedValue.ToString();
            string atencion = cbAtencion.SelectedValue.ToString();
            string tecnico = cbTecnico.SelectedValue.ToString();

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
            Articulo art = new Articulo {
                marca = txtMarca.Text, modelo = txtModelo.Text, estado = txtEstado.Text,
                serie = txtSerie.Text, Linea = txtLinea.Text, fecha_recepcion = Convert.ToDateTime(dtFechaR.Text)
            };
            tablaArticulos.DataSource = con.buscarArticulos(art, atencion, tecnico);
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
            o.ShowDialog();
        }

        private void editarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id_art;
            string marca;
            string modelo;
            string serie;
            string obs;
            string fecha;
            string estado;
            string linea;
            string tecnico;
            string atencion;
            string os;
        }

        private void tablaArticulos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
