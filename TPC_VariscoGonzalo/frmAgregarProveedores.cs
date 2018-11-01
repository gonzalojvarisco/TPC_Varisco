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
        Validaciones v = new Validaciones();

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
            if (tboxNombre.Text != "" & tboxCuit.Text != "" & tboxCalle.Text != "" & tboxLocalidad.Text != "" & tboxProvincia.Text != "")
            {
                unProveedor.Domicilio = new Domicilio();
                GestorProveedores unGestorProveedor = new GestorProveedores();

                unProveedor.Nombre = tboxNombre.Text.Trim();
                unProveedor.Cuit = tboxCuit.Text.Trim();
                unProveedor.Domicilio.Calle = tboxCalle.Text.Trim();
                unProveedor.Domicilio.Localidad = tboxLocalidad.Text.Trim();
                unProveedor.Domicilio.Provincia = tboxProvincia.Text.Trim();

                if (unProveedor.IdProvedoor > 0)
                {
                    unGestorProveedor.modificar(unProveedor);
                    MessageBox.Show("Datos de proveedor modificados. Ahora verifique los productos con los que trabaja");
                }
                else
                {
                    unGestorProveedor.agregar(unProveedor);
                    MessageBox.Show("Proveedor agregado. Ahora asocie los productos con los que trabaja");
                }

                frmNuevoProducto frmNuevoProducto = new frmNuevoProducto(unProveedor);
                frmNuevoProducto.Show();
            }
            else
            {
                MessageBox.Show("Deben completarse todos los datos para guardar el registro");
            }
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

        private void tboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void tboxCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void frmAgregarProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
