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
            cargar();
        }

        private void cargar()
        {
            GestorClientes unGestorClientes = new GestorClientes();
            dgwClientes.DataSource = unGestorClientes.listarClientes();
        }

        private void btnEliminacionLogica_Click(object sender, EventArgs e)
        {
            GestorClientes unGestorClientes = new GestorClientes();

            try
            {
                if(dgwClientes.SelectedRows.Count>0)
                {
                    if(MessageBox.Show("Está seguro de que desea eliminar el registro?","Confirmacion",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        unGestorClientes.eliminarLogico((int)dgwClientes.CurrentRow.Cells[0].Value);
                        MessageBox.Show("Cliente eliminado");
                        cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//btn modificar registro
            if(dgwClientes.SelectedRows.Count>0)
            {
                frmAgregarCliente unForm = new frmAgregarCliente();
                unForm.setearRegistro((Cliente)dgwClientes.CurrentRow.DataBoundItem);
                unForm.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }
    }
}
