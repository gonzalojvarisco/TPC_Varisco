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
    public partial class DetalleVenta : Form
    {
        public DetalleVenta()
        {
            InitializeComponent();
        }

        internal void mostrarDetalle(RegistroVenta detalleRegistro)
        {
            GestorVentas unGestorVentas = new GestorVentas();

            try
            {
                dgvDetalleVenta.DataSource = unGestorVentas.detalleRegistro(detalleRegistro);
                dgvDetalleVenta.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
