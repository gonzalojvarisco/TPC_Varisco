namespace TPC_VariscoGonzalo
{
    partial class frmProveedores
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
            this.btnAgregarProv = new System.Windows.Forms.Button();
            this.btnListaProveedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.Location = new System.Drawing.Point(77, 78);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(124, 45);
            this.btnAgregarProv.TabIndex = 0;
            this.btnAgregarProv.Text = "Agregar\r\nproveedores";
            this.btnAgregarProv.UseVisualStyleBackColor = true;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // btnListaProveedores
            // 
            this.btnListaProveedores.Location = new System.Drawing.Point(77, 174);
            this.btnListaProveedores.Name = "btnListaProveedores";
            this.btnListaProveedores.Size = new System.Drawing.Size(124, 45);
            this.btnListaProveedores.TabIndex = 1;
            this.btnListaProveedores.Text = "Lista\r\nproveedores";
            this.btnListaProveedores.UseVisualStyleBackColor = true;
            this.btnListaProveedores.Click += new System.EventHandler(this.btnListaProveedores_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.btnListaProveedores);
            this.Controls.Add(this.btnAgregarProv);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProv;
        private System.Windows.Forms.Button btnListaProveedores;
    }
}