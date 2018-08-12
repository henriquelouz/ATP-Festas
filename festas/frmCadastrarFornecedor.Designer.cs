namespace festas
{
    partial class frmCadastrarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarFornecedor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFornecedorNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFornecedorTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFornecedorProdutoFornecido = new System.Windows.Forms.TextBox();
            this.btnFornecedorCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtFornecedorNome
            // 
            this.txtFornecedorNome.Location = new System.Drawing.Point(12, 25);
            this.txtFornecedorNome.Name = "txtFornecedorNome";
            this.txtFornecedorNome.Size = new System.Drawing.Size(244, 20);
            this.txtFornecedorNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // txtFornecedorTelefone
            // 
            this.txtFornecedorTelefone.Location = new System.Drawing.Point(12, 73);
            this.txtFornecedorTelefone.Mask = "(00) 000000009";
            this.txtFornecedorTelefone.Name = "txtFornecedorTelefone";
            this.txtFornecedorTelefone.Size = new System.Drawing.Size(244, 20);
            this.txtFornecedorTelefone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Produto Fornecido";
            // 
            // txtFornecedorProdutoFornecido
            // 
            this.txtFornecedorProdutoFornecido.Location = new System.Drawing.Point(12, 122);
            this.txtFornecedorProdutoFornecido.Name = "txtFornecedorProdutoFornecido";
            this.txtFornecedorProdutoFornecido.Size = new System.Drawing.Size(244, 20);
            this.txtFornecedorProdutoFornecido.TabIndex = 5;
            // 
            // btnFornecedorCadastrar
            // 
            this.btnFornecedorCadastrar.Location = new System.Drawing.Point(181, 148);
            this.btnFornecedorCadastrar.Name = "btnFornecedorCadastrar";
            this.btnFornecedorCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnFornecedorCadastrar.TabIndex = 6;
            this.btnFornecedorCadastrar.Text = "Cadastrar";
            this.btnFornecedorCadastrar.UseVisualStyleBackColor = true;
            this.btnFornecedorCadastrar.Click += new System.EventHandler(this.btnFornecedorCadastrar_Click);
            // 
            // frmCadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 188);
            this.Controls.Add(this.btnFornecedorCadastrar);
            this.Controls.Add(this.txtFornecedorProdutoFornecido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFornecedorTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFornecedorNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFornecedorNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFornecedorTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFornecedorProdutoFornecido;
        private System.Windows.Forms.Button btnFornecedorCadastrar;
    }
}