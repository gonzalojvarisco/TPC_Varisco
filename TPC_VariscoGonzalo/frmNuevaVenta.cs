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
    public partial class frmNuevaVenta : Form
    {
        Cliente unCliente;
        IList<Producto> listaProductos = new List<Producto>();
        IList<VentaItem> listaItems = new List<VentaItem>();
        Validaciones v = new Validaciones();

        public frmNuevaVenta()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.ShowDialog();
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            GestorClientes unGestorClientes;
            GestorProductos unGestorProductos;

            try
            {
                unGestorClientes = new GestorClientes();
                unGestorProductos = new GestorProductos();
                dgvCliente.DataSource = unGestorClientes.listarClientes();
                dgvProductos.DataSource = unGestorProductos.listarProductos();
                dgvProductos.Columns[1].Visible = false;
                dgvProductos.Columns[4].Visible = false;
                dgvProductos.Columns[5].Visible = false;
                dgvProductos.Columns[8].Visible = false;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            GestorProductos unGestorProductos;

            try
            {
                unGestorProductos = new GestorProductos();
                unCliente = new Cliente();

                if(dgvCliente.SelectedRows.Count>0)
                {
                    unCliente = (Cliente)dgvCliente.CurrentRow.DataBoundItem;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente");
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

            bool yaExiste = false;

            foreach(VentaItem v in listaItems)
            {
                if(v.Producto.Id==unProducto.Id)
                {
                    yaExiste = true;
                    v.Cantidad+=Convert.ToInt32(tboxCantidad.Text);
                    v.PrecioParcial = v.Cantidad * v.PrecioUnitario;
                }
            }

            if(yaExiste==false)
            {
                VentaItem item = new VentaItem();
                item.Producto = unProducto;
                item.Cantidad = Convert.ToInt32(tboxCantidad.Text);
                item.PrecioUnitario = unProducto.PrecioVenta;
                item.PrecioParcial = unProducto.PrecioVenta * item.Cantidad;

                listaItems.Add(item);
            }

            dgvProductosComprados.DataSource = null;
            dgvProductosComprados.DataSource = listaItems;
            dgvProductosComprados.Columns[0].Visible = false;
            dgvProductosComprados.Columns[1].Visible = false;

            tboxCantidad.Text = "1";
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            dgvProductosComprados.DataSource = listaProductos;
        }

        private void tboxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GestorVentas unGestorVenta = new GestorVentas();

            int idCliente;
            int idVenta;
            decimal monto;
            try
            {
                idCliente = (int)dgvCliente.CurrentRow.Cells[0].Value;
                idVenta = unGestorVenta.inicioVenta(idCliente);
                unGestorVenta.guardarCompraItems(idVenta,listaItems);
                monto = unGestorVenta.totalVenta(idVenta);
                unGestorVenta.actualizarMontoVenta(monto,idVenta);
                unGestorVenta.actualizarStockProductos(listaItems);

                MessageBox.Show("Venta registrada. - ID VENTA" + idVenta.ToString());

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
