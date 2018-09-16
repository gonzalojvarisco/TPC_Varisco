namespace TPC_VariscoGonzalo
{
    partial class frmClientes
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
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Location = new System.Drawing.Point(120, 183);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(119, 55);
            this.btnListaClientes.TabIndex = 3;
            this.btnListaClientes.Text = "Lista clientes";
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(120, 74);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(119, 55);
            this.btnAgregarCliente.TabIndex = 2;
            this.btnAgregarCliente.Text = "Agregar cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 333);
            this.Controls.Add(this.btnListaClientes);
            this.Controls.Add(this.btnAgregarCliente);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.Button btnAgregarCliente;
    }
}