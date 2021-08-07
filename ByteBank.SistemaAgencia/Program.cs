using ByteBank.Models;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(443, 322323);
            Console.WriteLine("Numero: "+ conta.Numero);
        }
    }
}
