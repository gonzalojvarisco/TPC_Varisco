namespace TPC_VariscoGonzalo
{
    partial class frmEditarProductos
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tboxMarca = new System.Windows.Forms.TextBox();
            this.tboxPrecioVenta = new System.Windows.Forms.TextBox();
            this.tboxPrecioCosto = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.tboxStockMinimo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 44);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo";
            // 
            // tboxTipo
            // 
            this.tboxTipo.Location = new System.Drawing.Point(83, 37);
            this.tboxTipo.Name = "tboxTipo";
            this.tboxTipo.Size = new System.Drawing.Size(100, 20);
            this.tboxTipo.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(99, 236);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 30);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tboxMarca
            // 
            this.tboxMarca.Location = new System.Drawing.Point(83, 75);
            this.tboxMarca.Name = "tboxMarca";
            this.tboxMarca.Size = new System.Drawing.Size(100, 20);
            this.tboxMarca.TabIndex = 3;
            // 
            // tboxPrecioVenta
            // 
            this.tboxPrecioVenta.Location = new System.Drawing.Point(83, 158);
            this.tboxPrecioVenta.Name = "tboxPrecioVenta";
            this.tboxPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecioVenta.TabIndex = 5;
            // 
            // tboxPrecioCosto
            // 
            this.tboxPrecioCosto.Location = new System.Drawing.Point(83, 116);
            this.tboxPrecioCosto.Name = "tboxPrecioCosto";
            this.tboxPrecioCosto.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecioCosto.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(12, 82);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Location = new System.Drawing.Point(12, 161);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(67, 13);
            this.lblPrecioVenta.TabIndex = 8;
            this.lblPrecioVenta.Text = "Precio venta";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Location = new System.Drawing.Point(12, 123);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(67, 13);
            this.lblPrecioCosto.TabIndex = 7;
            this.lblPrecioCosto.Text = "Precio Costo";
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(12, 200);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(70, 13);
            this.lblStockMinimo.TabIndex = 11;
            this.lblStockMinimo.Text = "Stock minimo";
            // 
            // tboxStockMinimo
            // 
            this.tboxStockMinimo.Location = new System.Drawing.Point(83, 197);
            this.tboxStockMinimo.Name = "tboxStockMinimo";
            this.tboxStockMinimo.Size = new System.Drawing.Size(100, 20);
            this.tboxStockMinimo.TabIndex = 10;
            // 
            // frmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 306);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.tboxStockMinimo);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.lblPrecioCosto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tboxPrecioVenta);
            this.Controls.Add(this.tboxPrecioCosto);
            this.Controls.Add(this.tboxMarca);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tboxTipo);
            this.Controls.Add(this.lblTipo);
            this.Name = "frmEditarProductos";
            this.Text = "frmEditarProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox tboxTipo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox tboxMarca;
        private System.Windows.Forms.TextBox tboxPrecioVenta;
        private System.Windows.Forms.TextBox tboxPrecioCosto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.TextBox tboxStockMinimo;
    }
}