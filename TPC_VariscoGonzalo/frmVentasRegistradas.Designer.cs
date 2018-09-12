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
            this.lblMes = new System.Windows.Forms.Label();
            this.dgvVentasRegistradas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cboxMesVenta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRegistradas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(31, 28);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(39, 20);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mes";
            // 
            // dgvVentasRegistradas
            // 
            this.dgvVentasRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasRegistradas.Location = new System.Drawing.Point(34, 99);
            this.dgvVentasRegistradas.Name = "dgvVentasRegistradas";
            this.dgvVentasRegistradas.Size = new System.Drawing.Size(362, 245);
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
            // 
            // cboxMesVenta
            // 
            this.cboxMesVenta.FormattingEnabled = true;
            this.cboxMesVenta.Location = new System.Drawing.Point(35, 62);
            this.cboxMesVenta.Name = "cboxMesVenta";
            this.cboxMesVenta.Size = new System.Drawing.Size(121, 21);
            this.cboxMesVenta.TabIndex = 4;
            // 
            // frmVentasRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 395);
            this.Controls.Add(this.cboxMesVenta);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvVentasRegistradas);
            this.Controls.Add(this.lblMes);
            this.Name = "frmVentasRegistradas";
            this.Text = "frmVentasRegistradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasRegistradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.DataGridView dgvVentasRegistradas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cboxMesVenta;
    }
}