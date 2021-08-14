using System;
using System.Data;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    { 
        static void Main(string[] args)
        {
            string urlParametros = "htttp://wwww.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extrator.GetValor("moedaDestino");
            Console.WriteLine("valor da moedaDestino: " + valor);

            string valor3 = extrator.GetValor("moedaOrigem");
            Console.WriteLine("valor da moedaOrigem: " + valor3);

            Console.WriteLine(extrator.GetValor("VALOR"));

            //string teste = "primeriaParte&remover";
            //int indice = teste.IndexOf('&');
            //Console.WriteLine(teste.Remove(indice));

            Console.ReadLine(); 
        }

    }
}
