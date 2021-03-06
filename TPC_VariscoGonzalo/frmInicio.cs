﻿using System;
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
    public partial class frmInicio : Form
    {

        private Usuario1 usuarioLogueado;

        public Usuario1 UsuarioLogueado
        {
            get { return usuarioLogueado; }
        }

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnRegistroVenta_Click(object sender, EventArgs e)
        {
            frmRegistroVenta frmRegistroVenta = new frmRegistroVenta();
            frmRegistroVenta.ShowDialog();
        }

        private void btnRegistroCompra_Click(object sender, EventArgs e)
        {
            frmRegistroCompra frmRegistroCompra = new frmRegistroCompra();
            frmRegistroCompra.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos unForm = new frmProductos();
            unForm.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                usuarioLogueado = new Usuario1();
                frmLogin login = new frmLogin(usuarioLogueado);
                login.ShowDialog();

                if (usuarioLogueado.Perfil.Id == 2)
                {
                    lblPerfil.Text = usuarioLogueado.NombreUsuario;
                    btnProveedores.Enabled = false;
                    btnAdminUsuarios.Enabled = false;
                }
                else
                {
                    lblPerfil.Text = usuarioLogueado.NombreUsuario;
                    btnProveedores.Enabled = true;
                    btnAdminUsuarios.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAdminUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios unForm = new frmUsuarios();
            unForm.Show();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
