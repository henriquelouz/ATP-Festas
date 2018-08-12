namespace festas
{
    partial class frmCadastrarFesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarFesta));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFestaCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFestaData = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grbFestaHorario = new System.Windows.Forms.GroupBox();
            this.dtpFestaHoraDe = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFestaHoraAte = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFestaCadastrar = new System.Windows.Forms.Button();
            this.grbFestaHorarioSabado = new System.Windows.Forms.GroupBox();
            this.rdbFestaHorario18 = new System.Windows.Forms.RadioButton();
            this.rdbFestaHorario12 = new System.Windows.Forms.RadioButton();
            this.txtFestaTema = new System.Windows.Forms.TextBox();
            this.cmbFestaQtdeConvidados = new System.Windows.Forms.ComboBox();
            this.grbFestaHorario.SuspendLayout();
            this.grbFestaHorarioSabado.SuspendLayout();
            this.SuspendLayout();
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
            // cmbFestaCliente
            // 
            this.cmbFestaCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFestaCliente.FormattingEnabled = true;
            this.cmbFestaCliente.Location = new System.Drawing.Point(12, 25);
            this.cmbFestaCliente.Name = "cmbFestaCliente";
            this.cmbFestaCliente.Size = new System.Drawing.Size(247, 21);
            this.cmbFestaCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Qtde. convidados";
            // 
            // dtpFestaData
            // 
            this.dtpFestaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFestaData.Location = new System.Drawing.Point(12, 171);
            this.dtpFestaData.Name = "dtpFestaData";
            this.dtpFestaData.Size = new System.Drawing.Size(247, 20);
            this.dtpFestaData.TabIndex = 7;
            this.dtpFestaData.ValueChanged += new System.EventHandler(this.dtpFestaData_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data da festa";
            // 
            // grbFestaHorario
            // 
            this.grbFestaHorario.Controls.Add(this.dtpFestaHoraDe);
            this.grbFestaHorario.Controls.Add(this.label5);
            this.grbFestaHorario.Controls.Add(this.dtpFestaHoraAte);
            this.grbFestaHorario.Location = new System.Drawing.Point(12, 206);
            this.grbFestaHorario.Name = "grbFestaHorario";
            this.grbFestaHorario.Size = new System.Drawing.Size(247, 55);
            this.grbFestaHorario.TabIndex = 8;
            this.grbFestaHorario.TabStop = false;
            this.grbFestaHorario.Text = "Horário";
            this.grbFestaHorario.Visible = false;
            // 
            // dtpFestaHoraDe
            // 
            this.dtpFestaHoraDe.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFestaHoraDe.Location = new System.Drawing.Point(6, 19);
            this.dtpFestaHoraDe.Name = "dtpFestaHoraDe";
            this.dtpFestaHoraDe.ShowUpDown = true;
            this.dtpFestaHoraDe.Size = new System.Drawing.Size(103, 20);
            this.dtpFestaHoraDe.TabIndex = 7;
            this.dtpFestaHoraDe.Value = new System.DateTime(2018, 5, 21, 12, 0, 0, 0);
            this.dtpFestaHoraDe.ValueChanged += new System.EventHandler(this.dtpFestaHoraDe_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "às";
            // 
            // dtpFestaHoraAte
            // 
            this.dtpFestaHoraAte.Enabled = false;
            this.dtpFestaHoraAte.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFestaHoraAte.Location = new System.Drawing.Point(139, 19);
            this.dtpFestaHoraAte.Name = "dtpFestaHoraAte";
            this.dtpFestaHoraAte.ShowUpDown = true;
            this.dtpFestaHoraAte.Size = new System.Drawing.Size(102, 20);
            this.dtpFestaHoraAte.TabIndex = 8;
            this.dtpFestaHoraAte.Value = new System.DateTime(2018, 5, 21, 16, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tema";
            // 
            // btnFestaCadastrar
            // 
            this.btnFestaCadastrar.Location = new System.Drawing.Point(184, 267);
            this.btnFestaCadastrar.Name = "btnFestaCadastrar";
            this.btnFestaCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnFestaCadastrar.TabIndex = 9;
            this.btnFestaCadastrar.Text = "Cadastrar";
            this.btnFestaCadastrar.UseVisualStyleBackColor = true;
            this.btnFestaCadastrar.Click += new System.EventHandler(this.btnFestaCadastrar_Click);
            // 
            // grbFestaHorarioSabado
            // 
            this.grbFestaHorarioSabado.Controls.Add(this.rdbFestaHorario18);
            this.grbFestaHorarioSabado.Controls.Add(this.rdbFestaHorario12);
            this.grbFestaHorarioSabado.Location = new System.Drawing.Point(12, 206);
            this.grbFestaHorarioSabado.Name = "grbFestaHorarioSabado";
            this.grbFestaHorarioSabado.Size = new System.Drawing.Size(247, 55);
            this.grbFestaHorarioSabado.TabIndex = 8;
            this.grbFestaHorarioSabado.TabStop = false;
            this.grbFestaHorarioSabado.Text = "Reserva Sábado";
            this.grbFestaHorarioSabado.Visible = false;
            // 
            // rdbFestaHorario18
            // 
            this.rdbFestaHorario18.AutoSize = true;
            this.rdbFestaHorario18.Location = new System.Drawing.Point(156, 23);
            this.rdbFestaHorario18.Name = "rdbFestaHorario18";
            this.rdbFestaHorario18.Size = new System.Drawing.Size(66, 17);
            this.rdbFestaHorario18.TabIndex = 1;
            this.rdbFestaHorario18.Text = "18 às 22";
            this.rdbFestaHorario18.UseVisualStyleBackColor = true;
            // 
            // rdbFestaHorario12
            // 
            this.rdbFestaHorario12.AutoSize = true;
            this.rdbFestaHorario12.Checked = true;
            this.rdbFestaHorario12.Location = new System.Drawing.Point(6, 22);
            this.rdbFestaHorario12.Name = "rdbFestaHorario12";
            this.rdbFestaHorario12.Size = new System.Drawing.Size(66, 17);
            this.rdbFestaHorario12.TabIndex = 0;
            this.rdbFestaHorario12.TabStop = true;
            this.rdbFestaHorario12.Text = "12 às 16";
            this.rdbFestaHorario12.UseVisualStyleBackColor = true;
            // 
            // txtFestaTema
            // 
            this.txtFestaTema.Location = new System.Drawing.Point(12, 123);
            this.txtFestaTema.Name = "txtFestaTema";
            this.txtFestaTema.Size = new System.Drawing.Size(247, 20);
            this.txtFestaTema.TabIndex = 5;
            // 
            // cmbFestaQtdeConvidados
            // 
            this.cmbFestaQtdeConvidados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFestaQtdeConvidados.FormattingEnabled = true;
            this.cmbFestaQtdeConvidados.Items.AddRange(new object[] {
            "30",
            "50",
            "80",
            "100"});
            this.cmbFestaQtdeConvidados.Location = new System.Drawing.Point(12, 74);
            this.cmbFestaQtdeConvidados.Name = "cmbFestaQtdeConvidados";
            this.cmbFestaQtdeConvidados.Size = new System.Drawing.Size(247, 21);
            this.cmbFestaQtdeConvidados.TabIndex = 3;
            // 
            // frmCadastrarFesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 304);
            this.Controls.Add(this.cmbFestaQtdeConvidados);
            this.Controls.Add(this.btnFestaCadastrar);
            this.Controls.Add(this.txtFestaTema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFestaData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbFestaCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbFestaHorarioSabado);
            this.Controls.Add(this.grbFestaHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarFesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar festa";
            this.Load += new System.EventHandler(this.frmCadastrarFesta_Load);
            this.grbFestaHorario.ResumeLayout(false);
            this.grbFestaHorario.PerformLayout();
            this.grbFestaHorarioSabado.ResumeLayout(false);
            this.grbFestaHorarioSabado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFestaCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFestaData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbFestaHorario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFestaCadastrar;
        private System.Windows.Forms.GroupBox grbFestaHorarioSabado;
        private System.Windows.Forms.RadioButton rdbFestaHorario18;
        private System.Windows.Forms.RadioButton rdbFestaHorario12;
        private System.Windows.Forms.DateTimePicker dtpFestaHoraDe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFestaHoraAte;
        private System.Windows.Forms.TextBox txtFestaTema;
        private System.Windows.Forms.ComboBox cmbFestaQtdeConvidados;
    }
}