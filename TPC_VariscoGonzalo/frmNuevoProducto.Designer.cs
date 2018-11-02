namespace TPC_VariscoGonzalo
{
    partial class frmNuevoProducto
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.tboxTipo = new System.Windows.Forms.TextBox();
            this.tboxMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tboxPrecioCosto = new System.Windows.Forms.TextBox();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.tboxPorcentajeGanancia = new System.Windows.Forms.TextBox();
            this.lblPorcentajeGanancia = new System.Windows.Forms.Label();
            this.lblProveedores = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.lblNuevoProducto = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.tboxStockMinimo = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.tboxStockActual = new System.Windows.Forms.TextBox();
            this.lblStockActual = new System.Windows.Forms.Label();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.cboxMarca = new System.Windows.Forms.ComboBox();
            this.lblIncluirTipo = new System.Windows.Forms.Label();
            this.lblIncluirMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(4, 333);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // tboxTipo
            // 
            this.tboxTipo.Location = new System.Drawing.Point(261, 328);
            this.tboxTipo.Name = "tboxTipo";
            this.tboxTipo.Size = new System.Drawing.Size(100, 20);
            this.tboxTipo.TabIndex = 1;
            // 
            // tboxMarca
            // 
            this.tboxMarca.Location = new System.Drawing.Point(261, 369);
            this.tboxMarca.Name = "tboxMarca";
            this.tboxMarca.Size = new System.Drawing.Size(100, 20);
            this.tboxMarca.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(4, 372);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.Location = new System.Drawing.Point(71, 412);
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.Size = new System.Drawing.Size(100, 20);
            this.tboxCodigo.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 416);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // tboxPrecioCosto
            // 
            this.tboxPrecioCosto.Location = new System.Drawing.Point(482, 328);
            this.tboxPrecioCosto.Name = "tboxPrecioCosto";
            this.tboxPrecioCosto.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecioCosto.TabIndex = 7;
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Location = new System.Drawing.Point(371, 331);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(66, 13);
            this.lblPrecioCosto.TabIndex = 6;
            this.lblPrecioCosto.Text = "Precio costo";
            // 
            // tboxPorcentajeGanancia
            // 
            this.tboxPorcentajeGanancia.Location = new System.Drawing.Point(482, 372);
            this.tboxPorcentajeGanancia.Name = "tboxPorcentajeGanancia";
            this.tboxPorcentajeGanancia.Size = new System.Drawing.Size(100, 20);
            this.tboxPorcentajeGanancia.TabIndex = 9;
            // 
            // lblPorcentajeGanancia
            // 
            this.lblPorcentajeGanancia.AutoSize = true;
            this.lblPorcentajeGanancia.Location = new System.Drawing.Point(371, 375);
            this.lblPorcentajeGanancia.Name = "lblPorcentajeGanancia";
            this.lblPorcentajeGanancia.Size = new System.Drawing.Size(105, 13);
            this.lblPorcentajeGanancia.TabIndex = 8;
            this.lblPorcentajeGanancia.Text = "Porcentaje ganancia";
            // 
            // lblProveedores
            // 
            this.lblProveedores.AutoSize = true;
            this.lblProveedores.Location = new System.Drawing.Point(30, 16);
            this.lblProveedores.Name = "lblProveedores";
            this.lblProveedores.Size = new System.Drawing.Size(67, 13);
            this.lblProveedores.TabIndex = 10;
            this.lblProveedores.Text = "Proveedores";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(311, 108);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 35);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "<";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(374, 48);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(302, 150);
            this.dgvProductos.TabIndex = 24;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(371, 16);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(55, 13);
            this.lblProducto.TabIndex = 27;
            this.lblProducto.Text = "Productos";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(30, 48);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(262, 150);
            this.dgvProveedores.TabIndex = 11;
            // 
            // lblNuevoProducto
            // 
            this.lblNuevoProducto.AutoSize = true;
            this.lblNuevoProducto.Location = new System.Drawing.Point(4, 284);
            this.lblNuevoProducto.Name = "lblNuevoProducto";
            this.lblNuevoProducto.Size = new System.Drawing.Size(96, 26);
            this.lblNuevoProducto.TabIndex = 28;
            this.lblNuevoProducto.Text = "¿Nuevo producto?\r\nAgregar";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(592, 419);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(84, 42);
            this.btnAgregarProducto.TabIndex = 29;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // tboxStockMinimo
            // 
            this.tboxStockMinimo.Location = new System.Drawing.Point(482, 441);
            this.tboxStockMinimo.Name = "tboxStockMinimo";
            this.tboxStockMinimo.Size = new System.Drawing.Size(100, 20);
            this.tboxStockMinimo.TabIndex = 33;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(371, 444);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(70, 13);
            this.lblStockMinimo.TabIndex = 32;
            this.lblStockMinimo.Text = "Stock minimo";
            // 
            // tboxStockActual
            // 
            this.tboxStockActual.Location = new System.Drawing.Point(482, 409);
            this.tboxStockActual.Name = "tboxStockActual";
            this.tboxStockActual.Size = new System.Drawing.Size(100, 20);
            this.tboxStockActual.TabIndex = 31;
            // 
            // lblStockActual
            // 
            this.lblStockActual.AutoSize = true;
            this.lblStockActual.Location = new System.Drawing.Point(371, 412);
            this.lblStockActual.Name = "lblStockActual";
            this.lblStockActual.Size = new System.Drawing.Size(67, 13);
            this.lblStockActual.TabIndex = 30;
            this.lblStockActual.Text = "Stock actual";
            // 
            // cboxTipo
            // 
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Location = new System.Drawing.Point(50, 330);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(121, 21);
            this.cboxTipo.TabIndex = 34;
            // 
            // cboxMarca
            // 
            this.cboxMarca.FormattingEnabled = true;
            this.cboxMarca.Location = new System.Drawing.Point(50, 369);
            this.cboxMarca.Name = "cboxMarca";
            this.cboxMarca.Size = new System.Drawing.Size(121, 21);
            this.cboxMarca.TabIndex = 35;
            // 
            // lblIncluirTipo
            // 
            this.lblIncluirTipo.AutoSize = true;
            this.lblIncluirTipo.Location = new System.Drawing.Point(177, 322);
            this.lblIncluirTipo.Name = "lblIncluirTipo";
            this.lblIncluirTipo.Size = new System.Drawing.Size(82, 26);
            this.lblIncluirTipo.TabIndex = 36;
            this.lblIncluirTipo.Text = "Si aun no existe\r\nIncluir tipo -->";
            // 
            // lblIncluirMarca
            // 
            this.lblIncluirMarca.AutoSize = true;
            this.lblIncluirMarca.Location = new System.Drawing.Point(177, 364);
            this.lblIncluirMarca.Name = "lblIncluirMarca";
            this.lblIncluirMarca.Size = new System.Drawing.Size(83, 26);
            this.lblIncluirMarca.TabIndex = 37;
            this.lblIncluirMarca.Text = "Si aun no existe\r\nIncluir Marca -->";
            // 
            // frmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 473);
            this.Controls.Add(this.lblIncluirMarca);
            this.Controls.Add(this.lblIncluirTipo);
            this.Controls.Add(this.cboxMarca);
            this.Controls.Add(this.cboxTipo);
            this.Controls.Add(this.tboxStockMinimo);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.tboxStockActual);
            this.Controls.Add(this.lblStockActual);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblNuevoProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.lblProveedores);
            this.Controls.Add(this.tboxPorcentajeGanancia);
            this.Controls.Add(this.lblPorcentajeGanancia);
            this.Controls.Add(this.tboxPrecioCosto);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.tboxCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.tboxMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tboxTipo);
            this.Controls.Add(this.lblTipo);
            this.Name = "frmNuevoProducto";
            this.Text = "frmNuevoProducto";
            this.Load += new System.EventHandler(this.frmNuevoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox tboxTipo;
        private System.Windows.Forms.TextBox tboxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox tboxPrecioCosto;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.TextBox tboxPorcentajeGanancia;
        private System.Windows.Forms.Label lblPorcentajeGanancia;
        private System.Windows.Forms.Label lblProveedores;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label lblNuevoProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox tboxStockMinimo;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox tboxStockActual;
        private System.Windows.Forms.Label lblStockActual;
        private System.Windows.Forms.ComboBox cboxTipo;
        private System.Windows.Forms.ComboBox cboxMarca;
        private System.Windows.Forms.Label lblIncluirTipo;
        private System.Windows.Forms.Label lblIncluirMarca;
    }
}