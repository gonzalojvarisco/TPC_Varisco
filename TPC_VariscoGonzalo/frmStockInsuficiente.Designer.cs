namespace TPC_VariscoGonzalo
{
    partial class frmStockInsuficiente
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
            this.dgvProdStockInsficiente = new System.Windows.Forms.DataGridView();
            this.lblProductosInsuf = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdStockInsficiente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdStockInsficiente
            // 
            this.dgvProdStockInsficiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdStockInsficiente.Location = new System.Drawing.Point(32, 68);
            this.dgvProdStockInsficiente.Name = "dgvProdStockInsficiente";
            this.dgvProdStockInsficiente.Size = new System.Drawing.Size(506, 296);
            this.dgvProdStockInsficiente.TabIndex = 0;
            // 
            // lblProductosInsuf
            // 
            this.lblProductosInsuf.AutoSize = true;
            this.lblProductosInsuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosInsuf.Location = new System.Drawing.Point(29, 18);
            this.lblProductosInsuf.Name = "lblProductosInsuf";
            this.lblProductosInsuf.Size = new System.Drawing.Size(369, 36);
            this.lblProductosInsuf.TabIndex = 1;
            this.lblProductosInsuf.Text = "No se cuenta con la cantidad suficiente de \r\nstock para realizar la venta de los " +
    "sigueintes productos";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(450, 370);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 53);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver a cargar\r\n la venta";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmStockInsuficiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 436);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblProductosInsuf);
            this.Controls.Add(this.dgvProdStockInsficiente);
            this.Name = "frmStockInsuficiente";
            this.Text = "frmStockInsuficiente";
            this.Load += new System.EventHandler(this.frmStockInsuficiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdStockInsficiente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdStockInsficiente;
        private System.Windows.Forms.Label lblProductosInsuf;
        private System.Windows.Forms.Button btnVolver;
    }
}