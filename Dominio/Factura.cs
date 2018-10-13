using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }

        public override string ToString()
        {
            return IdFactura.ToString();
        }
    }
}
