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

                while(conexion.Lector.Read())
                {
                    RegistroVenta aux = new RegistroVenta();
               
                    aux.IdVenta = conexion.Lector.GetInt32(0);
                    aux.Cliente = unGestorClientes.buscarCliente( conexion.Lector.GetInt32(1));
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
    }
}
