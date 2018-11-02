using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class GestorProveedores
    {
        public IList<Proveedor>listarProveedores()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Proveedor> lista = new List<Proveedor>();
            GestorProductos unGestorProductos = new GestorProductos();
            Proveedor aux;
            Domicilio aux1;

            conexion.setearConsulta("SELECT P.IDPROVEEDOR,P.NOMBRE,P.CUIT,P.CALLE,P.LOCALIDAD,P.PROVINCIA FROM PROVEEDORES AS P where p.activo=1");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                aux = new Proveedor();
                aux1 = new Domicilio();

                aux.IdProvedoor = conexion.Lector.GetInt32(0);
                aux.Nombre = conexion.Lector.GetString(1);
                aux.Cuit = conexion.Lector.GetString(2);
                aux1.Calle = conexion.Lector.GetString(3);
                aux1.Localidad = conexion.Lector.GetString(4);
                aux1.Provincia = conexion.Lector.GetString(5);
                aux.Domicilio = aux1;
                aux.Productos = unGestorProductos.listarProductosProveedor(aux.IdProvedoor);

                lista.Add(aux);
                
            }

            return lista;
        }

        public void modificar(Proveedor unProveedor)
        {
            AccesoDatos conexion= new AccesoDatos();

            try
            {
                conexion.setearConsulta("update PROVEEDORES set NOMBRE=@nombre, CUIT=@cuit, CALLE=@calle, LOCALIDAD=@localidad,PROVINCIA=@provincia where IDPROVEEDOR=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", unProveedor.Nombre);
                conexion.Comando.Parameters.AddWithValue("@cuit", unProveedor.Cuit);
                conexion.Comando.Parameters.AddWithValue("@calle", unProveedor.Domicilio.Calle);
                conexion.Comando.Parameters.AddWithValue("@localidad", unProveedor.Domicilio.Localidad);
                conexion.Comando.Parameters.AddWithValue("@provincia", unProveedor.Domicilio.Provincia);
                conexion.Comando.Parameters.AddWithValue("@id", unProveedor.IdProvedoor);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public IList<Proveedor> buscarProveedor(int idProvedoor)
        {
            AccesoDatos conexion;
            Proveedor aux;
            IList<Proveedor> lista = new List<Proveedor>();
            GestorProductos unGestorProductos = new GestorProductos();

            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select IDPROVEEDOR,NOMBRE,CUIT,CALLE,LOCALIDAD,PROVINCIA from PROVEEDORES where IDPROVEEDOR="+idProvedoor);
                conexion.leerConsulta();
                
                while(conexion.Lector.Read())
                {
                    aux = new Proveedor();
                    aux.Domicilio = new Domicilio();
                    aux.IdProvedoor = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.Cuit = conexion.Lector.GetString(2);
                    aux.Domicilio.Calle = conexion.Lector.GetString(3);
                    aux.Domicilio.Localidad = conexion.Lector.GetString(4);
                    aux.Domicilio.Provincia = conexion.Lector.GetString(5);
                    aux.Productos = unGestorProductos.listarProductosProveedor(idProvedoor);

                    lista.Add(aux);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return lista;
        }

        public IList<Producto> confirmarNoSeaRepetido(int idProvedoor)
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Producto> listaProductos = new List<Producto>();
            Producto aux;

            try
            {
                conexion.setearConsulta("select pxp.IDPRODUCTO from PROVEEDORES_X_PRODUCTO as pxp where IDPROVEEDOR="+idProvedoor);
                conexion.leerConsulta();

                while(conexion.Lector.Read())
                {
                    aux = new Producto();
                    aux.Id = conexion.Lector.GetInt32(0);

                    listaProductos.Add(aux);
                }
                return listaProductos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Proveedor buscarPorId(int idProvedoor)
        {
            AccesoDatos conexion;
            Proveedor aux;
            aux = new Proveedor();
            GestorProductos unGestorProductos = new GestorProductos();

            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select IDPROVEEDOR,NOMBRE,CUIT,CALLE,LOCALIDAD,PROVINCIA from PROVEEDORES where IDPROVEEDOR=" + idProvedoor);
                conexion.leerConsulta();

                while (conexion.Lector.Read())
                {
                    aux.Domicilio = new Domicilio();
                    aux.IdProvedoor = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    aux.Cuit = conexion.Lector.GetString(2);
                    aux.Domicilio.Calle = conexion.Lector.GetString(3);
                    aux.Domicilio.Localidad = conexion.Lector.GetString(4);
                    aux.Domicilio.Provincia = conexion.Lector.GetString(5);
                    aux.Productos = unGestorProductos.listarProductosProveedor(idProvedoor);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return aux;
        }

        public void eliminarLogico(int id)
        {
            AccesoDatos conexion;

            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update proveedores set activo=0 where IDPROVEEDOR=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id",id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<Proveedor> buscarUltimoProveedor()
        {
            IList<Proveedor> aux1 = new List <Proveedor>();
            AccesoDatos conexion = new AccesoDatos();

            conexion.setearConsulta("select top(1) p.IDPROVEEDOR,p.NOMBRE,p.CUIT from PROVEEDORES as p order by p.IDPROVEEDOR desc");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                Proveedor aux = new Proveedor();
                aux.IdProvedoor = conexion.Lector.GetInt32(0);
                aux.Nombre = conexion.Lector.GetString(1);
                aux.Cuit = conexion.Lector.GetString(2);

                aux1.Add(aux);
                
            }
            return aux1;
        }

        public void agregarProducto(int idProducto,int idProveedor)
        {
            AccesoDatos conexion = new AccesoDatos();
            GestorProveedores unGestorProveedores = new GestorProveedores();

            conexion.setearConsulta("insert into PROVEEDORES_X_PRODUCTO values (@idProveedor,@idProducto)");
            conexion.Comando.Parameters.Clear();
            conexion.Comando.Parameters.AddWithValue("@idProveedor",idProveedor);
            conexion.Comando.Parameters.AddWithValue("@idProducto",idProducto);

            conexion.ejecutarAccion();
        }

        private Proveedor buscarUltProveedor()
        {
            Proveedor aux1 = new Proveedor();
            AccesoDatos conexion = new AccesoDatos();

            conexion.setearConsulta("select top(1) p.IDPROVEEDOR,p.NOMBRE,p.CUIT from PROVEEDORES as p order by p.IDPROVEEDOR desc");
            conexion.leerConsulta();

            while (conexion.Lector.Read())
            {
                aux1.IdProvedoor = conexion.Lector.GetInt32(0);
                aux1.Nombre = conexion.Lector.GetString(1);
                aux1.Cuit = conexion.Lector.GetString(2);

            }
            return aux1;
        }

        public void agregar(Proveedor unProveedor)
        {
            AccesoDatos conexion = new AccesoDatos();
            
            conexion.setearConsulta("insert into PROVEEDORES values(@nombre,@cuit,@calle,@localidad,@provincia,@activo)");
            conexion.Comando.Parameters.Clear();
            conexion.Comando.Parameters.AddWithValue("@nombre",unProveedor.Nombre);
            conexion.Comando.Parameters.AddWithValue("@cuit",unProveedor.Cuit);
            conexion.Comando.Parameters.AddWithValue("@calle",unProveedor.Domicilio.Calle);
            conexion.Comando.Parameters.AddWithValue("@localidad",unProveedor.Domicilio.Localidad);
            conexion.Comando.Parameters.AddWithValue("@provincia",unProveedor.Domicilio.Provincia);
            conexion.Comando.Parameters.AddWithValue("@activo", 1);

            conexion.ejecutarAccion();

            Proveedor nuevoProveedor = this.buscarUltProveedor();
            unProveedor.IdProvedoor = nuevoProveedor.IdProvedoor;

        }
    }
}
