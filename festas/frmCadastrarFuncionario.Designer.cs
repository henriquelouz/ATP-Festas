namespace festas
{
    partial class frmCadastrarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncionarioNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuncionarioTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFuncionarioFuncao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFuncionarioTemporario = new System.Windows.Forms.RadioButton();
            this.rdbFuncionarioFixo = new System.Windows.Forms.RadioButton();
            this.btnFuncionarioCadastrar = new System.Windows.Forms.Button();
            this.txtFuncionarioSalario = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
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
            // txtFuncionarioNome
            // 
            this.txtFuncionarioNome.Location = new System.Drawing.Point(12, 25);
            this.txtFuncionarioNome.Name = "txtFuncionarioNome";
            this.txtFuncionarioNome.Size = new System.Drawing.Size(243, 20);
            this.txtFuncionarioNome.TabIndex = 1;
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
            // txtFuncionarioTelefone
            // 
            this.txtFuncionarioTelefone.Location = new System.Drawing.Point(12, 73);
            this.txtFuncionarioTelefone.Mask = "(00) 000000009";
            this.txtFuncionarioTelefone.Name = "txtFuncionarioTelefone";
            this.txtFuncionarioTelefone.Size = new System.Drawing.Size(243, 20);
            this.txtFuncionarioTelefone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Função";
            // 
            // txtFuncionarioFuncao
            // 
            this.txtFuncionarioFuncao.Location = new System.Drawing.Point(12, 122);
            this.txtFuncionarioFuncao.Name = "txtFuncionarioFuncao";
            this.txtFuncionarioFuncao.Size = new System.Drawing.Size(243, 20);
            this.txtFuncionarioFuncao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFuncionarioTemporario);
            this.groupBox1.Controls.Add(this.rdbFuncionarioFixo);
            this.groupBox1.Location = new System.Drawing.Point(15, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rdbFuncionarioTemporario
            // 
            this.rdbFuncionarioTemporario.AutoSize = true;
            this.rdbFuncionarioTemporario.Location = new System.Drawing.Point(149, 19);
            this.rdbFuncionarioTemporario.Name = "rdbFuncionarioTemporario";
            this.rdbFuncionarioTemporario.Size = new System.Drawing.Size(78, 17);
            this.rdbFuncionarioTemporario.TabIndex = 1;
            this.rdbFuncionarioTemporario.Text = "Temporário";
            this.rdbFuncionarioTemporario.UseVisualStyleBackColor = true;
            // 
            // rdbFuncionarioFixo
            // 
            this.rdbFuncionarioFixo.AutoSize = true;
            this.rdbFuncionarioFixo.Checked = true;
            this.rdbFuncionarioFixo.Location = new System.Drawing.Point(6, 19);
            this.rdbFuncionarioFixo.Name = "rdbFuncionarioFixo";
            this.rdbFuncionarioFixo.Size = new System.Drawing.Size(44, 17);
            this.rdbFuncionarioFixo.TabIndex = 0;
            this.rdbFuncionarioFixo.TabStop = true;
            this.rdbFuncionarioFixo.Text = "Fixo";
            this.rdbFuncionarioFixo.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarioCadastrar
            // 
            this.btnFuncionarioCadastrar.Location = new System.Drawing.Point(180, 250);
            this.btnFuncionarioCadastrar.Name = "btnFuncionarioCadastrar";
            this.btnFuncionarioCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnFuncionarioCadastrar.TabIndex = 9;
            this.btnFuncionarioCadastrar.Text = "Cadastrar";
            this.btnFuncionarioCadastrar.UseVisualStyleBackColor = true;
            this.btnFuncionarioCadastrar.Click += new System.EventHandler(this.btnFuncionarioCadastrar_Click);
            // 
            // txtFuncionarioSalario
            // 
            this.txtFuncionarioSalario.Location = new System.Drawing.Point(12, 170);
            this.txtFuncionarioSalario.Mask = "0000000";
            this.txtFuncionarioSalario.Name = "txtFuncionarioSalario";
            this.txtFuncionarioSalario.Size = new System.Drawing.Size(243, 20);
            this.txtFuncionarioSalario.TabIndex = 7;
            this.txtFuncionarioSalario.ValidatingType = typeof(int);
            this.txtFuncionarioSalario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtFuncionarioSalario_MaskInputRejected);
            // 
            // frmCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 286);
            this.Controls.Add(this.txtFuncionarioSalario);
            this.Controls.Add(this.btnFuncionarioCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFuncionarioFuncao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFuncionarioTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFuncionarioNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar funcionário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncionarioNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFuncionarioTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFuncionarioFuncao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFuncionarioTemporario;
        private System.Windows.Forms.RadioButton rdbFuncionarioFixo;
        private System.Windows.Forms.Button btnFuncionarioCadastrar;
        private System.Windows.Forms.MaskedTextBox txtFuncionarioSalario;
    }
}