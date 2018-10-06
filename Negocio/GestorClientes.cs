using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class GestorClientes
    {
        public Cliente buscarCliente(int idCliente)
        {
            Cliente aux = new Cliente();

            AccesoDatos conexion = new AccesoDatos();

            conexion.setearConsulta("SELECT c.idcliente c.nombre,c.apellido,c.dni FROM clientes");

            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                aux.IdCliente = conexion.Lector.GetInt32(0);
                aux.Nombre = conexion.Lector.GetString(1);
                aux.Apellido = conexion.Lector.GetString(2);
                aux.DNI = Convert.ToString (conexion.Lector.GetInt32(3));
            }

            return aux;
        }

        public IList<Cliente> listarClientes()
        {
            IList<Cliente> lista = new List<Cliente>();
            AccesoDatos conexion = new AccesoDatos();

            conexion.setearConsulta("SELECT C.IDCLIENTE,C.NOMBRE,C.APELLIDO,C.DNI,C.TELEFONOFIJO,C.TELEFONOCELULAR,C.CALLE,C.LOCALIDAD,C.PROVINCIA,C.FECHANACIMIENTO,C.SEXO,C.EMAIL,C.CUIT FROM CLIENTES AS C");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                Cliente aux = new Cliente();

                aux.IdCliente = conexion.Lector.GetInt32(0);
                aux.Nombre = conexion.Lector.GetString(1);
                aux.Apellido = conexion.Lector.GetString(2);
                aux.DNI = Convert.ToString(conexion.Lector.GetInt32(3));

                lista.Add(aux);
            }

            return lista;
        }

        public void agregarCliente(Cliente unCliente)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO CLIENTES VALUES(";
            consulta+= "'" + unCliente.Nombre + "','" + unCliente.Apellido + "',";
            consulta += "'" + unCliente.DNI + "','" + unCliente.TelefonoFijo + "',";
            consulta += "'" + unCliente.TelefonoCelular + "','" + unCliente.Domicilio.Calle + "',";
            consulta += "'" + unCliente.Domicilio.Localidad + "','" + unCliente.Domicilio.Provincia + "',";
            consulta += "'" + unCliente.Domicilio + "','" + unCliente.FechaNacimiento.ToString() + "',";
            consulta+="'"+unCliente.Sexo+"','"+unCliente.email+"','"+unCliente.Cuit+"'" +") ";

            conexion.setearConsulta(consulta);
            conexion.ejecutarAccion();

            
        }
    }
}
