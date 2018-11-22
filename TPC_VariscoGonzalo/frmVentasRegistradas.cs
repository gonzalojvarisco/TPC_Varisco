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
    public partial class frmVentasRegistradas : Form
    {
        public frmVentasRegistradas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmVentasRegistradas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            GestorVentas unGestorVentas = new GestorVentas();
            dgvVentasRegistradas.DataSource = unGestorVentas.listar();
            dgvVentasRegistradas.Columns[2].Visible = false;
            dgvVentasRegistradas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvVentasRegistradas.Columns[0].Visible = false;
            dgvVentasRegistradas.Columns[5].Visible = false;
        }

        private void btnDetalleVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentasRegistradas.SelectedRows.Count > 0)
            {
                DetalleVenta unForm = new DetalleVenta();
                unForm.mostrarDetalle((RegistroVenta)dgvVentasRegistradas.CurrentRow.DataBoundItem);
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
