using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace festas
{
    public partial class frmRelatorioFestas : Form
    {
        public frmRelatorioFestas()
        {
            InitializeComponent();
        }

        private void frmRelatorioFestas_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void dtpRelatorioFesta_ValueChanged(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void loadGridView()
        {
            dtgRelatorioFesta.DataSource = null;
            dtgRelatorioFesta.Rows.Clear();
            dtgRelatorioFesta.Columns.Clear();

            dtgRelatorioFesta.Columns.Add("codigo", "Código");
            dtgRelatorioFesta.Columns.Add("qtdeConvidados", "Qtde. Convidados");
            dtgRelatorioFesta.Columns.Add("data", "Data");
            dtgRelatorioFesta.Columns.Add("diaSemana", "Dia da Semana");
            dtgRelatorioFesta.Columns.Add("inicio", "Horário");
            dtgRelatorioFesta.Columns.Add("termino", "Término");
            dtgRelatorioFesta.Columns.Add("tema", "Tema");

            string caminho = "Festas.txt";

            if (File.Exists(caminho))
            {
                string[] linhasResultado = File.ReadAllLines(caminho);

                for (int i = 0; i < linhasResultado.Length; i++)
                {
                    string[] linhaAtualResultado = linhasResultado[i].Split('|');
                    if (linhaAtualResultado[2] == dtpRelatorioFesta.Value.ToShortDateString())
                    {
                        linhaAtualResultado = linhaAtualResultado.Take(linhaAtualResultado.Count() - 1).ToArray();
                        dtgRelatorioFesta.Rows.Add(linhaAtualResultado);
                    }
                }
            }
        }
    }
}
