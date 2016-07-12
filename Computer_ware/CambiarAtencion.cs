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
    public partial class CambiarAtencion : Form
    {
        public CambiarAtencion()
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

        private void CambiarAtencion_Load(object sender, EventArgs e)
        {
            BindingList<atencion> atenciones = new BindingList<atencion>(con.getAtenciones());
            atenciones.Insert(0, new atencion { id_atencion = 0, descripcion = "Seleccione" });
            cbAtencion.DataSource = atenciones;
            cbAtencion.ValueMember = "descripcion";
            cbAtencion.DisplayMember = "descripcion";

            Articulo a = ent.Articulo.Find(Convert.ToInt32(lbIdArt.Text));
            groupBox1.Text = "Cambiar estado a " + a.marca + " " + a.modelo + " - " + a.serie;
        }

        private void btlisto_Click(object sender, EventArgs e)
        {
            Articulo a = ent.Articulo.Find(Convert.ToInt32(lbIdArt.Text));
            if (cbAtencion.SelectedIndex != 0)
            {
                try
                {
                    //a.id_atencion = Convert.ToInt32(cbAtencion.SelectedValue.ToString());
                    //ent.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar! \n"+ex.InnerException, "Error Crítico");
                }
                
            }
        }
    }
}
