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

    public class Cliente:Persona
    {
        public string CUIT { get; set; }
    }

    public class Proveedor:Persona
    {
        public string CUIT { get; set; }
        public string NombreProveedor { get; set; }
        public string Direccion { get; set; }
        public IList<Producto> Productos { get; set; }
    }

    public class Producto
    {
        public int Id { get; set; }
        public IList<Proveedor> Proveedores { get; set; }
        public TipoProducto tipo { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public Decimal PrecioCosto { get; set; }
        public Decimal PrecioVenta { get; set; }
        public Stock Stock { get; set; }
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
        public Proveedor proveedor { get; set; }
    }

    public class RegistroVenta
    {
        public int Id { get; set; }
        public string NumeroRegistro { get; set; }
        public Cliente Cliente { get; set; }
        public IList<Producto> Productos { get; set; }
        public decimal Total { get; set; }
        public Factura NumeroFacturacion { get; set; }
    }

    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Stock
    {
        public int Id { get; set; }
        public int Actual { get; set; }
        public int Minimo { get; set; }
    }

    public class Factura
    {
        public int IdFactura { get; set; }
    }

    public class Usuario
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
