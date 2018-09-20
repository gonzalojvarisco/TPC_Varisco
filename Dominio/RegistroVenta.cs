using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RegistroVenta
    {
        public int IdVenta { get; set; }
        public int NumeroRegistro { get; set; }
        public Cliente Cliente { get; set; }
        public IList<VentaItem> VentaItems { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public Factura NumeroFacturacion { get; set; }
    }
}
