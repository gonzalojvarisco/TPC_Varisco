using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPC_VariscoGonzalo
{
    public partial class frmAgregarProveedores : Form
    {
        Proveedor unProveedor=new Proveedor();

        public frmAgregarProveedores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            unProveedor.Domicilio = new Domicilio();
            GestorProveedores unGestorProveedor = new GestorProveedores();
            int bandera;

            unProveedor.Nombre = tboxNombre.Text.Trim();
            unProveedor.Cuit = tboxCuit.Text.Trim();
            unProveedor.Domicilio.Calle = tboxCalle.Text.Trim();
            unProveedor.Domicilio.Localidad = tboxLocalidad.Text.Trim();
            unProveedor.Domicilio.Provincia = tboxProvincia.Text.Trim();

            if(unProveedor.IdProvedoor>0)
            {
                unGestorProveedor.modificar(unProveedor);
                MessageBox.Show("Datos de proveedor modificados...Ahora verifique los productos con los que trabaja");
                bandera = 0;
            }
            else
            {
                unGestorProveedor.agregar(unProveedor);
                MessageBox.Show("Proveedor agregado...Ahora agregue los productos con los que trabaja");
                bandera = 1;
            }


            frmNuevoProducto frmNuevoProducto = new frmNuevoProducto(unProveedor,bandera);
            frmNuevoProducto.Show();

        }

        public void setearRegistro(Proveedor x)
        {
            unProveedor.Domicilio = new Domicilio();
            unProveedor = x;
            tboxNombre.Text = unProveedor.Nombre;
            tboxCuit.Text = unProveedor.Cuit;
            tboxCalle.Text = unProveedor.Domicilio.Calle;
            tboxLocalidad.Text = unProveedor.Domicilio.Localidad;
            tboxProvincia.Text = unProveedor.Domicilio.Provincia;
        }
    }
}
