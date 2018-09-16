using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public int IdProvedoor { get; set; }
        public string NombreProveedor { get; set; }
        public string Cuit { get; set; }
        public Domicilio Domicilio { get; set; }
        public IList<Producto> Productos { get; set; }
    }
}
