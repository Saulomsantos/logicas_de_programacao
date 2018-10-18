using System;

namespace Senai.Estrutura.Repeticao.For.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int somatoria = 0;
            int numero;

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Insira um número");
                numero = int.Parse(Console.ReadLine());
                somatoria = somatoria + numero;
            }

            System.Console.WriteLine($"Somatória = {somatoria}");
            System.Console.WriteLine($"Média = {somatoria/5}");
        }
    }
}
