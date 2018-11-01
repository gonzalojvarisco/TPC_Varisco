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

            conexion.setearConsulta("SELECT c.idcliente, c.nombre,c.apellido,c.dni FROM clientes as c where idcliente="+idCliente);

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

            conexion.setearConsulta("SELECT C.IDCLIENTE,C.NOMBRE,C.APELLIDO,C.DNI,C.TELEFONOFIJO,C.TELEFONOCELULAR,C.CALLE,C.LOCALIDAD,C.PROVINCIA,C.FECHANACIMIENTO,C.SEXO,C.EMAIL,C.CUIT FROM CLIENTES AS C where c.ACTIVO=1");
            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                Cliente aux = new Cliente();
                Domicilio aux1 = new Domicilio();

                aux.IdCliente = conexion.Lector.GetInt32(0);
                aux.Nombre = conexion.Lector.GetString(1);
                aux.Apellido = conexion.Lector.GetString(2);
                aux.DNI = Convert.ToString(conexion.Lector.GetInt32(3));
                aux.TelefonoFijo = conexion.Lector.GetString(4);
                aux.TelefonoCelular = conexion.Lector.GetString(5);
                aux1.Calle = conexion.Lector.GetString(6);
                aux1.Localidad = conexion.Lector.GetString(7);
                aux1.Provincia = conexion.Lector.GetString(8);
                aux.Domicilio = aux1;
                aux.FechaNacimiento = conexion.Lector.GetDateTime(9);
                aux.Sexo = conexion.Lector.GetString(10);
                aux.email = conexion.Lector.GetString(11);
                aux.Cuit = conexion.Lector.GetString(12);

                lista.Add(aux);
            }

            return lista;
        }

        public void modificar(Cliente unCliente)
        {
            AccesoDatos conexion;

            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update clientes set NOMBRE=@nombre,APELLIDO=@apellido,DNI=@dni,TELEFONOFIJO=@telefonofijo,TELEFONOCELULAR=@telefonocelular,CALLE=@calle,LOCALIDAD=@localidad,PROVINCIA=@provincia,FECHANACIMIENTO=@fechanacimiento,SEXO=@sexo,EMAIL=@email,CUIT=@cuit where IDCLIENTE= @id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", unCliente.Nombre);
                conexion.Comando.Parameters.AddWithValue("@apellido", unCliente.Apellido);
                conexion.Comando.Parameters.AddWithValue("@dni", unCliente.DNI);
                conexion.Comando.Parameters.AddWithValue("@telefonofijo", unCliente.TelefonoFijo);
                conexion.Comando.Parameters.AddWithValue("@telefonocelular", unCliente.TelefonoCelular);
                conexion.Comando.Parameters.AddWithValue("@calle", unCliente.Domicilio.Calle);
                conexion.Comando.Parameters.AddWithValue("@localidad", unCliente.Domicilio.Localidad);
                conexion.Comando.Parameters.AddWithValue("@provincia", unCliente.Domicilio.Provincia);
                conexion.Comando.Parameters.AddWithValue("@fechanacimiento", unCliente.FechaNacimiento);
                conexion.Comando.Parameters.AddWithValue("@sexo", unCliente.Sexo);
                conexion.Comando.Parameters.AddWithValue("@email", unCliente.email);
                conexion.Comando.Parameters.AddWithValue("@cuit", unCliente.Cuit);
                conexion.Comando.Parameters.AddWithValue("@id", unCliente.IdCliente);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void eliminarLogico(int id)
        {
            AccesoDatos conexion;

            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("update clientes set activo=0 where IDCLIENTE=@id");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@id",id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregarCliente(Cliente unCliente)
        {
            AccesoDatos conexion = new AccesoDatos();

            string consulta = "INSERT INTO CLIENTES VALUES(";
            consulta+= "'" + unCliente.Nombre + "','" + unCliente.Apellido + "',";
            consulta += "'" + unCliente.DNI + "','" + unCliente.TelefonoFijo + "',";
            consulta += "'" + unCliente.TelefonoCelular + "','" + unCliente.Domicilio.Calle + "',";
            consulta += "'" + unCliente.Domicilio.Localidad + "','" + unCliente.Domicilio.Provincia + "',";
            consulta += "'" + unCliente.FechaNacimiento.ToString() + "',";
            consulta+="'"+unCliente.Sexo+"','"+unCliente.email+"','"+unCliente.Cuit + "',"+1+")";

            conexion.setearConsulta(consulta);
            conexion.ejecutarAccion();

            
        }
    }
}
