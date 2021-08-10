using System;
using Humanizer;

namespace ByteBank.Modelos
{
    public class Datas
    {
        public void MostrarDatas()
        {
            DateTime dataVencimento = new DateTime(2021, 08, 15);
            DateTime dataHoje = DateTime.Now;

            TimeSpan diferenca = dataVencimento - dataHoje;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
        }
    }
}
