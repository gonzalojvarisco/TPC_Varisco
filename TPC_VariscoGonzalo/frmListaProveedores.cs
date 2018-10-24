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
    public partial class frmListaProveedores : Form
    {
        public frmListaProveedores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmListaProveedores_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            GestorProveedores unGestorProveedores = new GestorProveedores();

            dgvListaProveedores.DataSource = unGestorProveedores.listarProveedores();
        }

        private void btnEliminacionLogica_Click(object sender, EventArgs e)
        {
            GestorProveedores unGestorProveedores = new GestorProveedores();

            try
            {
                if (dgvListaProveedores.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Está seguro de que desea eliminar el registro?", "confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        unGestorProveedores.eliminarLogico((int)dgvListaProveedores.CurrentRow.Cells[0].Value);
                        MessageBox.Show("¡Proveedor eliminado!");
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

                throw ex;
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            if(dgvListaProveedores.SelectedRows.Count>0)
            {
                frmAgregarProveedores unForm = new frmAgregarProveedores();
                unForm.setearRegistro((Proveedor)dgvListaProveedores.CurrentRow.DataBoundItem);
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
