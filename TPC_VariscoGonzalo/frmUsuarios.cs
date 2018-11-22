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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            GestorUsuarios unGestorUsuarios = new GestorUsuarios();

            try
            {
                cboxPerfil.DataSource = unGestorUsuarios.listarUsuarios();
                cboxPerfil.DisplayMember = "nombre";
                cboxPerfil.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
