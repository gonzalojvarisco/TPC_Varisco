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
    public partial class frmComprasRegistradas : Form
    {
        public frmComprasRegistradas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmComprasRegistradas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            GestorCompras unGestorCompras = new GestorCompras();

            dgvComprasRegistradas.DataSource = unGestorCompras.listar();
            dgvComprasRegistradas.Columns[0].Visible = false;
            dgvComprasRegistradas.Columns[2].Visible = false;
        }

        private void btnDetalleCompra_Click(object sender, EventArgs e)
        {
            if(dgvComprasRegistradas.SelectedRows.Count > 0)
            {
                frmDetalleCompra unForm = new frmDetalleCompra();
                unForm.mostrarDetalle((RegistroCompra)dgvComprasRegistradas.CurrentRow.DataBoundItem);
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
