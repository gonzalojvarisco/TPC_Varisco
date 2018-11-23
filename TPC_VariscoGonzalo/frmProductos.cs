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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            GestorProductos unGestorProductos = new GestorProductos();
            dgvProductos.DataSource = unGestorProductos.listarProductos();
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[1].Visible = false;
            dgvProductos.Columns[4].Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestorProductos unGestorProductos = new GestorProductos();

            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro de que desea eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        unGestorProductos.eliminarLogico((int)dgvProductos.CurrentRow.Cells[0].Value);
                        MessageBox.Show("Producto eliminado");
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                frmEditarProductos unForm = new frmEditarProductos();
                unForm.setearRegistro((Producto)dgvProductos.CurrentRow.DataBoundItem);
                unForm.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }
    }
}
