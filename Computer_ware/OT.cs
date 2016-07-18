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
    public partial class OT : Form
    {
        public OT()
        {
            InitializeComponent();
        }

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

        WarehouseEntities ent = new WarehouseEntities();
        ControladorGen con = new ControladorGen();

        private void OT_Load(object sender, EventArgs e)
        {
            try
            {
                var consulta = from or in ent.Orden_trabajo
                               join a in ent.Articulo on or.id_articulo equals a.id_articulo
                               join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                               join at in ent.atencion on or.id_atencion equals at.id_atencion
                               where or.id_articulo.ToString().Contains(lbidArt.Text)
                               select new
                               {
                                   or.id_ot,
                                   articulo = a.marca + " " + a.modelo,
                                   tecnico = t.Nombre,
                                   or.Estado,
                                   or.Fecha_inicio,
                                   or.Fecha_termino,
                                   atencion = at.descripcion
                               };
                tablaOT.DataSource = consulta.ToList<object>();
            }
            catch (Exception)
            {

            }
            //cbAtencion
            BindingList<atencion> atenciones = new BindingList<atencion>(con.getAtenciones());
            atenciones.Insert(0, new atencion { id_atencion = 0, descripcion = "Seleccione" });
            cbAtencion.DataSource = atenciones;
            cbAtencion.ValueMember = "id_atencion";
            cbAtencion.DisplayMember = "descripcion";

            //cbtecnico
            BindingList<tecnico> tecnicos = new BindingList<tecnico>(con.getTecnicosActivos());
            tecnicos.Insert(0, new tecnico { id_tecnico = 0, Nombre = "Seleccione" });
            cbTecnico.DataSource = tecnicos;
            cbTecnico.ValueMember = "id_tecnico";
            cbTecnico.DisplayMember = "nombre";


            cbEstadoOT.SelectedIndex = 0;

            if (lbidArt.Text != "")
            {
                Articulo a = ent.Articulo.Find(Convert.ToInt32(lbidArt.Text));
                groupBox2.Text = "Registrar orden de trabajo a " + a.marca + " " + a.modelo + " - " + a.serie;

            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (cbAtencion.SelectedIndex != 0 && cbTecnico.SelectedIndex != 0)
            {
                try
                {
                    var consulta2 = from o in ent.Orden_trabajo where o.Estado.Equals("Pendiente") select o;

                    if (consulta2.ToList().Count == 0)
                    {
                        Orden_trabajo ot = new Orden_trabajo
                        {
                            id_articulo = Convert.ToInt32(lbidArt.Text),
                            id_tecnico = Convert.ToInt32(cbTecnico.SelectedValue.ToString()),
                            Estado = cbEstadoOT.SelectedItem.ToString(),
                            Fecha_inicio = Convert.ToDateTime(dtFechaInicio.Text),
                            Fecha_termino = Convert.ToDateTime(dtFechaTer.Text),
                            id_atencion = Convert.ToInt32(cbAtencion.SelectedValue.ToString())
                        };
                        ent.Orden_trabajo.Add(ot);
                        ent.SaveChanges();
                        var consulta = from or in ent.Orden_trabajo
                                       join a in ent.Articulo on or.id_articulo equals a.id_articulo
                                       join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                                       join at in ent.atencion on or.id_atencion equals at.id_atencion
                                       where or.id_articulo.ToString().Contains(lbidArt.Text)
                                       select new
                                       {
                                           or.id_ot,
                                           articulo = a.marca + " " + a.modelo,
                                           tecnico = t.Nombre,
                                           or.Estado,
                                           or.Fecha_inicio,
                                           or.Fecha_termino,
                                           atencion = at.descripcion
                                       };
                        tablaOT.DataSource = consulta.ToList<object>();
                        cbAtencion.SelectedIndex = 0;
                        cbEstadoOT.SelectedIndex = 0;
                        cbTecnico.SelectedIndex = 0;
                    }else
                    {
                        MessageBox.Show("Aún hay una O.T Pendiente con éste artículo!","O.T. Pendiente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar O.T. \n \n"+ex.InnerException, "Error Crítico");
                }
            }else
            {
                MessageBox.Show("Ingrese todos los valores", "Ingrese todos los valores");
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (cbAtencion.SelectedIndex != 0 && cbTecnico.SelectedIndex != 0)
            {
                try
                {
                    Orden_trabajo ot = ent.Orden_trabajo.Find(Convert.ToInt32(lbidOT.Text));
                    ot.id_atencion = Convert.ToInt32(cbAtencion.SelectedValue.ToString());
                    ot.id_tecnico = Convert.ToInt32(cbTecnico.SelectedValue.ToString());
                    ot.Estado = cbEstadoOT.SelectedItem.ToString();
                    ot.Fecha_inicio = Convert.ToDateTime(dtFechaInicio.Text);
                    ot.Fecha_termino = Convert.ToDateTime(dtFechaTer.Text);
                    ent.SaveChanges();
                    var consulta = from or in ent.Orden_trabajo
                                   join a in ent.Articulo on or.id_articulo equals a.id_articulo
                                   join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                                   join at in ent.atencion on or.id_atencion equals at.id_atencion
                                   where or.id_articulo.ToString().Contains(lbidArt.Text)
                                   select new
                                   {
                                       or.id_ot,
                                       articulo = a.marca + " " + a.modelo,
                                       tecnico = t.Nombre,
                                       or.Estado,
                                       or.Fecha_inicio,
                                       or.Fecha_termino,
                                       atencion = at.descripcion
                                   };
                    tablaOT.DataSource = consulta.ToList<object>();
                    cbAtencion.SelectedIndex = 0;
                    cbEstadoOT.SelectedIndex = 0;
                    cbTecnico.SelectedIndex = 0;
                    btGuardar.Visible = true;
                    btEditar.Visible = false;
                    lbidOT.Visible = false;
                    lbShowOT.Visible = false;
                    lbidOT.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar O.T \n \n"+ex.InnerException, "Error Crítico");
                }
            }else
            {
                MessageBox.Show("Ingrese todos los valores", "Ingrese todos los valores");
            }
        }

        private void editarOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orden_trabajo ot = ent.Orden_trabajo.Find(Convert.ToInt32(id_editar));
            lbidOT.Text = id_editar;
            lbShowOT.Visible = true;
            lbidOT.Visible = true;
            cbAtencion.SelectedValue = ot.id_atencion;
            cbEstadoOT.SelectedValue = ot.Estado;
            cbTecnico.SelectedValue = ot.id_tecnico;
            dtFechaInicio.Text = ot.Fecha_inicio.ToString();
            dtFechaTer.Text = ot.Fecha_termino.ToString();
            btGuardar.Visible = false;
            btEditar.Visible = true;
        }

        private void terminarOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var con = MessageBox.Show("¿Está seguro?", "Dar O.T. Por terminada", MessageBoxButtons.YesNo);
            if (con == DialogResult.Yes)
            {
                try
                {
                    Orden_trabajo ot = ent.Orden_trabajo.Find(Convert.ToInt32(id_editar));
                    ot.Estado = "Terminado";
                    ent.SaveChanges();
                    var consulta = from or in ent.Orden_trabajo
                                   join a in ent.Articulo on or.id_articulo equals a.id_articulo
                                   join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                                   join at in ent.atencion on or.id_atencion equals at.id_atencion
                                   where or.id_articulo.ToString().Contains(lbidArt.Text)
                                   select new
                                   {
                                       or.id_ot,
                                       articulo = a.marca + " " + a.modelo,
                                       tecnico = t.Nombre,
                                       or.Estado,
                                       or.Fecha_inicio,
                                       or.Fecha_termino,
                                       atencion = at.descripcion
                                   };
                    tablaOT.DataSource = consulta.ToList<object>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar O.T. Por terminada. \n \n"+ex.InnerException.ToString().Substring(0,200), "Error Crítico");
                }
            }
        }

        private void tablaOT_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    id_editar = tablaOT.Rows[e.RowIndex].Cells[0].Value.ToString();
                    contextMenuStrip1.Show(this.tablaOT, e.Location);
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
    }
}
