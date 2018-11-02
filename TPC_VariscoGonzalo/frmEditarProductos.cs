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
    public partial class frmEditarProductos : Form
    {
        Producto unProducto = new Producto();

        public frmEditarProductos()
        {
            InitializeComponent();
        }

        public void setearRegistro(Producto x)
        {
            unProducto = x;

            tboxTipo.Text = x.Tipo.Nombre;
            tboxMarca.Text = x.Marca.Nombre;
            tboxPrecioCosto.Text = Convert.ToString(x.PrecioCosto);
            tboxPrecioVenta.Text = Convert.ToString(x.PrecioVenta);
            tboxStockMinimo.Text = Convert.ToString(x.StockMinimo);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GestorProductos unGestorProductos = new GestorProductos();

            try
            {
                if (tboxTipo.Text != "" & tboxMarca.Text != "" & tboxPrecioCosto.Text != "" & tboxPrecioVenta.Text != "" & tboxStockMinimo.Text != "")
                {
                    unProducto.Tipo.Nombre = tboxTipo.Text.Trim();
                    unProducto.Marca.Nombre = tboxMarca.Text.Trim();
                    unProducto.PrecioCosto = Convert.ToDecimal(tboxPrecioCosto.Text.Trim());
                    unProducto.PrecioVenta = Convert.ToDecimal(tboxPrecioVenta.Text.Trim());
                    unProducto.StockMinimo = Convert.ToInt32(tboxStockMinimo.Text.Trim());

                    unGestorProductos.modificarTipo(unProducto.Tipo);
                    unGestorProductos.modificarMarca(unProducto.Marca);
                    unGestorProductos.modificarProducto(unProducto);

                    MessageBox.Show("Informacion de producto actualizada");
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
