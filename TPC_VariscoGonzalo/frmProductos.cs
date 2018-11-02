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
            GestorProductos unGestorProductos = new GestorProductos();
            dgvProductos.DataSource = unGestorProductos.listarProductos();
            dgvProductos.Columns[1].Visible = false;
        }
    }
}
