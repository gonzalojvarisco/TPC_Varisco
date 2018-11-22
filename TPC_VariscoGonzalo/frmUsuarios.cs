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

        Usuario1 unUsuario = new Usuario1();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            GestorUsuarios unGestorUsuarios = new GestorUsuarios();

            try
            {
                tboxNombreUsuario.Text = "";
                tboxClave.Text = "";
                tboxConfirmacionClave.Text = "";
                cboxPerfil.DataSource = unGestorUsuarios.listarPerfiles();
                cboxPerfil.DisplayMember = "nombre";
                cboxPerfil.ValueMember = "id";

                cboxUsuarios.DataSource = unGestorUsuarios.listarUsuarios();
                cboxUsuarios.DisplayMember = "NombreUsuario";
                cboxUsuarios.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GestorUsuarios unGestorUsuarios = new GestorUsuarios();
            unUsuario.Perfil = new PerfilUsuario();

            try
            {
                if (tboxClave.Text.Trim() == tboxConfirmacionClave.Text.Trim() && tboxClave.Text.Trim() !="" && tboxConfirmacionClave.Text.Trim() !="")
                {
                    unUsuario.NombreUsuario = tboxNombreUsuario.Text.Trim();
                    unUsuario.Pass = tboxClave.Text.Trim();
                    unUsuario.Perfil = (PerfilUsuario)cboxPerfil.SelectedItem;

                    if (unUsuario.Id == 0)
                    {
                        unGestorUsuarios.guardarNuevoUsuario(unUsuario);
                        MessageBox.Show("Usuario registrado");
                    }
                    else
                    {
                        unGestorUsuarios.modificarUsuario(unUsuario);
                        MessageBox.Show("Usuario Modificado");
                    }

                    cargar();

                }
                else { MessageBox.Show("Verifique clave. Se confirmo de manera erronea o se dejo campo vacio"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                unUsuario = (Usuario1)cboxUsuarios.SelectedItem;

                cargar(unUsuario);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargar(Usuario1 unUsuario)
        {
            GestorUsuarios unGestorUsuarios = new GestorUsuarios();

            try
            {
                tboxNombreUsuario.Text = unUsuario.NombreUsuario;
                cboxPerfil.DataSource = unGestorUsuarios.listarPerfiles();
                cboxPerfil.DisplayMember = "nombre";
                cboxPerfil.ValueMember = "id";

                cboxUsuarios.DataSource = unGestorUsuarios.listarUsuarios();
                cboxUsuarios.DisplayMember = "NombreUsuario";
                cboxUsuarios.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
