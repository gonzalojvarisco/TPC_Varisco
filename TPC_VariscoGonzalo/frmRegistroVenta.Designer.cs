namespace TPC_VariscoGonzalo
{
    partial class frmRegistroVenta
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
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnVentasRegistradas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(130, 57);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(125, 59);
            this.btnNuevaVenta.TabIndex = 0;
            this.btnNuevaVenta.Text = "Nueva venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnVentasRegistradas
            // 
            this.btnVentasRegistradas.Location = new System.Drawing.Point(130, 182);
            this.btnVentasRegistradas.Name = "btnVentasRegistradas";
            this.btnVentasRegistradas.Size = new System.Drawing.Size(125, 59);
            this.btnVentasRegistradas.TabIndex = 1;
            this.btnVentasRegistradas.Text = "Ventas registradas";
            this.btnVentasRegistradas.UseVisualStyleBackColor = true;
            this.btnVentasRegistradas.Click += new System.EventHandler(this.btnVentasRegistradas_Click);
            // 
            // frmRegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 313);
            this.Controls.Add(this.btnVentasRegistradas);
            this.Controls.Add(this.btnNuevaVenta);
            this.Name = "frmRegistroVenta";
            this.Text = "frmRegistroVenta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnVentasRegistradas;
    }
}