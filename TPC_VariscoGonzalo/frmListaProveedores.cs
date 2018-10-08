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
    public partial class frmListaProveedores : Form
    {
        public frmListaProveedores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmListaProveedores_Load(object sender, EventArgs e)
        {
            GestorProveedores unGestorProveedores = new GestorProveedores();

            dgvListaProveedores.DataSource = unGestorProveedores.listarProveedores();
        }
    }
}
