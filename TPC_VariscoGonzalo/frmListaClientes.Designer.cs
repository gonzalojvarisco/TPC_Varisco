namespace TPC_VariscoGonzalo
{
    partial class frmListaClientes
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
            this.dgwClientes = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tboxDNI = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwClientes
            // 
            this.dgwClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClientes.Location = new System.Drawing.Point(21, 105);
            this.dgwClientes.Name = "dgwClientes";
            this.dgwClientes.Size = new System.Drawing.Size(563, 331);
            this.dgwClientes.TabIndex = 0;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(18, 21);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(90, 16);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtrar por DNI";
            // 
            // tboxDNI
            // 
            this.tboxDNI.Location = new System.Drawing.Point(21, 52);
            this.tboxDNI.Name = "tboxDNI";
            this.tboxDNI.Size = new System.Drawing.Size(116, 20);
            this.tboxDNI.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(495, 446);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 481);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tboxDNI);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgwClientes);
            this.Name = "frmListaClientes";
            this.Text = "frmListaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgwClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwClientes;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox tboxDNI;
        private System.Windows.Forms.Button btnVolver;
    }
}