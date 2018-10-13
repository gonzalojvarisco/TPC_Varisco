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
    public partial class frmNuevoProducto : Form
    {
        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            GestorProductos unGestorProductos = new GestorProductos();
            dgvProductos.DataSource = unGestorProductos.listarProductos();
        }
    }
}
