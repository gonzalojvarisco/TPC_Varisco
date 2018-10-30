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
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.tboxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxNombre_KeyPress);
            // 
            // tboxCuit
            // 
            this.tboxCuit.Location = new System.Drawing.Point(96, 91);
            this.tboxCuit.Name = "tboxCuit";
            this.tboxCuit.Size = new System.Drawing.Size(100, 20);
            this.tboxCuit.TabIndex = 3;
            this.tboxCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCuit_KeyPress);
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
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(146, 302);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(58, 24);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            this.ClientSize = new System.Drawing.Size(233, 346);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.btnVolver);
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
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Label lblProducto;
    }
}