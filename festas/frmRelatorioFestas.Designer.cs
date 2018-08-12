namespace festas
{
    partial class frmRelatorioFestas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorioFestas));
            this.dtgRelatorioFesta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRelatorioFesta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorioFesta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRelatorioFesta
            // 
            this.dtgRelatorioFesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRelatorioFesta.Location = new System.Drawing.Point(12, 51);
            this.dtgRelatorioFesta.Name = "dtgRelatorioFesta";
            this.dtgRelatorioFesta.ReadOnly = true;
            this.dtgRelatorioFesta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRelatorioFesta.Size = new System.Drawing.Size(743, 286);
            this.dtgRelatorioFesta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // dtpRelatorioFesta
            // 
            this.dtpRelatorioFesta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRelatorioFesta.Location = new System.Drawing.Point(15, 25);
            this.dtpRelatorioFesta.Name = "dtpRelatorioFesta";
            this.dtpRelatorioFesta.Size = new System.Drawing.Size(91, 20);
            this.dtpRelatorioFesta.TabIndex = 2;
            this.dtpRelatorioFesta.ValueChanged += new System.EventHandler(this.dtpRelatorioFesta_ValueChanged);
            // 
            // frmRelatorioFestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 349);
            this.Controls.Add(this.dtpRelatorioFesta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgRelatorioFesta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioFestas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório festas";
            this.Load += new System.EventHandler(this.frmRelatorioFestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRelatorioFesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRelatorioFesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRelatorioFesta;
    }
}