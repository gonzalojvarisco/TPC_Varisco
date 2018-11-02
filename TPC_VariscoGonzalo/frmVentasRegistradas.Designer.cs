namespace TPC_VariscoGonzalo
{
    partial class frmVentasRegistradas
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
            this.dgvVentasRegistradas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDetalleVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRegistradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentasRegistradas
            // 
            this.dgvVentasRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasRegistradas.Location = new System.Drawing.Point(34, 42);
            this.dgvVentasRegistradas.Name = "dgvVentasRegistradas";
            this.dgvVentasRegistradas.Size = new System.Drawing.Size(400, 302);
            this.dgvVentasRegistradas.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(380, 365);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDetalleVenta
            // 
            this.btnDetalleVenta.Location = new System.Drawing.Point(452, 42);
            this.btnDetalleVenta.Name = "btnDetalleVenta";
            this.btnDetalleVenta.Size = new System.Drawing.Size(75, 36);
            this.btnDetalleVenta.TabIndex = 4;
            this.btnDetalleVenta.Text = "Detalle venta";
            this.btnDetalleVenta.UseVisualStyleBackColor = true;
            this.btnDetalleVenta.Click += new System.EventHandler(this.btnDetalleVenta_Click);
            // 
            // frmVentasRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 395);
            this.Controls.Add(this.btnDetalleVenta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvVentasRegistradas);
            this.Name = "frmVentasRegistradas";
            this.Text = "frmVentasRegistradas";
            this.Load += new System.EventHandler(this.frmVentasRegistradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRegistradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVentasRegistradas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDetalleVenta;
    }
}