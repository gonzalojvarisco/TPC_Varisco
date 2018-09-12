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
    public partial class frmRegistroVenta : Form
    {
        public frmRegistroVenta()
        {
            InitializeComponent();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            frmNuevaVenta frmNuevaVenta = new frmNuevaVenta();
            frmNuevaVenta.ShowDialog();
        }

        private void btnVentasRegistradas_Click(object sender, EventArgs e)
        {
            frmVentasRegistradas frmVentasRegistradas = new frmVentasRegistradas();
            frmVentasRegistradas.ShowDialog();
        }
    }
}
