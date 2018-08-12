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
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnClienteCadastrar_Click(object sender, EventArgs e)
        {
            string caminho = "Clientes.txt";
            string novoRegistro = txtClienteNome.Text + "|" + txtClienteEndereco.Text + "|" + txtClienteTelefone.Text + "|" + txtClienteNascimento.Text;

            Arquivo.Cadastrar(caminho, novoRegistro);

            MessageBox.Show("Cliente cadastrado com sucesso!", "", MessageBoxButtons.OK);

            txtClienteNome.Clear();
            txtClienteEndereco.Clear();
            txtClienteTelefone.Clear();
            txtClienteNascimento.Clear();

        }
    }
}
