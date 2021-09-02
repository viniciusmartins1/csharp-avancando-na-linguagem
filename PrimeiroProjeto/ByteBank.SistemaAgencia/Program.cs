using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(212, 2332232);

            Console.WriteLine(conta.Numero);

            Console.WriteLine("Hello Word");

            Console.WriteLine();

        }
    }
}
