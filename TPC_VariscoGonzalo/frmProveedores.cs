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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            frmAgregarProveedores frmAgregarProveedores = new frmAgregarProveedores();
            frmAgregarProveedores.ShowDialog();
        }

        private void btnListaProveedores_Click(object sender, EventArgs e)
        {
            frmListaProveedores frmListaProveedores = new frmListaProveedores();
            frmListaProveedores.ShowDialog();
        }
    }
}
