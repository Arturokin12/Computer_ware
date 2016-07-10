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
    public partial class ClienteIndex : Form
    {
        public ClienteIndex()
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

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text != "" && txtNombre.Text != "" && txtDireccion.Text != "" && txtComuna.Text != "" && txtCiudad.Text != "")
            {
                Cliente c = new Cliente {
                    Rut = txtRut.Text, Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text, Comuna = txtComuna.Text,
                    Ciudad = txtCiudad.Text, Estado = "En Contrato"
                };
                try
                {
                    ent.Cliente.Add(c);
                    ent.SaveChanges();
                    BindingList<Cliente> clientes = new BindingList<Cliente>(ent.Cliente.ToList());
                    tablaClientes.DataSource = clientes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar Cliente \n \n"+ex.InnerException, "Error Crítico");
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos.", "Datos insuficientes");
            }
        }

        private void ClienteIndex_Load(object sender, EventArgs e)
        {
            if (txtBuscarNombre.Text != "")
            {
                try
                {
                    var consulta = from c in ent.Cliente
                                   where c.Nombre.Contains(txtBuscarNombre.Text)
             || c.Rut.Contains(txtBuscarNombre.Text)
                                   select c;
                    tablaClientes.DataSource = consulta.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar." + ex.InnerException, "Error de Base de datos");
                }
            }
            else
            {
                try
                {
                    BindingList<Cliente> clientes = new BindingList<Cliente>(ent.Cliente.ToList());
                    tablaClientes.DataSource = clientes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos! \n \n" + ex.ToString(), "Error de base de datos Crítico!");
                }
            }
            
        }

        private void tablaClientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string id_cliente = "";
                string nombre = "";
                string rut = "";
                string direccion = "";
                string comuna = "";
                string ciudad = "";
                string estado = "";

                if (tablaClientes.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    id_cliente = tablaClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
                if (tablaClientes.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    nombre = tablaClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                if (tablaClientes.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    rut = tablaClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
                if (tablaClientes.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    direccion = tablaClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                if (tablaClientes.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    comuna = tablaClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                if (tablaClientes.Rows[e.RowIndex].Cells[5].Value != null)
                {
                    ciudad = tablaClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
                if (tablaClientes.Rows[e.RowIndex].Cells[6].Value != null)
                {
                    estado = tablaClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                }

                if (id_cliente != "" && nombre != "" && rut != "" && direccion != "" && comuna != "" && ciudad != "" && estado != "")
                {
                    try
                    {
                        Cliente c = ent.Cliente.Find(Convert.ToInt32(id_cliente));
                        c.Nombre = nombre;
                        c.Rut = rut;
                        c.Ciudad = ciudad;
                        c.Comuna = comuna;
                        c.Direccion = direccion;
                        c.Estado = estado;
                        ent.SaveChanges();
                        BindingList<Cliente> clientes = new BindingList<Cliente>(ent.Cliente.ToList());
                        tablaClientes.DataSource = clientes;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar Cliente \n \n"+ex.InnerException, "Error Crítico al editar");
                    }
                }
            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var consulta = from c in ent.Cliente
                               where c.Nombre.Contains(txtBuscarNombre.Text)
         || c.Rut.Contains(txtBuscarNombre.Text)
                               select c;
                tablaClientes.DataSource = consulta.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar." + ex.InnerException, "Error de Base de datos");
            }
        }
    }
}
