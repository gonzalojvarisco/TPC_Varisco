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
        Cliente unCliente = new Cliente();
        Validaciones v = new Validaciones();

        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                GestorClientes unGestorClientes = new GestorClientes();

                unCliente.Domicilio = new Domicilio();

                if (tboxNombre.Text != "")
                {
                    unCliente.Nombre = tboxNombre.Text.Trim();
                }
                unCliente.Apellido = tboxApellido.Text.Trim();
                unCliente.DNI = tboxDni.Text.Trim();
                unCliente.TelefonoFijo = tboxTelFijo.Text.Trim();
                unCliente.TelefonoCelular = tboxTelCelular.Text.Trim();
                unCliente.Domicilio.Calle = tboxCalle.Text.Trim();
                unCliente.Domicilio.Localidad = tboxLocalidad.Text.Trim();
                unCliente.Domicilio.Provincia = tboxProvincia.Text.Trim();
                unCliente.FechaNacimiento = dtpFechaNac.Value;
                if (rbtMasculino.Checked == true) { unCliente.Sexo = "M"; } else { unCliente.Sexo = "F"; }
                unCliente.email = tboxEmail.Text.Trim();
                unCliente.Cuit = tboxCuit.Text.Trim();
               /* else
                {
                    MessageBox.Show("Faltan completar datos");
                    return;
                }*/
            if(unCliente.IdCliente>0)
            {
                unGestorClientes.modificar(unCliente);
                MessageBox.Show("El cliente fue modificado");
            }
            else
            {
                unGestorClientes.agregarCliente(unCliente);
                MessageBox.Show("El cliente fue agregado");
            }

            this.Dispose();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setearRegistro(Cliente x)
        {
            unCliente.Domicilio = new Domicilio();

            unCliente = x;
            tboxNombre.Text = x.Nombre;
            tboxApellido.Text = x.Apellido;
            tboxDni.Text = x.DNI;
            tboxTelFijo.Text = x.TelefonoFijo;
            tboxTelCelular.Text = x.TelefonoCelular;
            tboxCalle.Text = x.Domicilio.Calle;
            tboxLocalidad.Text = x.Domicilio.Localidad;
            tboxProvincia.Text = x.Domicilio.Provincia;
            dtpFechaNac.Value = x.FechaNacimiento;
            tboxEmail.Text = x.email;
            tboxCuit.Text = x.Cuit;


        }

        private void tboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloLetras(e);
        }

        private void tboxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }
    }
}
