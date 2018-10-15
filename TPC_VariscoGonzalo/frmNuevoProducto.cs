using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TPC_VariscoGonzalo
{
    public partial class frmNuevoProducto : Form
    {
        Proveedor unProveedor;

        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        public frmNuevoProducto(Proveedor unProveedor)
        {
            InitializeComponent();
            this.unProveedor = unProveedor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            GestorProductos unGestorProductos = new GestorProductos();
            GestorProveedores unGestorProveedores = new GestorProveedores();
            dgvProductos.DataSource = unGestorProductos.listarProductos();

            dgvProductos.Columns[1].Visible = false;
            dgvProductos.Columns[4].Visible = false;
            dgvProductos.Columns[5].Visible = false;
            dgvProductos.Columns[6].Visible = false;
            dgvProductos.Columns[7].Visible = false;
            dgvProductos.Columns[8].Visible = false;
            dgvProveedores.DataSource= unGestorProveedores.buscarUltimoProveedor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto unProducto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            GestorProveedores unGestorProveedores = new GestorProveedores();

            DialogResult r= MessageBox.Show("Esta por agregar un producto. Esta seguro?","Confirmacion",MessageBoxButtons.YesNo);

            if(r==DialogResult.Yes)
            {
                unGestorProveedores.agregarProducto(unProducto.Id);
            }
            else
            {

            }
        }
    }
}
