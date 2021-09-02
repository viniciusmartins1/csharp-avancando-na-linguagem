using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 12, 17);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            //string mensagem = "Vencimento em " + Humanizer.TimeSpanHumanizerExtensions.Humanize(diferenca);
            
            //Console.WriteLine(mensagem);
            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);

        }

        static string GetIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            if(timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                if(quantidadeMeses == 1)
                {
                    return " 1 mês";
                }
                return quantidadeMeses + " meses";
            }

            return timeSpan.Days + " dias";
        }
    }
}
