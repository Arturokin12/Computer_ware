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
    public partial class VerArtículo : Form
    {
        public VerArtículo()
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

        private void VerArtículo_Load(object sender, EventArgs e)
        {
            Articulo a = ent.Articulo.Find(Convert.ToInt32(lbIDArt.Text));
            lbMarca.Text = a.marca;
            lbModelo.Text = a.modelo;
            lbSerie.Text = a.serie;
            lbObs.Text = a.observacion;
            lbRecepción.Text = a.fecha_recepcion.ToShortDateString();
            lbLinea.Text = a.Linea;
            lbEstado.Text = a.estado;
            lbOS.Text = a.id_os.ToString();

            int idArt = Convert.ToInt32(lbIDArt.Text);
            Orden_trabajo o = new Orden_trabajo();
            try
            {
                o = ent.Orden_trabajo.First(x => x.id_articulo == idArt && x.Estado.Equals("Pendiente"));
            }
            catch (Exception)
            {
                o = null;
            }
            

            if (o != null)
            {
                tecnico t = ent.tecnico.Find(o.id_tecnico);
                lbTécnico.Text = t.Nombre;
                lbEstadoOT.Text = o.Estado;
                lbInicio.Text = o.Fecha_inicio.Value.ToLongDateString();
                lbTérmino.Text = o.Fecha_termino.Value.ToLongDateString();
                atencion at = ent.atencion.Find(o.id_atencion);
                lbAtención.Text = at.descripcion;
            }else
            {
                var consulta = from or in ent.Orden_trabajo where or.id_articulo == a.id_articulo && or.id_ot == (from ot in ent.Orden_trabajo select ot.id_ot).Max() select or;
                Orden_trabajo orden = consulta.ToList().ElementAt(0);
                tecnico t = ent.tecnico.Find(orden.id_tecnico);
                lbTécnico.Text = t.Nombre;
                lbEstadoOT.Text = orden.Estado;
                lbInicio.Text = orden.Fecha_inicio.Value.ToLongDateString();
                lbTérmino.Text = orden.Fecha_termino.Value.ToLongDateString();
                atencion at = ent.atencion.Find(orden.id_atencion);
                lbAtención.Text = at.descripcion;
            }

            try
            {
                var consulta2 = from en in ent.envio where en.estado.Equals("Enviado") && en.id_articulo == a.id_articulo select en;
                envio envio = consulta2.ToList().ElementAt(0);
                lbFechaEnvio.Text = envio.fecha_envio.ToLongDateString();
                lbEstadoEnvío.Text = envio.estado;
                lbUbicacion.Text = envio.ubicacion;
            }
            catch (Exception)
            {
                lbFechaEnvio.Text = "No hay Envío registrado con éste artículo";
                lbEstadoEnvío.Text = "No hay Envío registrado con éste artículo";
                lbUbicacion.Text = "No hay Envío registrado con éste artículo";
            }
        }
    }
}
