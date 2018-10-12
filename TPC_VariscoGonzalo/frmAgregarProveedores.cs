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
        public frmAgregarProveedores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Proveedor unProveedor = new Proveedor();

            unProveedor.Nombre = tboxNombre.Text.Trim();
            unProveedor.Cuit = tboxCuit.Text.Trim();
            unProveedor.Domicilio.Calle = tboxCalle.Text.Trim();
            unProveedor.Domicilio.Localidad = tboxLocalidad.Text.Trim();
            unProveedor.Domicilio.Provincia = tboxProvincia.Text.Trim();
            //unProveedor.Productos=;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
        }

        private void frmAgregarProveedores_Load(object sender, EventArgs e)
        {
        }
    }
}
