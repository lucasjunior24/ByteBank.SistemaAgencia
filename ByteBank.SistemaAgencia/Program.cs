using System;
using System.Data;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string urlParametros = "htttp://wwww.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extrator.GetValor("moedaDestino");
            Console.WriteLine("valor da moedaDestino: " + valor);
            Console.WriteLine(extrator.GetValor("valor"));

            //string teste = "primeriaParte&remover";
            //int indice = teste.IndexOf('&');
            //Console.WriteLine(teste.Remove(indice));

            Console.ReadLine(); 
        }

    }
}
