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
            GestorProductos unGestorProductos = new GestorProductos();

            conexion.setearConsulta("select p.IDPRODUCTO,t.nombre,m.nombre from productos as p inner join TIPOPRODUCTO as t on p.IDPRODUCTO = t.IDTIPOPRODUCTO inner join MARCAS as m on p.IDMARCA = m.IDMARCA");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                aux = new Producto();
                aux.Tipo = new TipoProducto();
                aux.Marca = new Marca();
                aux.Id = conexion.Lector.GetInt32(0);
                aux.Tipo.Nombre = conexion.Lector.GetString(1);
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


        public List<Marca> listarMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDatos conexion = new AccesoDatos();
            Marca aux;

            conexion.setearConsulta("select * from marcas");
            conexion.leerConsulta();

            while (conexion.Lector.Read())
            {
                aux = new Marca();
                aux.Id = (int)conexion.Lector["IdMarca"];
                aux.Nombre = (string)conexion.Lector["Nombre"];

                marcas.Add(aux);
            }
            return marcas;
        }

        public int agregarTipo(TipoProducto tipo)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setearConsulta("insert into TIPOPRODUCTO output inserted.Idtipoproducto values (@nombre)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", tipo.Nombre);

                conexion.abrirConexion();
                return conexion.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                conexion.cerrarConexion();
            }

        }

        public int agregarMarca(Marca marca)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into MARCAS output inserted.idmarca values (@nombre)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", marca.Nombre);

                conexion.abrirConexion();
                return conexion.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                conexion.cerrarConexion();
            }

        }


        public List<TipoProducto> listarTipos()
        {
            List<TipoProducto> tipos = new List<TipoProducto>();
            AccesoDatos conexion = new AccesoDatos();
            TipoProducto aux;

            conexion.setearConsulta("select * from TIPOPRODUCTO");
            conexion.leerConsulta();

            while (conexion.Lector.Read())
            {
                aux = new TipoProducto();
                aux.Id = (int)conexion.Lector["IdTipoProducto"];
                aux.Nombre = (string)conexion.Lector["Nombre"];
                tipos.Add(aux);
            }



            return tipos;
        }

        public void guardarProducto(Producto unProducto)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setearConsulta("insert into productos values (@idtipoproducto,@idmarca,@codigo,@preciocosto,@precioventa,@stockactual,@stockminimo)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idtipoproducto",unProducto.Tipo.Id);
                conexion.Comando.Parameters.AddWithValue("@idmarca", unProducto.Marca.Id);
                conexion.Comando.Parameters.AddWithValue("@codigo", unProducto.Codigo);
                conexion.Comando.Parameters.AddWithValue("@preciocosto", unProducto.PrecioCosto);
                conexion.Comando.Parameters.AddWithValue("@precioventa", unProducto.PrecioVenta);
                conexion.Comando.Parameters.AddWithValue("@stockactual", unProducto.StockActual);
                conexion.Comando.Parameters.AddWithValue("@stockminimo", unProducto.StockMinimo);

                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
