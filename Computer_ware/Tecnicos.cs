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
    public partial class Tecnicos : Form
    {
        public Tecnicos()
        {
            InitializeComponent();
        }

        WarehouseEntities ent = new WarehouseEntities();

        private void Tecnicos_Load(object sender, EventArgs e)
        {
            BindingList<tecnico> lista = new BindingList<tecnico>(ent.tecnico.ToList());
            dataGridView1.DataSource = lista;
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

        private void btGuardarTec_Click(object sender, EventArgs e)
        {
            if (txtNombreTec.Text != "")
            {
                tecnico t = new tecnico
                {
                    Nombre = txtNombreTec.Text,
                    estado = "Activo"
                };
                try
                {
                    ent.tecnico.Add(t);
                    ent.SaveChanges();
                    BindingList<tecnico> lista = new BindingList<tecnico>(ent.tecnico.ToList());
                    dataGridView1.DataSource = lista;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar \n" + ex.InnerException);
                }
            }else
            {
                MessageBox.Show("Ingrese el nombre del técnico.");
            }
        }
    }
}
