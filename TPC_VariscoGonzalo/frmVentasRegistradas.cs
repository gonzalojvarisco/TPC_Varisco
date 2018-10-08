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
    public partial class frmVentasRegistradas : Form
    {
        public frmVentasRegistradas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmVentasRegistradas_Load(object sender, EventArgs e)
        {
            GestorVentas unGestorVentas = new GestorVentas();
           // dgvVentasRegistradas.DataSource = unGestorVentas.listar();
        }
    }
}
