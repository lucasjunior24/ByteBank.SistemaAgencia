using System;
using System.Data;
using ByteBank.Modelos;
using Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    { 
        static void Main(string[] args)
        {

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(433, 43433));
            lista.Adicionar(new ContaCorrente(433, 434322));
            lista.Adicionar(new ContaCorrente(433, 43434));
            lista.Adicionar(new ContaCorrente(433, 43434));
            lista.Adicionar(new ContaCorrente(433, 43434));
            lista.Adicionar(new ContaCorrente(433, 43434));
            lista.Adicionar(new ContaCorrente(433, 43434));
            lista.Adicionar(new ContaCorrente(433, 43434));
            lista.Adicionar(new ContaCorrente(433, 43434));
            lista.Adicionar(new ContaCorrente(433, 43434));
            lista.Adicionar(new ContaCorrente(433, 43434));
            lista.Adicionar(new ContaCorrente(433, 43434));

            Console.ReadLine(); 
        }

        static void TestaArray()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(4343, 4343443),
                new ContaCorrente(4343, 4343443),
                new ContaCorrente(4343, 4343443)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaString()
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
        }
    }
}
