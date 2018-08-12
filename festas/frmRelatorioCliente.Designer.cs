namespace festas
{
    partial class frmRelatorioCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioCliente));
            this.dtgRelatorioCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRelatorioCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorioCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRelatorioCliente
            // 
            this.dtgRelatorioCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRelatorioCliente.Location = new System.Drawing.Point(12, 58);
            this.dtgRelatorioCliente.Name = "dtgRelatorioCliente";
            this.dtgRelatorioCliente.ReadOnly = true;
            this.dtgRelatorioCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRelatorioCliente.Size = new System.Drawing.Size(744, 275);
            this.dtgRelatorioCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // cmbRelatorioCliente
            // 
            this.cmbRelatorioCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelatorioCliente.FormattingEnabled = true;
            this.cmbRelatorioCliente.Location = new System.Drawing.Point(12, 25);
            this.cmbRelatorioCliente.Name = "cmbRelatorioCliente";
            this.cmbRelatorioCliente.Size = new System.Drawing.Size(275, 21);
            this.cmbRelatorioCliente.TabIndex = 1;
            this.cmbRelatorioCliente.SelectedIndexChanged += new System.EventHandler(this.cmbRelatorioCliente_SelectedIndexChanged);
            // 
            // frmRelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 345);
            this.Controls.Add(this.cmbRelatorioCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgRelatorioCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório cliente";
            this.Load += new System.EventHandler(this.frmRelatorioCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorioCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRelatorioCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRelatorioCliente;
    }
}