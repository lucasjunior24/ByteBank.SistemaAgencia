using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    { 
        static void Main(string[] args)
        {

            //Console.WriteLine(SomarVarios(1333333, 3, 4, 5, 5));
            //Console.WriteLine(SomarVarios(5, 5));

            //TestaListaDeContaCorrente();

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(3, 434434),
                new ContaCorrente(323, 434435),
                null,
                null,
                null,
                new ContaCorrente(54, 434436),
                new ContaCorrente(121, 434436),
                new ContaCorrente(341, 3)
            };

            var listaContas = contas.OrderBy(conta => {
                if (conta == null) return int.MaxValue;
                return conta.Numero;
                });
            //contas.Sort(new ComparadorContaCorrenteAgencia());

            foreach (var conta in listaContas)
            {
                if (conta != null)
                {
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                }
            }


            Console.ReadLine(); 
        }
        static void TesteListaDeIdades()
        {
            List<int> idades = new List<int>();
            idades.Add(1);
            idades.Add(3);
            idades.Add(4);
            idades.Add(5);
            idades.Add(65);

            //idades.AddRange();

            //ListExtensoes.AdicionarVarios(idades, 3, 323, 4343, 43);

            idades.AdicionarVarios(2, 232, 32322, 4343);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(433, 43433),
                new ContaCorrente(433, 34322),
                new ContaCorrente(433, 43434),
                new ContaCorrente(433, 43435),
                new ContaCorrente(433, 43414)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(
                new ContaCorrente(433, 43434),
                new ContaCorrente(433, 43435),
                new ContaCorrente(433, 43414)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                //ContaCorrente itemAtual = lista.GetItemNoIndice(i);
                Console.WriteLine($"iTEM NA POSICAO {i} = conta {itemAtual.Numero}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }

            return acumulador;
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
