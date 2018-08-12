using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace festas
{
    public partial class frmAvisoStatus : Form
    {
        private int rowIndex;
        private string status;

        public frmAvisoStatus(int rowIndex)
        {
            InitializeComponent();

            this.rowIndex = rowIndex;
            
            string[] linhas = File.ReadAllLines("Contratos.txt");

            string codigo = linhas[rowIndex].Split('|')[0];
            Text = "Contrato #" + codigo;
            
        }

        private void salvar()
        {
            string caminho = "Contratos.txt";
            string[] linhas = File.ReadAllLines(caminho);


            string[] linhaAlterada = linhas[rowIndex].Split('|');
            linhaAlterada[5] = status;
            string novaLinha = String.Join("|", linhaAlterada);

            linhas[rowIndex] = novaLinha;

            List<string> novaLista = linhas.ToList();
            File.WriteAllLines(caminho, novaLista);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            status = "Pago";
            salvar();

            MessageBox.Show("Contrato pago com sucesso!", "", MessageBoxButtons.OK);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            status = "Cancelado";
            salvar();

            MessageBox.Show("Contrato cancelado com sucesso!", "", MessageBoxButtons.OK);
            Close();
        }
    }
}
