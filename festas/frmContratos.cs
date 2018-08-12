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
    public partial class frmContratos : Form
    {

        public frmContratos()
        {
            InitializeComponent();
        }

        private void frmContratos_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void dtgContratos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = dtgContratos.Rows[e.RowIndex].Cells[5].Value.ToString();
            if(status == "A pagar")
            {
                frmAvisoStatus aviSta = new frmAvisoStatus(e.RowIndex);
                aviSta.ShowDialog();
            }

            loadDataGrid();

            dtgContratos.CurrentCell = dtgContratos.Rows[e.RowIndex].Cells[0];
        }

        private void loadDataGrid()
        {

            dtgContratos.DataSource = null;
            dtgContratos.Rows.Clear();
            dtgContratos.Columns.Clear();

            string caminho = "Contratos.txt";

            if (File.Exists(caminho))
            {
                string[] linhas = File.ReadAllLines(caminho);

                dtgContratos.Columns.Add("codigo", "Código");
                dtgContratos.Columns.Add("valorTotal", "Valor total");
                dtgContratos.Columns.Add("valorFinal", "Valor final");
                dtgContratos.Columns.Add("desconto", "Desconto");
                dtgContratos.Columns.Add("pagamento", "Pagamento");
                dtgContratos.Columns.Add("status", "Status");
                dtgContratos.Columns.Add("codFesta", "Cód. Festa");


                for (int i = 0; i < linhas.Length; i++)
                {
                    string[] linhaAtual = linhas[i].Split('|');
                    dtgContratos.Rows.Add(linhaAtual);
                }

            }
        }

        private void dtgContratos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int n = 0; n < (dtgContratos.Rows.Count - 1); n++)
            {
                string status = dtgContratos.Rows[n].Cells[5].Value.ToString();

                if (status == "A pagar")
                {
                    dtgContratos.Rows[n].Cells[5].Style.ForeColor = Color.Orange;
                }
                else if (status == "Cancelado")
                {
                    dtgContratos.Rows[n].Cells[5].Style.ForeColor = Color.Red;
                }
                else if (status == "Pago")
                {
                    dtgContratos.Rows[n].Cells[5].Style.ForeColor = Color.Green;
                }

            }
        }
    }
}
