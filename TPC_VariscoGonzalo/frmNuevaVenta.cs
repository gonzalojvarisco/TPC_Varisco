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
            listaProductos.Add(unProducto);
        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            dgvProductosComprados.DataSource = listaProductos;
        }
    }
}
