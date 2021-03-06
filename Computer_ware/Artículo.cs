﻿using System;
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

            cbEstado.SelectedIndex = 0;
            cbEstadoOT.SelectedIndex = 0;

            //cbAtencion
            BindingList<atencion> atenciones = new BindingList<atencion>(con.getAtenciones());
            atenciones.Insert(0, new atencion { id_atencion = 0, descripcion = "Seleccione" });
            cbAtencion.DataSource = atenciones;
            cbAtencion.ValueMember = "id_atencion";
            cbAtencion.DisplayMember = "descripcion";
            cbAtencion.SelectedIndex = 0;

            //cbtecnico
            BindingList<tecnico> tecnicos = new BindingList<tecnico>(con.getTecnicosActivos());
            tecnicos.Insert(0, new tecnico { id_tecnico = 0, Nombre = "Seleccione" });
            cbTecnico.DataSource = tecnicos;
            cbTecnico.ValueMember = "id_tecnico";
            cbTecnico.DisplayMember = "nombre";
            cbTecnico.SelectedIndex = 0;


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

            //datosEditar
            if (lbIDArt.Text != "" && lbIDArt.Visible == true)
            {
                dtFecha.Visible = true;
                Articulo a = ent.Articulo.Find(Convert.ToInt32(lbIDArt.Text));
                txtMarca.Text = a.marca;
                txtModelo.Text = a.modelo;
                txtSerie.Text = a.serie;
                txtObs.Text = a.observacion;
                dtFecha.Text = a.fecha_recepcion.ToShortDateString();
                cbEstado.SelectedValue = a.estado;
                txtLinea.Text = a.Linea;
                txtOS.Text = a.id_os.ToString();
            }
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
            string obs = txtObs.Text;
            string linea = txtLinea.Text;
            string os = txtOS.Text;
            
            //ot

            string fecha_inicio = dtFechaInicio.Text;
            string fecha_termino = dtFechaTer.Text;
            
            if (marca != "" && modelo != "" && serie != "" && cbTecnico.SelectedIndex != 0 && obs != "" && cbEstado.SelectedIndex != 0 && linea != "" && os != "" && cbAtencion.SelectedIndex != 0)
            {
                string estado = cbEstado.SelectedItem.ToString();
                string atencion = cbAtencion.SelectedValue.ToString();
                string tecnico = cbTecnico.SelectedValue.ToString();
                if (ent.Orden_servicio.Find(Convert.ToInt32(os)) != null)
                {
                    Articulo art = new Articulo
                    {
                        marca = marca,
                        modelo = modelo,
                        serie = serie,
                        observacion = obs,
                        Linea = linea,
                        id_os = Convert.ToInt32(os),
                        fecha_recepcion = DateTime.Now,
                        estado = estado
                    };
                    bool b = false;
                    try
                    {
                        ent.Articulo.Add(art);
                        ent.SaveChanges();
                        Orden_trabajo ot = new Orden_trabajo
                        {
                            id_articulo = art.id_articulo,
                            id_tecnico = Convert.ToInt32(tecnico),
                            Estado = "Pendiente",
                            Fecha_inicio = Convert.ToDateTime(fecha_inicio),
                            Fecha_termino = Convert.ToDateTime(fecha_termino),
                            id_atencion = Convert.ToInt32(atencion)
                        };
                        ent.Orden_trabajo.Add(ot);
                        ent.SaveChanges();
                        if (chkClose.Checked == true)
                        {
                            this.Close();
                        }else
                        {
                            txtMarca.Text = "";
                            txtLinea.Text = "";
                            txtModelo.Text = "";
                            txtObs.Text = "";
                            txtOS.Text = "";
                            txtSerie.Text = "";
                            cbAtencion.SelectedIndex = 0;
                            cbEstado.SelectedIndex = 0;
                            cbEstadoOT.SelectedIndex = 0;
                            cbTecnico.SelectedIndex = 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error crítico al guardar \n \n" + ex.InnerException.ToString(), "Error al guardar");
                    }
                }else
                {
                    MessageBox.Show("Error al guardar, la orden de servicio ingresada no existe.", "O.S No existe");
                }
            }else
            {
                MessageBox.Show("Ingrese todos los datos.");
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (lbIDArt.Text != "")
            {
                if (txtMarca.Text != "" && txtModelo.Text != "" && txtSerie.Text != "" && txtObs.Text != "" && txtLinea.Text != "" && cbEstado.SelectedIndex != 0)
                {
                    if (ent.Orden_servicio.Find(Convert.ToInt32(txtOS.Text)) != null)
                    {
                        Articulo a = ent.Articulo.Find(Convert.ToInt32(lbIDArt.Text));
                        a.marca = txtMarca.Text;
                        a.modelo = txtModelo.Text;
                        a.serie = txtSerie.Text;
                        a.observacion = txtObs.Text;
                        a.estado = cbEstado.Text;
                        a.Linea = txtLinea.Text;
                        a.id_os = Convert.ToInt32(txtOS.Text);
                        ent.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La Orden de servicio ingresada no existe!");
                    }
                }else
                {
                    MessageBox.Show("Ingrese todos los datos", "Datos insuficientes.");
                }
            }
        }

        private void txtOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <=57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }
    }
}
