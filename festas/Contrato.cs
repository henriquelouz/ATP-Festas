using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace festas
{
    class Contrato
    {
        public static double valorTotal(int qtdeConvidados, string diaDaSemana)
        {
            double valorTotal;

            if(diaDaSemana == "segunda-feira" || diaDaSemana == "terça-feira" || diaDaSemana == "quarta-feira" || diaDaSemana == "quinta-feira") {
                if (qtdeConvidados == 30) {
                    valorTotal = 1899.00;
                }
                else if (qtdeConvidados == 50)
                {
                    valorTotal = 2199.00;
                }
                else if (qtdeConvidados == 80)
                {
                    valorTotal = 3199.00;
                }
                else
                {
                    valorTotal = 3799.00;
                }
            }
            else{
                if (qtdeConvidados == 30)
                {
                    valorTotal = 2099.00;
                }
                else if (qtdeConvidados == 50)
                {
                    valorTotal = 2299.00;
                }
                else if (qtdeConvidados == 80)
                {
                    valorTotal = 3499.00;
                }
                else
                {
                    valorTotal = 3999.00;
                }
            }
            return valorTotal;
        }
    }
}
