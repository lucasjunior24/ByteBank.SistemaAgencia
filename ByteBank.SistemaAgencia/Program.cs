using ByteBank.Models;
using Modelos.Funcionarios;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = null;
            ContaCorrente conta = new ContaCorrente(443, 322323);
            Console.WriteLine("Numero: "+ conta.Numero);
        }
    }
}
