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
    public partial class frmCadastrarFuncionario : Form
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnFuncionarioCadastrar_Click(object sender, EventArgs e)
        {
            string caminho = "Funcionarios.txt";
            string tipo;

            if (rdbFuncionarioFixo.Checked) {
                tipo = "Fixo";
            }
            else {
                tipo = "Temporário";
            }

            string novoRegistro = txtFuncionarioNome.Text + "|" + txtFuncionarioTelefone.Text + "|" + txtFuncionarioFuncao.Text + "|" + txtFuncionarioSalario.Text + "|" + tipo;

            Arquivo.Cadastrar(caminho, novoRegistro);

            MessageBox.Show("Funcionário cadastrado com sucesso!", "", MessageBoxButtons.OK);

            txtFuncionarioNome.Clear();
            txtFuncionarioTelefone.Clear();
            txtFuncionarioFuncao.Clear();
            txtFuncionarioSalario.Clear();
            rdbFuncionarioFixo.PerformClick();
        }

        private void txtFuncionarioSalario_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
