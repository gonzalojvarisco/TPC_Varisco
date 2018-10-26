using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RegistroCompra
    {
        public int IdCompra { get; set; }
        public Proveedor Proveedor { get; set; }
        public IList<CompraItem> CompraItems { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
    }
}
