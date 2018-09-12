namespace TPC_VariscoGonzalo
{
    partial class frmRegistroCompra
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
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnComprasRegistradas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.Location = new System.Drawing.Point(132, 68);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(119, 55);
            this.btnNuevaCompra.TabIndex = 0;
            this.btnNuevaCompra.Text = "Nueva compra";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // btnComprasRegistradas
            // 
            this.btnComprasRegistradas.Location = new System.Drawing.Point(132, 177);
            this.btnComprasRegistradas.Name = "btnComprasRegistradas";
            this.btnComprasRegistradas.Size = new System.Drawing.Size(119, 55);
            this.btnComprasRegistradas.TabIndex = 1;
            this.btnComprasRegistradas.Text = "Compras registradas";
            this.btnComprasRegistradas.UseVisualStyleBackColor = true;
            this.btnComprasRegistradas.Click += new System.EventHandler(this.btnComprasRegistradas_Click);
            // 
            // frmRegistroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 339);
            this.Controls.Add(this.btnComprasRegistradas);
            this.Controls.Add(this.btnNuevaCompra);
            this.Name = "frmRegistroCompra";
            this.Text = "frmRegistroCompra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnComprasRegistradas;
    }
}