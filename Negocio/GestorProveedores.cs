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
            Proveedor aux;
            Domicilio aux1;

            conexion.setearConsulta("SELECT P.IDPROVEEDOR,P.NOMBRE,P.CUIT,P.CALLE,P.LOCALIDAD,P.PROVINCIA FROM PROVEEDORES AS P");
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

                lista.Add(aux);
                
            }

            return lista;
        }

        public IList<Proveedor> buscarProveedores()
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

        public void agregar(Proveedor unProveedor)
        {
            AccesoDatos conexion = new AccesoDatos();
            
            conexion.setearConsulta("insert into PROVEEDORES values(@nombre,@cuit,@calle,@localidad,@provincia)");
            conexion.Comando.Parameters.Clear();
            conexion.Comando.Parameters.AddWithValue("@nombre",unProveedor.Nombre);
            conexion.Comando.Parameters.AddWithValue("@cuit",unProveedor.Cuit);
            conexion.Comando.Parameters.AddWithValue("@calle",unProveedor.Domicilio.Calle);
            conexion.Comando.Parameters.AddWithValue("@localidad",unProveedor.Domicilio.Localidad);
            conexion.Comando.Parameters.AddWithValue("@provincia",unProveedor.Domicilio.Provincia);

            conexion.ejecutarAccion();

            

        }
    }
}
