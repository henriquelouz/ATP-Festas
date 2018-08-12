using System;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace festas
{
    public partial class frmCadastrarFesta : Form
    {
        public frmCadastrarFesta()
        {
            InitializeComponent();
            cmbFestaQtdeConvidados.SelectedIndex = 0;
        }

        private void btnFestaCadastrar_Click(object sender, EventArgs e)
        {
            string diaDaSemana = getDiaDaSemana();
            DateTime novaReserva;

            if (diaDaSemana == "sábado")
            {
                if (rdbFestaHorario12.Checked){
                    novaReserva = DateTime.Parse(dtpFestaData.Value.ToShortDateString() + " 12:00:00");
                }else{
                    novaReserva = DateTime.Parse(dtpFestaData.Value.ToShortDateString() + " 18:00:00");
                }
            }
            else
            {
                novaReserva = DateTime.Parse(dtpFestaData.Value.ToShortDateString() + " " + dtpFestaHoraDe.Value.TimeOfDay);
            }

            string caminho = "Festas.txt";

            if (File.Exists(caminho)){
                string[] linhas = File.ReadAllLines(caminho);

                for (int i = 0; i < linhas.Length; i++)
                {
                    string[] linhaAtual = linhas[i].Split('|');
                    DateTime reserva = DateTime.Parse(linhaAtual[2] + " " + linhaAtual[4]);

                    if (novaReserva == reserva || novaReserva == reserva.AddHours(1) || novaReserva == reserva.AddHours(2) || novaReserva == reserva.AddHours(3) || novaReserva.AddHours(1) == reserva || novaReserva.AddHours(2) == reserva || novaReserva.AddHours(3) == reserva)
                    {
                        MessageBox.Show("Horário indisponível!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
            
            string codCliente = cmbFestaCliente.Text.Split('-')[0];
            string dataFesta = dtpFestaData.Text;
            string novoRegistro;

            if(diaDaSemana == "sábado")
            {
                novoRegistro = cmbFestaQtdeConvidados.Text + "|" + dtpFestaData.Text + "|" + diaDaSemana + "|" + novaReserva.ToLongTimeString() + "|" + novaReserva.AddHours(4).ToLongTimeString() + "|" + txtFestaTema.Text + "|" + codCliente;
            }
            else
            {
                novoRegistro = cmbFestaQtdeConvidados.Text + "|" + dtpFestaData.Text + "|" + diaDaSemana + "|" + dtpFestaHoraDe.Text + "|" + dtpFestaHoraAte.Text + "|" + txtFestaTema.Text + "|" + codCliente;
            }

            double valorTotal = Contrato.valorTotal(int.Parse(cmbFestaQtdeConvidados.Text), diaDaSemana);

            frmAvisoPagamento aviPag = new frmAvisoPagamento(valorTotal);
            aviPag.ShowDialog();

            if (aviPag.concluido)
            {
                Arquivo.Cadastrar(caminho, novoRegistro);

                MessageBox.Show("Festa cadastrada com sucesso!", "", MessageBoxButtons.OK);

                cmbFestaCliente.SelectedIndex = 0;
                cmbFestaQtdeConvidados.SelectedIndex = 0;
                txtFestaTema.Clear();
                dtpFestaData.Value = DateTime.Now;
                rdbFestaHorario12.Checked = true;
            }

        }

        private void frmCadastrarFesta_Load(object sender, EventArgs e)
        {
            string diaDaSemana = getDiaDaSemana();
            if (diaDaSemana == "sábado")
            {
                grbFestaHorario.Visible = false;
                grbFestaHorarioSabado.Visible = true;
            }
            else
            {
                grbFestaHorario.Visible = true;
                grbFestaHorarioSabado.Visible = false;
            }
            
            string[] linhas = File.ReadAllLines("Clientes.txt");

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] linhaAtual = linhas[i].Split('|');
                linhas[i] = linhaAtual[0] + " - " + linhaAtual[1];
            }

            cmbFestaCliente.Items.AddRange(linhas);
            cmbFestaCliente.SelectedIndex = 0;
        }

        private void dtpFestaData_ValueChanged(object sender, EventArgs e)
        {
            string diaDaSemana = getDiaDaSemana();

            if (diaDaSemana == "sábado")
            {
                grbFestaHorario.Visible = false;
                grbFestaHorarioSabado.Visible = true;
            }
            else
            {
                grbFestaHorario.Visible = true;
                grbFestaHorarioSabado.Visible = false;
            }

        }

        private void dtpFestaHoraDe_ValueChanged(object sender, EventArgs e)
        {
            dtpFestaHoraAte.Value = dtpFestaHoraDe.Value.AddHours(4);
        }

        private string getDiaDaSemana()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            string diaDaSemana = dtfi.GetDayName(dtpFestaData.Value.DayOfWeek);

            return diaDaSemana;
        }
    }
}
