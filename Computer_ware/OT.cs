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
                               join t in ent.tecnico on or.id_atencion equals t.id_tecnico
                               join at in ent.atencion on or.id_atencion equals at.id_atencion
                               where or.id_articulo.ToString().Contains(lbidArt.Text)
                               select new {
                                   or.id_ot, articulo = a.marca+" "+a.modelo, tecnico = t.Nombre, 
                                   or.Estado, or.Fecha_inicio, or.Fecha_termino, atencion = at.descripcion
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
            cbTecnico.ValueMember = "nombre";
            cbTecnico.DisplayMember = "nombre";


            cbEstadoOT.SelectedIndex = 0;

            if (lbidArt.Text != "")
            {
                Articulo a = ent.Articulo.Find(Convert.ToInt32(lbidArt.Text));
                groupBox2.Text = "Registrar orden de trabajo a "+a.marca+" "+a.modelo + " - "+a.serie;

            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
