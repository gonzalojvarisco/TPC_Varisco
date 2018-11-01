using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class GestorVentas
    {
        public IList<RegistroVenta> listar()
        {

            IList<RegistroVenta> lista = new List<RegistroVenta>();
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setearConsulta("select * from REGISTROVENTAS");

                conexion.leerConsulta();
                GestorClientes unGestorClientes = new GestorClientes();
                GestorVentas unGestorVentas = new GestorVentas();

                while (conexion.Lector.Read())
                {
                    RegistroVenta aux = new RegistroVenta();
                    aux.Cliente = new Cliente();

                    aux.IdVenta = conexion.Lector.GetInt32(0);
                    aux.Cliente = unGestorClientes.buscarCliente(conexion.Lector.GetInt32(1));
                    aux.VentaItems = unGestorVentas.buscarVentaItem(aux.IdVenta);
                    aux.Fecha = conexion.Lector.GetDateTime(2);
                    aux.Total = conexion.Lector.GetDecimal(3);
                    aux.NumeroFacturacion = unGestorVentas.buscarFactura(conexion.Lector.GetInt32(4));

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }

        }


        public IList<VentaItem> buscarVentaItem(int idVenta)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<VentaItem> resultado = new List<VentaItem>();

            conexion.setearConsulta("select VENTAITEMS.IDVENTAITEM from VENTAITEMS where IDVENTA='"+idVenta+"'");

            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                VentaItem aux = new VentaItem();
                aux.IdVentaItem = conexion.Lector.GetInt32(0);
                resultado.Add(aux);
            }

            return resultado;
        }

        public Factura buscarFactura(int idFactura)
        {
            Factura aux = new Factura();
            AccesoDatos conexion = new AccesoDatos();
            conexion.setearConsulta("select facturas.IDFACTURA from FACTURAS where FACTURAS.IDFACTURA ='"+idFactura+"'");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                
                aux.IdFactura = conexion.Lector.GetInt32(0);

            }

            return aux;
        }

        public int inicioVenta(int idCliente)
        {
            AccesoDatos conexion = new AccesoDatos();
            int idFactura=0;


            try
            {
                idFactura=generacionFactura(idCliente);

                conexion.setearConsulta("insert into REGISTROVENTAS output inserted.IDVENTA values (@idCliente,GETDATE(),0,@idFacturacion)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idCliente", idCliente);
                conexion.Comando.Parameters.AddWithValue("@idFacturacion", idFactura);
                conexion.abrirConexion();

                return conexion.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private int generacionFactura(int idCliente)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                conexion.setearConsulta("insert into FACTURAS output inserted.IDFACTURA values (GETDATE(),@idCliente)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@idCliente", idCliente);
                conexion.abrirConexion();

                return conexion.ejecutarAccionReturn();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void guardarCompraItems(int idVenta, IList<VentaItem> listaItems)
        {
            AccesoDatos conexion = new AccesoDatos();

            try
            {
                foreach (VentaItem v in listaItems)
                {
                    conexion.setearConsulta("insert into VENTAITEMS values(@IDVENTA,@IDPRODUCTO,@CANTIDAD,@PRECIOUNITARIO,@PRECIOPARCIAL)");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@IDVENTA", idVenta);
                    conexion.Comando.Parameters.AddWithValue("@IDPRODUCTO", v.Producto.Id );
                    conexion.Comando.Parameters.AddWithValue("@CANTIDAD", v.Cantidad);
                    conexion.Comando.Parameters.AddWithValue("@PRECIOUNITARIO", v.PrecioUnitario);
                    conexion.Comando.Parameters.AddWithValue("@PRECIOPARCIAL", v.PrecioParcial);

                    conexion.ejecutarAccion();
                    conexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void actualizarStockProductos(IList<VentaItem> listaItems)
        {
                AccesoDatos conexion = new AccesoDatos();

                try
                {
                    foreach (VentaItem v in listaItems)
                    {
                        conexion.setearConsulta("UPDATE PRODUCTOS SET STOCKACTUAL=STOCKACTUAL-@CANTIDAD WHERE IDPRODUCTO=@idProducto");
                        conexion.Comando.Parameters.Clear();
                        conexion.Comando.Parameters.AddWithValue("@idProducto", v.Producto.Id);
                        conexion.Comando.Parameters.AddWithValue("@CANTIDAD", v.Cantidad);
                        conexion.ejecutarAccion();
                        conexion.cerrarConexion();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
        }

        public void actualizarMontoVenta(decimal monto, int idVenta)
        {
                AccesoDatos conexion = new AccesoDatos();

                try
                {
                    conexion.setearConsulta("UPDATE REGISTROVENTAS SET TOTAL=@MONTO WHERE IDVENTA=@IDVENTA");
                    conexion.Comando.Parameters.Clear();
                    conexion.Comando.Parameters.AddWithValue("@MONTO", monto);
                    conexion.Comando.Parameters.AddWithValue("@IDVENTA", idVenta);
                    conexion.ejecutarAccion();
                    conexion.cerrarConexion();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
        }

        public decimal totalVenta(int idVenta)
        {
                AccesoDatos conexion = new AccesoDatos();
                decimal totalVenta = 0;

                try
                {
                    conexion.setearConsulta("SELECT SUM(PRECIOPARCIAL) FROM VENTAITEMS WHERE IDVENTA=" + idVenta);
                    conexion.leerConsulta();

                    while (conexion.Lector.Read())
                    {
                         totalVenta = conexion.Lector.GetDecimal(0);
                    }

                    return totalVenta;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
        }
    }
}
