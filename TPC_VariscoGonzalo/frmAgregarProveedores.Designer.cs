namespace TPC_VariscoGonzalo
{
    partial class frmAgregarProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.tboxLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.tboxCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.tboxProvincia = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tboxPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.tboxPrecioCosto = new System.Windows.Forms.TextBox();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tboxMarcaNueva = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tboxTipoNuevo = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(25, 52);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProveedor.TabIndex = 0;
            this.lblNombreProveedor.Text = "Nombre";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(96, 52);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 1;
            // 
            // tboxCuit
            // 
            this.tboxCuit.Location = new System.Drawing.Point(96, 91);
            this.tboxCuit.Name = "tboxCuit";
            this.tboxCuit.Size = new System.Drawing.Size(100, 20);
            this.tboxCuit.TabIndex = 3;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(25, 91);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 2;
            this.lblCuit.Text = "CUIT";
            // 
            // tboxLocalidad
            // 
            this.tboxLocalidad.Location = new System.Drawing.Point(96, 172);
            this.tboxLocalidad.Name = "tboxLocalidad";
            this.tboxLocalidad.Size = new System.Drawing.Size(100, 20);
            this.tboxLocalidad.TabIndex = 7;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(25, 172);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 6;
            this.lblLocalidad.Text = "Localidad";
            // 
            // tboxCalle
            // 
            this.tboxCalle.Location = new System.Drawing.Point(96, 133);
            this.tboxCalle.Name = "tboxCalle";
            this.tboxCalle.Size = new System.Drawing.Size(100, 20);
            this.tboxCalle.TabIndex = 5;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(25, 133);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 4;
            this.lblCalle.Text = "Calle";
            // 
            // tboxProvincia
            // 
            this.tboxProvincia.Location = new System.Drawing.Point(96, 212);
            this.tboxProvincia.Name = "tboxProvincia";
            this.tboxProvincia.Size = new System.Drawing.Size(100, 20);
            this.tboxProvincia.TabIndex = 9;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(25, 212);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 8;
            this.lblProvincia.Text = "Provincia";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(483, 290);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 36);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(579, 302);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(58, 24);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tboxPrecioVenta
            // 
            this.tboxPrecioVenta.Location = new System.Drawing.Point(372, 215);
            this.tboxPrecioVenta.Name = "tboxPrecioVenta";
            this.tboxPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecioVenta.TabIndex = 29;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(267, 218);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(67, 13);
            this.lblPrecioVenta.TabIndex = 28;
            this.lblPrecioVenta.Text = "Precio venta";
            // 
            // tboxPrecioCosto
            // 
            this.tboxPrecioCosto.Location = new System.Drawing.Point(372, 171);
            this.tboxPrecioCosto.Name = "tboxPrecioCosto";
            this.tboxPrecioCosto.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecioCosto.TabIndex = 27;
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Location = new System.Drawing.Point(267, 174);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(66, 13);
            this.lblPrecioCosto.TabIndex = 26;
            this.lblPrecioCosto.Text = "Precio costo";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Location = new System.Drawing.Point(372, 128);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(100, 20);
            this.tboxCodigo.TabIndex = 25;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(267, 131);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "Codigo";
            // 
            // tboxMarcaNueva
            // 
            this.tboxMarcaNueva.Location = new System.Drawing.Point(537, 80);
            this.tboxMarcaNueva.Name = "tboxMarcaNueva";
            this.tboxMarcaNueva.Size = new System.Drawing.Size(100, 20);
            this.tboxMarcaNueva.TabIndex = 23;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(267, 87);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 22;
            this.lblMarca.Text = "Marca";
            // 
            // tboxTipoNuevo
            // 
            this.tboxTipoNuevo.Location = new System.Drawing.Point(537, 45);
            this.tboxTipoNuevo.Name = "tboxTipoNuevo";
            this.tboxTipoNuevo.Size = new System.Drawing.Size(100, 20);
            this.tboxTipoNuevo.TabIndex = 21;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(267, 48);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 20;
            this.lblTipo.Text = "Tipo";
            // 
            // cboxTipo
            // 
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Location = new System.Drawing.Point(372, 44);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(100, 21);
            this.cboxTipo.TabIndex = 30;
            // 
            // cboxMarca
            // 
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(372, 87);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(100, 21);
            this.cboxMarca.TabIndex = 31;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.Location = new System.Drawing.Point(146, 252);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(50, 27);
            this.btnAgregarProductos.TabIndex = 32;
            this.btnAgregarProductos.Text = "+";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(25, 260);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(94, 13);
            this.lblProducto.TabIndex = 33;
            this.lblProducto.Text = "Agregar productos";
            // 
            // frmAgregarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 338);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.cboxTipo);
            this.Controls.Add(this.tboxPrecioVenta);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.tboxPrecioCosto);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.tboxCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.tboxMarcaNueva);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tboxTipoNuevo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tboxProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.tboxLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.tboxCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.tboxCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.lblNombreProveedor);
            this.Name = "frmAgregarProveedores";
            this.Text = "frmAgregarProveedores";
            this.Load += new System.EventHandler(this.frmAgregarProveedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox tboxLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox tboxCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox tboxProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox tboxPrecioVenta;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox tboxPrecioCosto;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tboxMarcaNueva;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox tboxTipoNuevo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Label lblProducto;
    }
}