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
    public partial class frmNuevaCompra : Form
    {
        IList<Producto> listaProducto = new List<Producto>();

        public frmNuevaCompra()
        {
            InitializeComponent();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmNuevoProducto frmNuevoProducto = new frmNuevoProducto();
            frmNuevoProducto.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmNuevaCompra_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            GestorProveedores unGestorProveedores = new GestorProveedores();
            dgvProveedor.DataSource = unGestorProveedores.listarProveedores();
            dgvProveedor.Columns[0].Visible = false;
            dgvProveedor.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProveedor.Columns[3].Visible = false;
            dgvProveedor.Columns[4].Visible = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            GestorProductos unGestorProductos = new GestorProductos();

            try
            {
                if (dgvProveedor.SelectedRows.Count > 0)
                {
                   dgvProductos.DataSource = unGestorProductos.listarProductosProveedor((int)dgvProveedor.CurrentRow.Cells[0].Value);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un proveedor!");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto unProducto = new Producto();
            unProducto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            listaProducto.Add(unProducto);

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            dgvProductosComprados.DataSource = listaProducto;
        }
    }
}
