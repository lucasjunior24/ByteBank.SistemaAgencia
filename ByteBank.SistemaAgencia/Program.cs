using System;
using System.Data;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Datas data = new Datas();
            data.MostrarDatas();

            Console.ReadLine(); 
        }

    }
}
