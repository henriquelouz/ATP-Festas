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
    public partial class frmRelatorioCliente : Form
    {
        public frmRelatorioCliente()
        {
            InitializeComponent();
        }

        private void frmRelatorioCliente_Load(object sender, EventArgs e)
        {
            string caminho = "Clientes.txt";
            if (File.Exists(caminho))
            {
                string[] linhas = File.ReadAllLines(caminho);

                for (int i = 0; i < linhas.Length; i++)
                {
                    string[] linhaAtual = linhas[i].Split('|');
                    linhas[i] = linhaAtual[0] + " - " + linhaAtual[1];
                }

                cmbRelatorioCliente.Items.AddRange(linhas);
                cmbRelatorioCliente.SelectedIndex = 0;
            }

            loadGridView();
        }

        private void loadGridView()
        {
            dtgRelatorioCliente.DataSource = null;
            dtgRelatorioCliente.Rows.Clear();
            dtgRelatorioCliente.Columns.Clear();

            dtgRelatorioCliente.Columns.Add("codigo", "Código");
            dtgRelatorioCliente.Columns.Add("qtdeConvidados", "Qtde. Convidados");
            dtgRelatorioCliente.Columns.Add("data", "Data");
            dtgRelatorioCliente.Columns.Add("diaSemana", "Dia da Semana");
            dtgRelatorioCliente.Columns.Add("inicio", "Horário");
            dtgRelatorioCliente.Columns.Add("termino", "Término");
            dtgRelatorioCliente.Columns.Add("tema", "Tema");

            string caminho = "Festas.txt";

            if (File.Exists(caminho))
            {
                string[] linhasResultado = File.ReadAllLines(caminho);

                for (int i = 0; i < linhasResultado.Length; i++)
                {
                    string[] linhaAtualResultado = linhasResultado[i].Split('|');
                    if (linhaAtualResultado[7] == cmbRelatorioCliente.Text.Split('-')[0])
                    {
                        linhaAtualResultado = linhaAtualResultado.Take(linhaAtualResultado.Count() - 1).ToArray();
                        dtgRelatorioCliente.Rows.Add(linhaAtualResultado);
                    }
                }
            }
        }

        private void cmbRelatorioCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadGridView();
        }
    }
}
