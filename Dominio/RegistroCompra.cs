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
        public string NumeroRegistro { get; set; }
        public DateTime fecha { get; set; }
        public IList<CompraItem> CompraItems { get; set; }
        public Proveedor proveedor { get; set; }
    }
}
