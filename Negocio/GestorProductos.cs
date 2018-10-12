using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class GestorProductos
    {
        public IList<Producto>listarProductos()
        {
            IList<Producto> lista = new List<Producto>();
            AccesoDatos conexion = new AccesoDatos();
            Producto aux;
            GestorProveedores unGestorProveedores = new GestorProveedores();

            conexion.setearConsulta("");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                aux = new Producto();

                aux.Id = conexion.Lector.GetInt32(0);
                aux.Proveedores = unGestorProveedores.listarProveedores();
            }

            return lista;
        }
    }
}
