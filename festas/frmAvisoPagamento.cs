using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace festas
{
    public partial class frmAvisoPagamento : Form
    {
        public bool concluido = false;
        private double valorTotal;
        private double desconto;
        private double valorFinal;
        private string formaPagamento;

        public frmAvisoPagamento(double valorTotal)
        {
            InitializeComponent();
            cmbFormaPagamento.SelectedIndex = 0;
            this.valorTotal = valorTotal;
            double valorInicial = valorTotal - ((valorTotal * 10)/100);
            lblValorTotal.Text = String.Format("R$ {0:0.00}", valorInicial);
        }

        private void btnTotalConcluir_Click(object sender, EventArgs e)
        {
            string[] linhas = File.ReadAllLines("Festas.txt");
            string[] ultimoRegistro = linhas[linhas.Length - 1].Split('|');
            int ultimoCodigoInserido = int.Parse(ultimoRegistro[0]);
            string novoCodigo = (ultimoCodigoInserido + 1).ToString();

            string caminho = "Contratos.txt";
            string novoRegistro = valorTotal + "|" + valorFinal + "|" + desconto + "|" + formaPagamento + "|A pagar|" + novoCodigo;

            Arquivo.Cadastrar(caminho, novoRegistro);

            concluido = true;
            this.Close();
        }

        private void btnTotalCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFormaPagamento.SelectedIndex == 0){
                desconto = 10;
                formaPagamento = "À vista";
            }
            else if (cmbFormaPagamento.SelectedIndex == 1){
                desconto = 5;
                formaPagamento = "2x";
            }
            else if (cmbFormaPagamento.SelectedIndex == 2){
                desconto = 2;
                formaPagamento = "3x";
            }
            else{
                desconto = 0;
                formaPagamento = "4+";
            }
            valorFinal = valorTotal - ((valorTotal * desconto) / 100);
            lblValorTotal.Text = String.Format("R$ {0:0.00}", valorFinal);
        }
    }
}
