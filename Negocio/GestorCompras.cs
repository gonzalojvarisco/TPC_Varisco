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
            foreach(Producto p in listaProductos)
            {
                
            }
        }
    }
}
