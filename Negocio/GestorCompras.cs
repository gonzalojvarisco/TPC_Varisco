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

        public IList<RegistroCompra> listar()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<RegistroCompra> lista = new List<RegistroCompra>();
            RegistroCompra aux;
            GestorProveedores gp = new GestorProveedores();

            conexion.setearConsulta("SELECT idcompra,fecha,idproveedor,total FROM REGISTROCOMPRAS");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                aux = new RegistroCompra();
                aux.IdCompra = conexion.Lector.GetInt32(0);
                aux.Fecha = conexion.Lector.GetDateTime(1);
                aux.Proveedor = gp.buscarPorId( conexion.Lector.GetInt32(2) );
                aux.Total = conexion.Lector.GetDecimal(3);
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

        public void guardarCompraItems(int idCompra,IList<CompraItem> listaItems)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                foreach ( CompraItem p in listaItems)
                {
                    conexion.setearConsulta("INSERT INTO COMPRAITEMS (IDCOMPRA,IDPRODUCTO,CANTIDAD,PRECIOUNITARIO,PRECIOPARCIAL) VALUES(@IDCOMPRA,@IDPRODUCTO,@CANTIDAD,@PRECIOUNITARIO,@PRECIOPARCIAL)");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@IDCOMPRA", idCompra);
                    conexion.Comando.Parameters.AddWithValue("@IDPRODUCTO", p.Producto.Id);
                    conexion.Comando.Parameters.AddWithValue("@CANTIDAD", p.Cantidad);
                    conexion.Comando.Parameters.AddWithValue("@PRECIOUNITARIO", p.PrecioUnitario);
                    conexion.Comando.Parameters.AddWithValue("@PRECIOPARCIAL", p.PrecioParcial);
                    conexion.ejecutarAccion();
                    conexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            


        }

        public void actualizarStockProductos(IList<CompraItem> listaItems)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                foreach ( CompraItem p in listaItems)
                {
                    conexion.setearConsulta("UPDATE PRODUCTOS SET STOCKACTUAL=STOCKACTUAL+@CANTIDAD WHERE IDPRODUCTO=@idProducto");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@idProducto", p.Producto.Id);
                    conexion.Comando.Parameters.AddWithValue("@CANTIDAD", p.Cantidad);
                    conexion.ejecutarAccion();
                    conexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void actualizarMontoTotal(decimal monto, int idCompra)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setearConsulta("UPDATE REGISTROCOMPRAS SET TOTAL=@MONTO WHERE IDCOMPRA=@IDCOMPRA");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@MONTO", monto);
                conexion.Comando.Parameters.AddWithValue("@IDCOMPRA", idCompra);
                conexion.ejecutarAccion();
                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public decimal totalCompra(int idCompra)
        {
            AccesoDatos conexion = new AccesoDatos();
            decimal totalCompra = 0;

            try
            {
                conexion.setearConsulta("SELECT SUM(PRECIOPARCIAL) FROM COMPRAITEMS WHERE IDCOMPRA="+idCompra);
                conexion.leerConsulta();

                while(conexion.Lector.Read())
                {
                    totalCompra= conexion.Lector.GetDecimal(0);
                }
                
                return totalCompra;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
