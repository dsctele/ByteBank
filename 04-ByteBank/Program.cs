﻿using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine(contaDoBruno.saldo);
            bool resultadodoSaque = contaDoBruno.Sacar(500);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadodoSaque);
            Console.WriteLine(contaDoBruno.saldo);

            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);



        }
    }
}
