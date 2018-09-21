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
    public partial class frmListaClientes : Form
    {
        public frmListaClientes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            GestorClientes unGestorClientes = new GestorClientes();
            dgwClientes.DataSource = unGestorClientes.listarClientes();
        }
    }
}
