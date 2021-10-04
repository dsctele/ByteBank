using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Engenheiro de Desenvolvimento de Produtos";
            //gabriela.cpf = "059.319.539-65";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;

            //conta.titular = new Cliente();
            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "059.319.539-65";
            //conta.titular.profissao = "Engenheiro de Desenvolvimento de Produtos";

            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;
            
            if(conta.titular == null)
            {
                Console.WriteLine("ops, a referencia em conta.titular é NULL");
            }

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

        }
    }
}
