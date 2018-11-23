namespace TPC_VariscoGonzalo
{
    partial class frmComprasRegistradas
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
            this.dgvComprasRegistradas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnDetalleCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasRegistradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComprasRegistradas
            // 
            this.dgvComprasRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasRegistradas.Location = new System.Drawing.Point(15, 36);
            this.dgvComprasRegistradas.Name = "dgvComprasRegistradas";
            this.dgvComprasRegistradas.Size = new System.Drawing.Size(474, 321);
            this.dgvComprasRegistradas.TabIndex = 4;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(403, 375);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 27);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnDetalleCompra
            // 
            this.btnDetalleCompra.Location = new System.Drawing.Point(495, 36);
            this.btnDetalleCompra.Name = "btnDetalleCompra";
            this.btnDetalleCompra.Size = new System.Drawing.Size(75, 36);
            this.btnDetalleCompra.TabIndex = 8;
            this.btnDetalleCompra.Text = "Detalle compra";
            this.btnDetalleCompra.UseVisualStyleBackColor = true;
            this.btnDetalleCompra.Click += new System.EventHandler(this.btnDetalleCompra_Click);
            // 
            // frmComprasRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 413);
            this.Controls.Add(this.btnDetalleCompra);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvComprasRegistradas);
            this.Name = "frmComprasRegistradas";
            this.Text = "frmComprasRegistradas";
            this.Load += new System.EventHandler(this.frmComprasRegistradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasRegistradas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvComprasRegistradas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnDetalleCompra;
    }
}