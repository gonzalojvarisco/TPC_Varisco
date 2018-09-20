﻿using System;
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

            conexion.setearConsulta("SELECT p.nombre,p.apellido, c.idcliente FROM personas as p inner join CLIENTES as c on p.IDPERSONA = c.IDCLIENTE");

            conexion.leerConsulta();

            while(conexion.Lector.Read())
            {
                aux.Nombre = conexion.Lector.GetString(0);
                aux.Apellido = conexion.Lector.GetString(1);
                aux.IdCliente = conexion.Lector.GetInt32(2);
            }

            return aux;
        }
    }
}
