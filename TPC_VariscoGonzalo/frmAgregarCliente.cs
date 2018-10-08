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
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente unCliente = new Cliente();
            GestorClientes unGestorClientes = new GestorClientes();
            Domicilio unDomicilio = new Domicilio();

            unCliente.Nombre = tboxNombre.Text.Trim();
            unCliente.Apellido = tboxApellido.Text.Trim();
            unCliente.DNI = tboxDni.Text.Trim();
            unCliente.TelefonoFijo = tboxTelFijo.Text.Trim();
            unCliente.TelefonoCelular = tboxTelCelular.Text.Trim();
            unDomicilio.Calle = tboxCalle.Text.Trim();
            unDomicilio.Localidad = tboxLocalidad.Text.Trim();
            unDomicilio.Provincia = tboxProvincia.Text.Trim();
            unCliente.Domicilio = unDomicilio;
            unCliente.FechaNacimiento = dtpFechaNac.Value;
            if (rbtMasculino.Checked == true) { unCliente.Sexo = "M"; } else { unCliente.Sexo = "F"; }
            unCliente.email = tboxEmail.Text.Trim();
            unCliente.Cuit = tboxCuit.Text.Trim();

            unGestorClientes.agregarCliente(unCliente);

            MessageBox.Show("El cliente fue agregado");

            this.Dispose();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
