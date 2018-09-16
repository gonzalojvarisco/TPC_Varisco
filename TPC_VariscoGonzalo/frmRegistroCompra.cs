using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPC_VariscoGonzalo
{
    public partial class frmRegistroCompra : Form
    {
        public frmRegistroCompra()
        {
            InitializeComponent();
        }

        private void btnComprasRegistradas_Click(object sender, EventArgs e)
        {
            frmComprasRegistradas frmComprasRegistradas = new frmComprasRegistradas();
            frmComprasRegistradas.Show();
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            frmNuevaCompra frmNuevaCompra = new frmNuevaCompra();
            frmNuevaCompra.ShowDialog();
        }
    }
}
