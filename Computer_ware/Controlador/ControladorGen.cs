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

        public List<tecnico> getTecnicosActivos()
        {
            try
            {
                var consulta = from t in ent.tecnico where t.estado == "Activo" select t;
                return consulta.ToList();
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
                               join or in ent.Orden_trabajo on a.id_articulo equals or.id_articulo
                               join at in ent.atencion on or.id_atencion equals at.id_atencion
                               join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                               join o in ent.Orden_servicio on a.id_os equals o.id_os
                               join c in ent.Cliente on o.id_cliente equals c.id_cliente
                               select new { a.id_articulo, a.marca, a.modelo, a.serie, a.observacion, a.fecha_recepcion, a.estado, a.Linea, t.Nombre, at.descripcion, a.id_os, cliente = c.Nombre, or.id_ot};
                BindingList<object> list = new BindingList<object>(consulta.ToList<object>());
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<object> buscarArticulos(Articulo art, string atencion, string tecnico, string estado_ot, string cliente)
        {
            try
            {
                var consulta = from a in ent.Articulo
                               join or in ent.Orden_trabajo on a.id_articulo equals or.id_articulo
                               join at in ent.atencion on or.id_atencion equals at.id_atencion
                               join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                               join o in ent.Orden_servicio on a.id_os equals o.id_os
                               join c in ent.Cliente on o.id_cliente equals c.id_cliente
                               where a.marca.Contains(art.marca) && a.modelo.Contains(art.modelo)
                               && a.Linea.Contains(art.Linea) && a.estado.Contains(art.estado)
                               && t.Nombre.Contains(tecnico)
                               && a.serie.Contains(art.serie)
                               && or.id_atencion.ToString().Contains(atencion)
                               && or.Estado.Contains(estado_ot)
                               && c.Nombre.Contains(cliente)
                               select new { a.id_articulo, a.marca, a.modelo, a.serie, a.observacion, a.fecha_recepcion, a.estado, a.Linea, t.Nombre, at.descripcion, a.id_os, cliente = c.Nombre, or.id_ot };

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
                               join or in ent.Orden_trabajo on a.id_articulo equals or.id_articulo
                               join at in ent.atencion on or.id_atencion equals at.id_atencion
                               join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                               join o in ent.Orden_servicio on a.id_os equals o.id_os 
                               join c in ent.Cliente on o.id_cliente equals c.id_cliente
                               where a.id_os.ToString().Contains(os)
                               select new { a.id_articulo, a.marca, a.modelo, a.serie, a.observacion, a.fecha_recepcion, a.estado, a.Linea, t.Nombre, at.descripcion, a.id_os, cliente = c.Nombre, or.id_ot };
                BindingList<object> list = new BindingList<object>(consulta.ToList<object>());
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public BindingList<object> buscarPorOT(string ot)
        {
            try
            {
                var consulta = from a in ent.Articulo
                               join or in ent.Orden_trabajo on a.id_articulo equals or.id_articulo
                               join at in ent.atencion on or.id_atencion equals at.id_atencion
                               join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                               join o in ent.Orden_servicio on a.id_os equals o.id_os
                               join c in ent.Cliente on o.id_cliente equals c.id_cliente
                               where or.id_ot.ToString().Contains(ot)
                               select new { a.id_articulo, a.marca, a.modelo, a.serie, a.observacion, a.fecha_recepcion, a.estado, a.Linea, t.Nombre, at.descripcion, a.id_os, cliente = c.Nombre, or.id_ot };
                BindingList<object> list = new BindingList<object>(consulta.ToList<object>());
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public BindingList<object> buscarPorFechaArt(DateTime desde, DateTime hasta)
        {
            try
            {
                var consulta = from a in ent.Articulo
                               join or in ent.Orden_trabajo on a.id_articulo equals or.id_articulo
                               join at in ent.atencion on or.id_atencion equals at.id_atencion
                               join t in ent.tecnico on or.id_tecnico equals t.id_tecnico
                               join o in ent.Orden_servicio on a.id_os equals o.id_os
                               join c in ent.Cliente on o.id_cliente equals c.id_cliente
                               where (or.Fecha_inicio >= desde && or.Fecha_inicio <= hasta) || (a.fecha_recepcion >= desde && a.fecha_recepcion <= hasta)
                               select new { a.id_articulo, a.marca, a.modelo, a.serie, a.observacion, a.fecha_recepcion, a.estado, a.Linea, t.Nombre, at.descripcion, a.id_os, cliente = c.Nombre, or.id_ot };
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
