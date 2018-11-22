namespace TPC_VariscoGonzalo
{
    partial class frmUsuarios
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
            this.lblNuevoUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuariosActuales = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tboxNombreUsuario = new System.Windows.Forms.TextBox();
            this.tboxClave = new System.Windows.Forms.TextBox();
            this.cboxUsuarios = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cboxPerfil = new System.Windows.Forms.ComboBox();
            this.tboxConfirmacionClave = new System.Windows.Forms.TextBox();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNuevoUsuario
            // 
            this.lblNuevoUsuario.AutoSize = true;
            this.lblNuevoUsuario.Location = new System.Drawing.Point(12, 18);
            this.lblNuevoUsuario.Name = "lblNuevoUsuario";
            this.lblNuevoUsuario.Size = new System.Drawing.Size(108, 13);
            this.lblNuevoUsuario.TabIndex = 0;
            this.lblNuevoUsuario.Text = "Crear nuevo usuario?";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre usuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(12, 96);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Clave";
            // 
            // lblUsuariosActuales
            // 
            this.lblUsuariosActuales.AutoSize = true;
            this.lblUsuariosActuales.Location = new System.Drawing.Point(15, 215);
            this.lblUsuariosActuales.Name = "lblUsuariosActuales";
            this.lblUsuariosActuales.Size = new System.Drawing.Size(114, 13);
            this.lblUsuariosActuales.TabIndex = 3;
            this.lblUsuariosActuales.Text = "Usuarios almacenados";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(262, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(204, 252);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tboxNombreUsuario
            // 
            this.tboxNombreUsuario.Location = new System.Drawing.Point(112, 55);
            this.tboxNombreUsuario.Name = "tboxNombreUsuario";
            this.tboxNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.tboxNombreUsuario.TabIndex = 6;
            // 
            // tboxClave
            // 
            this.tboxClave.Location = new System.Drawing.Point(112, 96);
            this.tboxClave.Name = "tboxClave";
            this.tboxClave.PasswordChar = '*';
            this.tboxClave.Size = new System.Drawing.Size(100, 20);
            this.tboxClave.TabIndex = 7;
            // 
            // cboxUsuarios
            // 
            this.cboxUsuarios.FormattingEnabled = true;
            this.cboxUsuarios.Location = new System.Drawing.Point(18, 252);
            this.cboxUsuarios.Name = "cboxUsuarios";
            this.cboxUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cboxUsuarios.TabIndex = 8;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(15, 170);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(30, 13);
            this.lblPerfil.TabIndex = 9;
            this.lblPerfil.Text = "Perfil";
            // 
            // cboxPerfil
            // 
            this.cboxPerfil.FormattingEnabled = true;
            this.cboxPerfil.Location = new System.Drawing.Point(112, 162);
            this.cboxPerfil.Name = "cboxPerfil";
            this.cboxPerfil.Size = new System.Drawing.Size(121, 21);
            this.cboxPerfil.TabIndex = 10;
            // 
            // tboxConfirmacionClave
            // 
            this.tboxConfirmacionClave.Location = new System.Drawing.Point(112, 122);
            this.tboxConfirmacionClave.Name = "tboxConfirmacionClave";
            this.tboxConfirmacionClave.PasswordChar = '*';
            this.tboxConfirmacionClave.Size = new System.Drawing.Size(100, 20);
            this.tboxConfirmacionClave.TabIndex = 12;
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Location = new System.Drawing.Point(12, 122);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(80, 13);
            this.lblConfirmarClave.TabIndex = 11;
            this.lblConfirmarClave.Text = "Confirmar clave";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 324);
            this.Controls.Add(this.tboxConfirmacionClave);
            this.Controls.Add(this.lblConfirmarClave);
            this.Controls.Add(this.cboxPerfil);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.cboxUsuarios);
            this.Controls.Add(this.tboxClave);
            this.Controls.Add(this.tboxNombreUsuario);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblUsuariosActuales);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNuevoUsuario);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuariosActuales;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tboxNombreUsuario;
        private System.Windows.Forms.TextBox tboxClave;
        private System.Windows.Forms.ComboBox cboxUsuarios;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cboxPerfil;
        private System.Windows.Forms.TextBox tboxConfirmacionClave;
        private System.Windows.Forms.Label lblConfirmarClave;
    }
}