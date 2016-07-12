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

namespace Computer_ware
{
    public partial class EditarEstadoArt : Form
    {
        public EditarEstadoArt()
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

        private void EditarEstadoArt_Load(object sender, EventArgs e)
        {
            Articulo a = ent.Articulo.Find(Convert.ToInt32(lbIdArt.Text));
            groupBox1.Text = "Cambiar estado a " + a.marca + " " + a.modelo + " - " + a.serie;
            cbEstado.SelectedItem = a.estado;
        }

        private void btlisto_Click(object sender, EventArgs e)
        {
            Articulo a = ent.Articulo.Find(Convert.ToInt32(lbIdArt.Text));
            try
            {
                if (cbEstado.SelectedIndex != 0)
                {
                    a.estado = cbEstado.SelectedItem.ToString();
                    ent.SaveChanges();
                    this.Close();
                }else
                {
                    MessageBox.Show("Seleccione el estado.", "Dato no ingresado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar! \n" + ex.ToString(), "Error Crítico");
            }
        }
    }
}
