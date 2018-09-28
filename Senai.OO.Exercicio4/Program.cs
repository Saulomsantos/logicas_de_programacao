using System;
using Senai.OO.Exercicio4.Classes;

namespace Senai.OO.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoDeCredito Cartao1 = new CartaoDeCredito();

            Console.WriteLine("\nInforme o número do cartão");
            Cartao1.Numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme a data de validade do cartão");
            Cartao1.Validade = DateTime.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"\nDados do cartão\n\nNúmero do cartão: {Cartao1.Numero}\nValidade: {Cartao1.Validade.ToString("MM/yyyy")}\n");
        }
    }
}
