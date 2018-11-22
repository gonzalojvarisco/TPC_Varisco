using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TPC_VariscoGonzalo
{
    public partial class frmLogin : Form
    {
        private Usuario1 usuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(Usuario1 us)
        {
            InitializeComponent();
            usuario = us;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usuario.Id == 0)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            GestorUsuarios unGestorUsuario = new GestorUsuarios();
            try
            {
                usuario.NombreUsuario = tboxUsuario.Text.Trim();
                usuario.Pass = tboxPass.Text.Trim();
                if (unGestorUsuario.validarUsuario(usuario))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("usuario o pass incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
