using System;

namespace Senai.Estrutura.Repeticao.For.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroPar;

            do
            {
                System.Console.WriteLine("Informe o numero par");
                numeroPar = int.Parse(Console.ReadLine());
            } while (numeroPar%2 != 0);

            System.Console.WriteLine($"\nOs próximos 100 números pares após o {numeroPar} são:\n");

            for (int i = 1; i <= 100; i++)
            {
                if (i%2 == 0)
                {
                    System.Console.WriteLine($"{numeroPar + i}");
                }
            }
        }
    }
}
