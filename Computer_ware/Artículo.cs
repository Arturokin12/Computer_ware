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
    public partial class Artículo : Form
    {
        public Artículo()
        {
            InitializeComponent();
        }

        ControladorGen con = new ControladorGen();
        WarehouseEntities ent = new WarehouseEntities();

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

        private void Artículo_Load(object sender, EventArgs e)
        {
            
            //cbAtencion
            BindingList<atencion> atenciones = new BindingList<atencion>(con.getAtenciones());
            atenciones.Insert(0, new atencion { id_atencion = 0, descripcion = "Seleccione" });
            cbAtencion.DataSource = atenciones;
            cbAtencion.ValueMember = "id_atencion";
            cbAtencion.DisplayMember = "descripcion";

            //cbtecnico
            BindingList<tecnico> tecnicos = new BindingList<tecnico>(con.getTecnicos());
            tecnicos.Insert(0, new tecnico { id_tecnico = 0, Nombre = "Seleccione" });
            cbTecnico.DataSource = tecnicos;
            cbTecnico.ValueMember = "id_tecnico";
            cbTecnico.DisplayMember = "nombre";


            //autoComplete
            txtMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMarca.AutoCompleteCustomSource = Autocomplete("marca");
            txtMarca.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //txtModelo auto
            txtModelo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtModelo.AutoCompleteCustomSource = Autocomplete("modelo");
            txtModelo.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //txtLinea
            txtLinea.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtLinea.AutoCompleteCustomSource = Autocomplete("linea");
            txtLinea.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //txtOS
            txtOS.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtOS.AutoCompleteCustomSource = Autocomplete("os");
            txtOS.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //txtObs
            txtObs.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtObs.AutoCompleteCustomSource = Autocomplete("obs");
            txtObs.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public AutoCompleteStringCollection Autocomplete(string valor)
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            if (valor == "marca")
            {
                List<Articulo> list = ent.Articulo.ToList();
                foreach (var i in list)
                {
                    coleccion.Add(i.marca.ToString());
                }
            }
            if (valor == "modelo")
            {
                List<Articulo> list = ent.Articulo.ToList();
                foreach (var i in list)
                {
                    coleccion.Add(i.modelo.ToString());
                }
            }
            if (valor == "linea")
            {
                List<Articulo> list = ent.Articulo.ToList();
                foreach (var i in list)
                {
                    coleccion.Add(i.Linea.ToString());
                }
            }
            if (valor == "os")
            {
                List<Orden_servicio> list = ent.Orden_servicio.ToList();
                foreach (var i in list)
                {
                    coleccion.Add(i.id_os.ToString());
                }
            }
            if (valor == "obs")
            {
                List<Articulo> list = ent.Articulo.ToList();
                foreach (var i in list)
                {
                    coleccion.Add(i.observacion.ToString());
                }
            }
            
            return coleccion;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string serie = txtSerie.Text;
            string tecnico = cbTecnico.SelectedValue.ToString();
            string obs = txtObs.Text;
            
            string linea = txtLinea.Text;
            string atencion = cbAtencion.SelectedValue.ToString();
            string os = txtOS.Text;

            if (marca != "" && modelo != "" && serie != "" && cbTecnico.SelectedIndex != 0 && obs != "" && cbEstado.SelectedIndex != 0 && linea != "" && os != "" && cbAtencion.SelectedIndex != 0)
            {
                string estado = cbEstado.SelectedItem.ToString();
                Articulo art = new Articulo {
                    marca = marca, modelo = modelo, serie = serie, id_tecnico = Convert.ToInt32(tecnico),
                    observacion = obs, Linea = linea, id_atencion = Convert.ToInt32(atencion),
                    id_os = Convert.ToInt32(os), fecha_recepcion = DateTime.Now
                };
                bool b = false;
                try
                {
                    ent.Articulo.Add(art);
                    ent.SaveChanges();
                    if (chkClose.Checked == true)
                    {
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error crítico al guardar \n \n"+ex.InnerException, "Error al guardar");
                }
            }else
            {
                MessageBox.Show("Ingrese todos los datos.");
            }
        }
    }
}
