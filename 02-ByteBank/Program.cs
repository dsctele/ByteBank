using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.agencia = 100;
            conta.numero = 100;
            conta.saldo = 100;

            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.numero);
            Console.WriteLine(conta.saldo);
        }
    }
}
