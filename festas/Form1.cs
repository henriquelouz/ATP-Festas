using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace festas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFuncionario cadFun = new frmCadastrarFuncionario();
            cadFun.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCliente cadCli = new frmCadastrarCliente();
            cadCli.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarFornecedor cadFor = new frmCadastrarFornecedor();
            cadFor.ShowDialog();
        }

        private void festaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (File.Exists("Clientes.txt"))
            {
                frmCadastrarFesta cadFes = new frmCadastrarFesta();
                cadFes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cadastre um cliente primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dtgPesquisa.DataSource = null;
            dtgPesquisa.Rows.Clear();
            dtgPesquisa.Columns.Clear();

            string caminho;
            List<string> cabecalhos = new List<string>();

            if (rdbClientes.Checked){
                caminho = "Clientes.txt";

                cabecalhos.Add("Código");
                cabecalhos.Add("Nome");
                cabecalhos.Add("Endereço");
                cabecalhos.Add("Telefone");
                cabecalhos.Add("Data de Nascimento");

            } else if (rdbFornecedores.Checked){
                caminho = "Fornecedores.txt";

                cabecalhos.Add("Código");
                cabecalhos.Add("Nome");
                cabecalhos.Add("Telefone");
                cabecalhos.Add("Produto");                

            } else{
                caminho = "Funcionarios.txt";

                cabecalhos.Add("Código");
                cabecalhos.Add("Nome");
                cabecalhos.Add("Telefone");
                cabecalhos.Add("Função");
                cabecalhos.Add("Salário");
                cabecalhos.Add("Tipo");


            }

            if (File.Exists(caminho)){
                string[] linhas = File.ReadAllLines(caminho);
                List<string[]> resultados = new List<string[]>();

                for (int i = 0; i < linhas.Length; i++)
                {
                    string[] linhaAtual = linhas[i].Split('|');
                    if(linhaAtual[1].ToUpper().Contains(txtPesquisar.Text.ToUpper())) {
                        resultados.Add(linhaAtual);
                    }
                }

                foreach (string cabecalho in cabecalhos)
                {
                    dtgPesquisa.Columns.Add(cabecalho, cabecalho);
                }

                foreach (string[] resultado in resultados)
                {
                    dtgPesquisa.Rows.Add(resultado);
                }
            }
        }

        private void concluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContratos frmCon = new frmContratos();
            frmCon.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (File.Exists("Clientes.txt"))
            {
                frmRelatorioCliente relCli = new frmRelatorioCliente();
                relCli.ShowDialog();
            } else {
                MessageBox.Show("Cadastre um cliente primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void festaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioFestas relFes = new frmRelatorioFestas();
            relFes.ShowDialog();
        }
    }
}
