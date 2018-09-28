using System;
using Senai.OO.Exercicio3.Classes;

namespace Senai.OO.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            Conta conta2 = new Conta();
            Conta conta3 = new Conta();

            #region Cliente 1
            Console.WriteLine("\nInforme o nome do cliente 1");
            conta1.Nome = Console.ReadLine();

            Console.WriteLine("\nInforme o número da conta do cliente 1");
            conta1.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o saldo da conta do cliente 1");
            conta1.Saldo = decimal.Parse(Console.ReadLine());
            #endregion

            #region Cliente 2
            Console.WriteLine("\nInforme o nome do cliente 2");
            conta2.Nome = Console.ReadLine();

            Console.WriteLine("\nInforme o número da conta do cliente 2");
            conta2.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o saldo da conta do cliente 2");
            conta2.Saldo = decimal.Parse(Console.ReadLine());
            #endregion

            #region Cliente 3
            Console.WriteLine("\nInforme o nome do cliente 3");
            conta3.Nome = Console.ReadLine();

            Console.WriteLine("\nInforme o número da conta do cliente 3");
            conta3.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o saldo da conta do cliente 3");
            conta3.Saldo = decimal.Parse(Console.ReadLine());
            #endregion

            Console.Clear();

            Console.WriteLine($"\nCliente 1\nNome: {conta1.Nome}\nConta: {conta1.Numero}\nSaldo: R${conta1.Saldo}\n");
            Console.WriteLine($"\nCliente 2\nNome: {conta2.Nome}\nConta: {conta2.Numero}\nSaldo: R${conta2.Saldo}\n");
            Console.WriteLine($"\nCliente 3\nNome: {conta2.Nome}\nConta: {conta2.Numero}\nSaldo: R${conta2.Saldo}\n");

            Console.WriteLine($"Saldo total: R$ {(conta1.Saldo + conta2.Saldo + conta3.Saldo)}\n");
        }
    }
}
