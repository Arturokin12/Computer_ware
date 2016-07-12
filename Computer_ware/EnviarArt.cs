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

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (txtUbicación.Text != "")
            {
                try
                {
                    var consulta = from envia in ent.envio where envia.estado.Equals("Enviado") && envia.id_articulo.ToString().Equals(lbIDArticulo.Text) select envia;

                    if (consulta.ToList().Count == 0)
                    {
                        envio en = new envio
                        {
                            id_articulo = Convert.ToInt32(lbIDArticulo.Text),
                            ubicacion = txtUbicación.Text,
                            fecha_envio = Convert.ToDateTime(dateTimePicker1.Text),
                            estado = "Enviado"
                        };
                        ent.envio.Add(en);
                        ent.SaveChanges();
                        this.Close();
                    }else
                    {
                        MessageBox.Show("Ya hay un envío registrado a éste artículo que aún está pendiente.", "Artículo ya enviado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar Envío \n"+ex.InnerException.ToString().Substring(0,200), "Error Crítico");
                }
            }
        }
    }
}
