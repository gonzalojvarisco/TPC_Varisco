using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class GestorUsuarios
    {
        public bool validarUsuario(Usuario1 usuario)
        {
            AccesoDatos conexion;
            try
            {
                conexion = new AccesoDatos();
                conexion.setearConsulta("select IDUSUARIO, NOMBRE, PASS, IDPERFILUSUARIO from USUARIOS1 Where NOMBRE=@usuario and PASS=@pass");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@usuario", usuario.NombreUsuario);
                conexion.Comando.Parameters.AddWithValue("@pass", usuario.Pass);
                conexion.leerConsulta();
                if (conexion.Lector.Read())
                {
                    usuario.Id = (int)conexion.Lector["IDUSUARIO"];
                    usuario.NombreUsuario = (string)conexion.Lector["NOMBRE"];
                    usuario.Pass = (string)conexion.Lector["PASS"];
                    usuario.Perfil = new PerfilUsuario();
                    usuario.Perfil.Id = (int)conexion.Lector["IDPERFILUSUARIO"];
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Usuario1> listarUsuarios()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<Usuario1> lista = new List<Usuario1>();
            Usuario1 aux;

            try
            {
                //le paso el select a mi objeto conexion (de mi clase custom)
                conexion.setearConsulta("select IDUSUARIO, NOMBRE From USUARIOS1");
                //ejecuto la lectura
                conexion.leerConsulta();

                //leo lector que quedó dentro de mi objeto.
                while (conexion.Lector.Read())
                {
                    //por cada lectura creo un aux cone el constructor de Marca
                    aux = new Usuario1();
                    aux.Id = conexion.Lector.GetInt32(0);
                    aux.NombreUsuario = conexion.Lector.GetString(1);
                    //lo agrego a la lista.
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void modificarUsuario(Usuario1 unUsuario)
        {
            AccesoDatos conexion = new AccesoDatos();


            try
            {
                conexion.setearConsulta("update USUARIOS1 set NOMBRE=@nombre, PASS=@PASS, IDPERFILUSUARIO=@IDPERFILUSUARIO where IDUSUARIO=@IDUSUARIO");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@nombre", unUsuario.NombreUsuario);
                conexion.Comando.Parameters.AddWithValue("@PASS", unUsuario.Pass);
                conexion.Comando.Parameters.AddWithValue("@IDPERFILUSUARIO", unUsuario.Perfil.Id);
                conexion.Comando.Parameters.AddWithValue("@IDUSUARIO", unUsuario.Id);

                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<PerfilUsuario> listarPerfiles()
        {
            AccesoDatos conexion = new AccesoDatos();
            IList<PerfilUsuario> lista = new List<PerfilUsuario>();
            PerfilUsuario aux;

            try
            {
                //le paso el select a mi objeto conexion (de mi clase custom)
                conexion.setearConsulta("select IDPERFILUSUARIO, nombre From PERFILESUSUARIOS");
                //ejecuto la lectura
                conexion.leerConsulta();

                //leo lector que quedó dentro de mi objeto.
                while (conexion.Lector.Read())
                {
                    //por cada lectura creo un aux cone el constructor de Marca
                    aux = new PerfilUsuario();
                    aux.Id = conexion.Lector.GetInt32(0);
                    aux.Nombre = conexion.Lector.GetString(1);
                    //lo agrego a la lista.
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        public void guardarNuevoUsuario(Usuario1 unUsuario)
        {
            AccesoDatos conexion = new AccesoDatos();


            try
            {
                conexion.setearConsulta("insert into USUARIOS1 values (@NombreUsuario,@Pass,@idPerfil)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@NombreUsuario", unUsuario.NombreUsuario);
                conexion.Comando.Parameters.AddWithValue("@Pass", unUsuario.Pass);
                conexion.Comando.Parameters.AddWithValue("@idPerfil", unUsuario.Perfil.Id);

                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
