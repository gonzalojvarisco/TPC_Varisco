using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
        public IList<Proveedor> Proveedores { get; set; }
        public TipoProducto tipo { get; set; }
        public Marca Marca { get; set; }
        public string Codigo { get; set; }
        public Decimal PrecioCosto { get; set; }
        public Decimal PrecioVenta { get; set; }
        public Stock Stock { get; set; }
    }
}
