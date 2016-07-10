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
    public partial class EnviarArt : Form
    {
        public EnviarArt()
        {
            InitializeComponent();
        }

        WarehouseEntities ent = new WarehouseEntities();

        private void EnviarArt_Load(object sender, EventArgs e)
        {
            if (lbIDArticulo.Text != "")
            {
                Articulo a = ent.Articulo.Find(Convert.ToInt32(lbIDArticulo.Text));
                groupBox1.Text = "Enviar "+a.marca + " " + a.modelo + " - " + a.serie;

            }
        }
    }
}
