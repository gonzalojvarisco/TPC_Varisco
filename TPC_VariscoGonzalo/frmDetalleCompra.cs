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
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        internal void mostrarDetalle(RegistroCompra detalleRegistro)
        {
            GestorCompras unGestorCompras = new GestorCompras();

            try
            {
                dgvDetalleCompra.DataSource= unGestorCompras.detalleRegistro(detalleRegistro);
                dgvDetalleCompra.Columns[1].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
