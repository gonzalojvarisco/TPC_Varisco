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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dgvComprasRegistradas = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ckBoxMes = new System.Windows.Forms.CheckBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasRegistradas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // dgvComprasRegistradas
            // 
            this.dgvComprasRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasRegistradas.Location = new System.Drawing.Point(15, 91);
            this.dgvComprasRegistradas.Name = "dgvComprasRegistradas";
            this.dgvComprasRegistradas.Size = new System.Drawing.Size(474, 266);
            this.dgvComprasRegistradas.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // ckBoxMes
            // 
            this.ckBoxMes.AutoSize = true;
            this.ckBoxMes.Location = new System.Drawing.Point(244, 39);
            this.ckBoxMes.Name = "ckBoxMes";
            this.ckBoxMes.Size = new System.Drawing.Size(90, 17);
            this.ckBoxMes.TabIndex = 6;
            this.ckBoxMes.Text = "Todo el mes?";
            this.ckBoxMes.UseVisualStyleBackColor = true;
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
            // frmComprasRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 413);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.ckBoxMes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvComprasRegistradas);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmComprasRegistradas";
            this.Text = "frmComprasRegistradas";
            this.Load += new System.EventHandler(this.frmComprasRegistradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasRegistradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dgvComprasRegistradas;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox ckBoxMes;
        private System.Windows.Forms.Button btnVolver;
    }
}