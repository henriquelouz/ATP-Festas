using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace festas
{
    public partial class frmCadastrarFornecedor : Form
    {
        public frmCadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void btnFornecedorCadastrar_Click(object sender, EventArgs e)
        {
            string caminho = "Fornecedores.txt";
            string novoRegistro = txtFornecedorNome.Text + "|" + txtFornecedorTelefone.Text + "|" + txtFornecedorProdutoFornecido.Text;

            Arquivo.Cadastrar(caminho, novoRegistro);

            MessageBox.Show("Fornecedor cadastrado com sucesso!", "", MessageBoxButtons.OK);

            txtFornecedorNome.Clear();
            txtFornecedorTelefone.Clear();
            txtFornecedorProdutoFornecido.Clear();
        }
    }
}
