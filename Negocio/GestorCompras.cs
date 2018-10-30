using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class GestorCompras
    {

        public IList<CompraItem> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<CompraItem> lista = new List<CompraItem>();
            CompraItem aux;

            conexion.setearConsulta("select c.idcompraitem from COMPRAITEMS as c");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                aux = new CompraItem();
                aux.IdCompraItem = conexion.Lector.GetInt32(0);

                lista.Add(aux);
            }

            return lista;


        }

        public int guardarCompra(int idProveedor)
        {
            AccesoDatos conexion;

            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("insert into REGISTROCOMPRAS output inserted.IDCOMPRA values(getdate(),0,@idProveedor)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idProveedor",idProveedor);
                conexion.abrirConexion();
                return conexion.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void guardarCompraItems(int idCompra,IList<Producto> listaProductos)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                foreach (Producto p in listaProductos)
                {
                    conexion.setearConsulta("INSERT INTO COMPRAITEMS (IDCOMPRA,IDPRODUCTO,CANTIDAD,PRECIOUNITARIO,PRECIOPARCIAL) VALUES(@IDCOMPRA,@IDPRODUCTO,1,@PRECIOUNITARIO,@PRECIOUNIT)");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@IDCOMPRA", idCompra);
                    conexion.Comando.Parameters.AddWithValue("@IDPRODUCTO", p.Id);
                    conexion.Comando.Parameters.AddWithValue("@PRECIOUNITARIO", p.PrecioVenta);
                    conexion.Comando.Parameters.AddWithValue("@PRECIOUNIT", p.PrecioVenta);
                    conexion.ejecutarAccion();
                    conexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            


        }

        public void actualizarStockProductos(IList<Producto> listaProductos)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                foreach (Producto p in listaProductos)
                {
                    conexion.setearConsulta("UPDATE PRODUCTOS SET STOCKACTUAL=STOCKACTUAL+1 WHERE IDPRODUCTO=@idProducto");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@idProducto", p.Id);
                    conexion.ejecutarAccion();
                    conexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
