using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /*public class ModeloDominio
    {
        public class Persona
        {
            public int IdPersona { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string DNI { get; set; }
            public string TelefonoFijo { get; set; }
            public string TelefonoCelular { get; set; }
            public Domicilio Domicilio { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Sexo { get; set; }
            public string email { get; set; }
            public int Cuit { get; set; }

        }

        public class Domicilio
        {
            public int IdDomicilio { get; set; }
            public string Calle { get; set; }
            public string Localidad { get; set; }
            public string Provincia { get; set; }
            public int Codigopostal { get; set; }
            public string Pais { get; set; }
        }

        public class Cliente:Persona
        {
            public int IdCliente { get; set; }
        }

        public class Proveedor
        {
            public int IdProvedoor { get; set; }
            public string NombreProveedor { get; set; }
            public string Cuit { get; set; }
            public Domicilio Domicilio { get; set; }
            public IList<Producto> Productos { get; set; }
        }

        public class Producto
        {
            public int Id { get; set; }
            public IList<Proveedor> Proveedores { get; set; }
            public TipoProducto tipo { get; set; }
            public Marca Marca { get; set; }
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
            public int IdCompra { get; set; }
            public string NumeroRegistro { get; set; }
            public DateTime fecha { get; set; }
            public IList<CompraItem> CompraItems { get; set; }
            public Proveedor proveedor { get; set; }
        }

        public class CompraItem
        {
            public int IdCompraItem { get; set; }
            public RegistroCompra Compra { get; set; }
            public Producto Producto { get; set; }
            public int Cantidad { get; set; }
            public Decimal PrecioCompra { get; set; }
        }

        public class RegistroVenta
        {
            public int IdVenta { get; set; }
            public string NumeroRegistro { get; set; }
            public Cliente Cliente { get; set; }
            public IList<VentaItem> VentaItems { get; set; }
            public DateTime Fecha { get; set; }
            public decimal Total { get; set; }
            public Factura NumeroFacturacion { get; set; }
        }

        public class VentaItem
        {
            public int IdVentaItem { get; set; }
            public RegistroVenta Venta { get; set; }
            public Producto Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal PrecioParcial { get; set; }
        }

        public class Marca
        {
            public int IdMarca { get; set; }
            public string Nombre { get; set; }
        }

        public class Stock
        {
            public int Id { get; set; }
            public int Actual { get; set; }
            public int Minimo { get; set; }
        }

        public class Factura //// TERMINAR DE ARMAR
        {
            public int IdFactura { get; set; }
            public DateTime Fecha { get; set; }
            public Cliente Cliente { get; set; }
        }

        public class Usuario // VERIFICAR
        {
            public int Id { get; set; }
            public string Loguin { get; set; }
            public PerfilUsuario perfil { get; set; }
        }

        public class PerfilUsuario  //VERIFICAR
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }
    }*/
    }
