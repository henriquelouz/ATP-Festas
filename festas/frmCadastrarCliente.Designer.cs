namespace festas
{
    partial class frmCadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarCliente));
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClienteEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtClienteNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClienteCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClienteNome
            // 
            this.txtClienteNome.Location = new System.Drawing.Point(12, 25);
            this.txtClienteNome.Name = "txtClienteNome";
            this.txtClienteNome.Size = new System.Drawing.Size(241, 20);
            this.txtClienteNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // txtClienteEndereco
            // 
            this.txtClienteEndereco.Location = new System.Drawing.Point(12, 73);
            this.txtClienteEndereco.Name = "txtClienteEndereco";
            this.txtClienteEndereco.Size = new System.Drawing.Size(241, 20);
            this.txtClienteEndereco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // txtClienteTelefone
            // 
            this.txtClienteTelefone.Location = new System.Drawing.Point(12, 121);
            this.txtClienteTelefone.Mask = "(00) 000000009";
            this.txtClienteTelefone.Name = "txtClienteTelefone";
            this.txtClienteTelefone.Size = new System.Drawing.Size(241, 20);
            this.txtClienteTelefone.TabIndex = 5;
            // 
            // txtClienteNascimento
            // 
            this.txtClienteNascimento.Location = new System.Drawing.Point(12, 169);
            this.txtClienteNascimento.Mask = "00/00/0000";
            this.txtClienteNascimento.Name = "txtClienteNascimento";
            this.txtClienteNascimento.Size = new System.Drawing.Size(241, 20);
            this.txtClienteNascimento.TabIndex = 6;
            this.txtClienteNascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtClienteNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de nascimento";
            // 
            // btnClienteCadastrar
            // 
            this.btnClienteCadastrar.Location = new System.Drawing.Point(178, 204);
            this.btnClienteCadastrar.Name = "btnClienteCadastrar";
            this.btnClienteCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnClienteCadastrar.TabIndex = 8;
            this.btnClienteCadastrar.Text = "Cadastrar";
            this.btnClienteCadastrar.UseVisualStyleBackColor = true;
            this.btnClienteCadastrar.Click += new System.EventHandler(this.btnClienteCadastrar_Click);
            // 
            // frmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 239);
            this.Controls.Add(this.btnClienteCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClienteNascimento);
            this.Controls.Add(this.txtClienteTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClienteEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClienteNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClienteEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtClienteTelefone;
        private System.Windows.Forms.MaskedTextBox txtClienteNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClienteCadastrar;
    }
}