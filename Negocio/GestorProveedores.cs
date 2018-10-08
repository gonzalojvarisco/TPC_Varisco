using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
