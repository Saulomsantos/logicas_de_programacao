using System;

namespace Senai.Estrutura.Repeticao.DoWhile.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFinal;
            int numControle = 0;
            int QuantNumPares = 0;

            Console.WriteLine("\nInforme o número");
            numFinal = int.Parse(Console.ReadLine());

            Console.Clear();

            do
            {
                numControle++;
                if (numControle % 2 == 0)
                {
                    System.Console.WriteLine(numControle);
                    QuantNumPares++;
                }
            } while (numControle < numFinal -1);

            System.Console.WriteLine($"\nA quantidade de números pares é {QuantNumPares}");
        }
    }
}
