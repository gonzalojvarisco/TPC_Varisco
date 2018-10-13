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
            Producto aux=new Producto();
            aux.tipo = new TipoProducto();
            aux.Marca = new Marca();
            GestorProductos unGestorProductos = new GestorProductos();

            conexion.setearConsulta("select p.IDPRODUCTO,t.nombre,m.nombre from productos as p inner join TIPOPRODUCTO as t on p.IDPRODUCTO = t.IDTIPOPRODUCTO inner join MARCAS as m on p.IDMARCA = m.IDMARCA");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                aux.Id = conexion.Lector.GetInt32(0);
                aux.tipo.Nombre = conexion.Lector.GetString(1);
                aux.Marca.Nombre = conexion.Lector.GetString(2);

                lista.Add(aux);
            }

            return lista;
        }

        public string listarTipos(int aux)
        {
            AccesoDatos conexion = new AccesoDatos();
            string nombre;

            conexion.setearConsulta("select t.nombre from TIPOPRODUCTO as t where t.IDTIPOPRODUCTO="+aux);
            conexion.leerConsulta();

            nombre = conexion.Lector.GetString(0);

            return nombre;
        }
    }
}
