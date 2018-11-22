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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GestorUsuarios unGestorUsuarios = new GestorUsuarios();
            Usuario1 unUsuario = new Usuario1();
            unUsuario.Perfil = new PerfilUsuario();

            try
            {
                if (tboxClave.Text.Trim() == tboxConfirmacionClave.Text.Trim())
                {
                    unUsuario.NombreUsuario = tboxNombreUsuario.Text.Trim();
                    unUsuario.Pass = tboxClave.Text.Trim();
                    unUsuario.Perfil = (PerfilUsuario)cboxPerfil.SelectedItem;

                    unGestorUsuarios.guardarNuevoUsuario(unUsuario);

                    MessageBox.Show("Usuario registrado");
                }
                else { MessageBox.Show("Verifique clave. Se confirmo de manera erronea"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
