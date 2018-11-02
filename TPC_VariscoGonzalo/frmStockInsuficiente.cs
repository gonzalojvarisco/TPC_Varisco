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
    public partial class frmStockInsuficiente : Form
    {

        List<Producto> lista = new List<Producto>();

        public frmStockInsuficiente()
        {
            InitializeComponent();
        }

        public frmStockInsuficiente(List<Producto> lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void frmStockInsuficiente_Load(object sender, EventArgs e)
        {
            dgvProdStockInsficiente.DataSource = lista;
            dgvProdStockInsficiente.Columns[1].Visible = false;
            dgvProdStockInsficiente.Columns[4].Visible = false;
            dgvProdStockInsficiente.Columns[5].Visible = false;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
