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
        IList<CompraItem> listaItems = new List<CompraItem>();

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

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Producto unProducto = new Producto();
            unProducto = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            bool yaEstaEnLista = false;
            foreach (CompraItem i in listaItems)
            {
                if ( i.Producto.Id == unProducto.Id )
                {
                    yaEstaEnLista = true;
                    i.Cantidad += Convert.ToInt32(txtCant.Text);
                    i.PrecioParcial = i.PrecioUnitario * i.Cantidad;
                }
            }

            if (  yaEstaEnLista == false)
            {
                CompraItem item = new CompraItem();
                item.Producto = unProducto;
                item.Cantidad = Convert.ToInt32(txtCant.Text);
                item.PrecioUnitario = unProducto.PrecioVenta;
                item.PrecioParcial = item.PrecioUnitario * item.Cantidad;
                listaItems.Add(item);
            }


            dgvProductosComprados.DataSource = null;
            dgvProductosComprados.DataSource = listaItems;
            dgvProductosComprados.Columns[0].Visible = false;
            dgvProductosComprados.Columns[1].Visible = false;

            txtCant.Text = "1";
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            dgvProductosComprados.DataSource = listaProducto;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GestorCompras unGestorCompras = new GestorCompras();

            try
            {
                int idProveedor;
                int idCompra;
                decimal monto;

                if (dgvProductosComprados.DataSource == null)
                {
                    MessageBox.Show("No hay ningun producto agregado para realizar la compra");
                    return;
                }

                idProveedor = (int)dgvProveedor.CurrentRow.Cells[0].Value;
                idCompra=unGestorCompras.guardarCompra(idProveedor);

                unGestorCompras.guardarCompraItems(idCompra,listaItems);
                monto=unGestorCompras.totalCompra(idCompra);
                unGestorCompras.actualizarMontoTotal(monto,idCompra);
                unGestorCompras.actualizarStockProductos(listaItems);

                MessageBox.Show("Compra registrada - ID COMPRA:" + idCompra.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
