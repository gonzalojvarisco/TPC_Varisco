namespace TPC_VariscoGonzalo
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnRegistroVenta = new System.Windows.Forms.Button();
            this.btnRegistroCompra = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnAdminUsuarios = new System.Windows.Forms.Button();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnCambiarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(25, 13);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(125, 24);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenidos";
            // 
            // btnRegistroVenta
            // 
            this.btnRegistroVenta.Location = new System.Drawing.Point(169, 113);
            this.btnRegistroVenta.Name = "btnRegistroVenta";
            this.btnRegistroVenta.Size = new System.Drawing.Size(122, 53);
            this.btnRegistroVenta.TabIndex = 1;
            this.btnRegistroVenta.Text = "Registro venta";
            this.btnRegistroVenta.UseVisualStyleBackColor = true;
            this.btnRegistroVenta.Click += new System.EventHandler(this.btnRegistroVenta_Click);
            // 
            // btnRegistroCompra
            // 
            this.btnRegistroCompra.Location = new System.Drawing.Point(359, 113);
            this.btnRegistroCompra.Name = "btnRegistroCompra";
            this.btnRegistroCompra.Size = new System.Drawing.Size(122, 53);
            this.btnRegistroCompra.TabIndex = 2;
            this.btnRegistroCompra.Text = "Registro compra";
            this.btnRegistroCompra.UseVisualStyleBackColor = true;
            this.btnRegistroCompra.Click += new System.EventHandler(this.btnRegistroCompra_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(169, 243);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(122, 53);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(359, 243);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(122, 53);
            this.btnProveedores.TabIndex = 4;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(513, 363);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(107, 33);
            this.btnProductos.TabIndex = 5;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnAdminUsuarios
            // 
            this.btnAdminUsuarios.Location = new System.Drawing.Point(12, 363);
            this.btnAdminUsuarios.Name = "btnAdminUsuarios";
            this.btnAdminUsuarios.Size = new System.Drawing.Size(122, 33);
            this.btnAdminUsuarios.TabIndex = 6;
            this.btnAdminUsuarios.Text = "Admin usuarios";
            this.btnAdminUsuarios.UseVisualStyleBackColor = true;
            this.btnAdminUsuarios.Click += new System.EventHandler(this.btnAdminUsuarios_Click);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(25, 46);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(139, 24);
            this.lblPerfil.TabIndex = 7;
            this.lblPerfil.Text = "Administrador";
            // 
            // btnCambiarUsuario
            // 
            this.btnCambiarUsuario.Location = new System.Drawing.Point(28, 73);
            this.btnCambiarUsuario.Name = "btnCambiarUsuario";
            this.btnCambiarUsuario.Size = new System.Drawing.Size(122, 22);
            this.btnCambiarUsuario.TabIndex = 8;
            this.btnCambiarUsuario.Text = "Cambiar usuario";
            this.btnCambiarUsuario.UseVisualStyleBackColor = true;
            this.btnCambiarUsuario.Click += new System.EventHandler(this.btnCambiarUsuario_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 408);
            this.Controls.Add(this.btnCambiarUsuario);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.btnAdminUsuarios);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnRegistroCompra);
            this.Controls.Add(this.btnRegistroVenta);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "frmInicio";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnRegistroVenta;
        private System.Windows.Forms.Button btnRegistroCompra;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnAdminUsuarios;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Button btnCambiarUsuario;
    }
}

