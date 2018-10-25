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
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public Domicilio Domicilio { get; set; }
        public IList<Producto> Productos { get; set; }

       public Proveedor()
        {
            this.Productos = new List<Producto>();
        }

        public override string ToString()
        {
            return Nombre;
        }

        public string ProveedorProducto
        {
            get
            {
                string x = "";
                foreach(Producto p in this.Productos)
                {
                    x += (x == "" ? "" : ", ") + p.ToString();
                }
                  return x;
            }
        }
    }
}
