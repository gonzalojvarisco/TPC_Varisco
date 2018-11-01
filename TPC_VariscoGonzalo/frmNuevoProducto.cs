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
            cargarFormulario();
        }

        private void cargarFormulario()
        {
            GestorProductos unGestorProductos = new GestorProductos();
            GestorProveedores unGestorProveedores = new GestorProveedores();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = unGestorProductos.listarProductos();

            dgvProductos.Columns[1].Visible = false;
            dgvProductos.Columns[4].Visible = false;
            dgvProductos.Columns[5].Visible = false;
            dgvProductos.Columns[6].Visible = false;
            dgvProductos.Columns[7].Visible = false;
            dgvProductos.Columns[8].Visible = false;

            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = unGestorProveedores.buscarProveedor(unProveedor.IdProvedoor);

            dgvProveedores.Columns[0].Visible = false;
            dgvProveedores.Columns[2].Visible = false;
            dgvProveedores.Columns[3].Visible = false;
            dgvProveedores.Columns[4].Visible = false;

            cboxTipo.DataSource = unGestorProductos.listarTipos();
            cboxTipo.DisplayMember = "Nombre";
            cboxTipo.ValueMember = "Id";

            cboxMarca.DataSource = unGestorProductos.listarMarcas();
            cboxMarca.DisplayMember = "Nombre";
            cboxMarca.ValueMember = "Id";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto unProducto = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            GestorProveedores unGestorProveedores = new GestorProveedores();

            DialogResult r= MessageBox.Show("Esta por asociar un producto. ¿Esta seguro?","Confirmacion",MessageBoxButtons.YesNo);

            if(r==DialogResult.Yes)
            {
                unGestorProveedores.agregarProducto(unProducto.Id,unProveedor.IdProvedoor);
            }
            else
            {

            }
            MessageBox.Show("Se asocio el producto correctamente");
            cargarFormulario();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            GestorProductos unGestorProductos = new GestorProductos();
            Producto unProducto = new Producto();
            unProducto.Tipo = new TipoProducto();
            unProducto.Marca = new Marca();
            Double porcentaje;
            bool banderaMarca=false;
            bool banderaTipo=false;

            unProducto.Codigo = tboxCodigo.Text.Trim();
            unProducto.PrecioCosto = Convert.ToDecimal(tboxPrecioCosto.Text.Trim());
            porcentaje = Convert.ToDouble(tboxPorcentajeGanancia.Text.Trim());
            unProducto.StockActual = Convert.ToInt32(tboxStockActual.Text.Trim());
            unProducto.StockMinimo = Convert.ToInt32(tboxStockMinimo.Text.Trim());
            
            if(tboxTipo.Text.Trim()=="")
            {
                unProducto.Tipo = (TipoProducto)cboxTipo.SelectedItem;
            }
            else
            {
                unProducto.Tipo.Nombre = tboxTipo.Text.Trim();
                banderaTipo = true;
            }

            if (tboxMarca.Text.Trim() == "")
            {
                unProducto.Marca = (Marca)cboxMarca.SelectedItem;
            }
            else
            {
                unProducto.Marca.Nombre = tboxMarca.Text.Trim();
                banderaMarca = true;
            }

            if (banderaTipo == true)
            {
               unProducto.Tipo.Id= unGestorProductos.agregarTipo(unProducto.Tipo);
            }

            if(banderaMarca==true)
            {
                unProducto.Marca.Id = unGestorProductos.agregarMarca(unProducto.Marca);
            }

             unGestorProductos.guardarProducto(unProducto);

            MessageBox.Show("Producto guardado");

            cargarFormulario();
        }
    }
}
