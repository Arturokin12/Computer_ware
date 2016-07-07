using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_ware.Modelo
{
    class Orden_Serv
    {
        public int id_os { get; set; }
        public string cliente { get; set; }
        public DateTime fecha_inicio { get; set; }
        public string tecnico { get; set; }

        public Orden_Serv()
        {

        }

        public Orden_Serv(int id, string c, DateTime d, string t)
        {
            this.id_os = id;
            this.cliente = c;
            this.fecha_inicio = d;
            this.tecnico = t;
        }
    }
}
