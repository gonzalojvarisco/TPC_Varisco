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

        public IList<Producto> listarProductosProveedor(int idProvedoor)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Producto> lista = new List<Producto>();
            GestorProductos unGestor = new GestorProductos();

            try
            {
                conexion.setearConsulta("select IDPRODUCTO from PROVEEDORES_X_PRODUCTO where IDPROVEEDOR="+idProvedoor);
                conexion.leerConsulta();

                while(conexion.Lector.Read())
                {
                    lista.Add(unGestor.buscarProducto(conexion.Lector.GetInt32(0)));
                }

                return lista;


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private Producto buscarProducto(int idProducto)
        {
            AccesoDatos conexion = new AccesoDatos();
            Producto unProducto = new Producto();
            unProducto.Tipo = new TipoProducto();
            unProducto.Marca = new Marca();

            try
            {
                conexion.setearConsulta("select t.IDTIPOPRODUCTO,t.NOMBRE,m.IDMARCA,m.NOMBRE,p.CODIGO,p.PRECIOCOSTO,p.PRECIOVENTA,p.STOCKACTUAL,p.STOCKMINIMO from PRODUCTOS as p inner join TIPOPRODUCTO as t on p.IDTIPOPRODUCTO = t.IDTIPOPRODUCTO inner join MARCAS as m on p.IDMARCA = m.IDMARCA where p.idproducto=" + idProducto);
                conexion.leerConsulta();

                while(conexion.Lector.Read())
                {
                    unProducto.Id = idProducto;
                    unProducto.Tipo.Id = conexion.Lector.GetInt32(0);
                    unProducto.Tipo.Nombre = conexion.Lector.GetString(1);
                    unProducto.Marca.Id = conexion.Lector.GetInt32(2);
                    unProducto.Marca.Nombre = conexion.Lector.GetString(3);
                    unProducto.Codigo = conexion.Lector.GetString(4);
                    unProducto.PrecioCosto = conexion.Lector.GetDecimal(5);
                    unProducto.PrecioVenta = conexion.Lector.GetDecimal(6);
                    unProducto.StockActual = conexion.Lector.GetInt32(7);
                    unProducto.StockMinimo = conexion.Lector.GetInt32(8);

                }

                return unProducto;
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
