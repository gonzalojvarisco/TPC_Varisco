using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoCelular { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string email { get; set; }

    }

    public class Clientes:Persona
    {
        public string CUIT { get; set; }
    }

    public class Proveedor:Persona
    {
        public string CUIT { get; set; }
        public string NombreProveedor { get; set; }
        public Producto producto { get; set; }
    }

    public class Producto
    {
        public int Id { get; set; }
        public TipoProducto tipo { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Precio { get; set; }
    }

    public class TipoProducto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class RegistroCompra
    {
        public int Id { get; set; }
        public string NumeroRegistro { get; set; }
        public Producto Producto { get; set; }
    }

    public class RegistroVenta
    {
        public int Id { get; set; }
        public string NumeroRegistro { get; set; }
        public Producto Producto { get; set; }
    }

    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Stock
    {

    }

    public class Facturacion
    {

    }

    public class usuario
    {
        public int Id { get; set; }
        public string Loguin { get; set; }
        public PerfilUsuario perfil { get; set; }
    }

    public class PerfilUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
