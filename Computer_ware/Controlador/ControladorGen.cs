using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computer_ware.Modelo;
using System.ComponentModel;

namespace Computer_ware.Controlador
{
    class ControladorGen
    {
        WarehouseEntities ent = new WarehouseEntities();

        public bool login(string pass)
        {
            try
            {
                var consulta = from a in ent.Admin where a.contraseña.Equals(pass) select a;
                if (consulta.ToList().Count == 1)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<tecnico> getTecnicos()
        {
            try
            {
                return ent.tecnico.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<atencion> getAtenciones()
        {
            try
            {
                return ent.atencion.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Cliente> getClientes()
        {
            try
            {
                return ent.Cliente.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public BindingList<object> getArticulos()
        {
            try
            {
                var consulta = from a in ent.Articulo
                               join t in ent.tecnico on a.id_tecnico equals t.id_tecnico
                               join at in ent.atencion on a.id_atencion equals at.id_atencion
                               select new { a.id_articulo, a.marca, a.modelo, a.serie, a.observacion, a.fecha_recepcion, a.estado, a.Linea, t.Nombre, at.descripcion, a.id_os};
                BindingList<object> list = new BindingList<object>(consulta.ToList<object>());
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<object> buscarArticulos(Articulo art, string atencion, string tecnico)
        {
            try
            {
                var consulta = from a in ent.Articulo
                               join t in ent.tecnico on a.id_tecnico equals t.id_tecnico
                               join at in ent.atencion on a.id_atencion equals at.id_atencion
                               where a.marca.Contains(art.marca) && a.modelo.Contains(art.modelo)
                               && a.Linea.Contains(art.Linea) && a.estado.Contains(art.estado)
                               && t.Nombre.Contains(tecnico) && at.descripcion.Contains(atencion)
                               && a.serie.Contains(art.serie)
                               select new { a.id_articulo, a.marca, a.modelo, a.serie, a.observacion, a.fecha_recepcion, a.estado, a.Linea, t.Nombre, at.descripcion, a.id_os };
                
                return consulta.ToList<object>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public BindingList<object> buscarPorOS(string os)
        {
            try
            {
                var consulta = from a in ent.Articulo
                               join t in ent.tecnico on a.id_tecnico equals t.id_tecnico
                               join at in ent.atencion on a.id_atencion equals at.id_atencion
                               where a.id_os.ToString().Contains(os)
                               select new { a.id_articulo, a.marca, a.modelo, a.serie, a.observacion, a.fecha_recepcion, a.estado, a.Linea, t.Nombre, at.descripcion, a.id_os };
                BindingList<object> list = new BindingList<object>(consulta.ToList<object>());
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
