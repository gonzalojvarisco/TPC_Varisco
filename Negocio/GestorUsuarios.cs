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
    }
}
