using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPC_VariscoGonzalo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnRegistroVenta_Click(object sender, EventArgs e)
        {
            frmRegistroVenta frmRegistroVenta = new frmRegistroVenta();
            frmRegistroVenta.ShowDialog();
        }

        private void btnRegistroCompra_Click(object sender, EventArgs e)
        {
            frmRegistroCompra frmRegistroCompra = new frmRegistroCompra();
            frmRegistroCompra.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos unForm = new frmProductos();
            unForm.Show();
        }
    }
}
