using System;

namespace Senai.Vetores.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5,5];
            // int quantVerif = 0;
            bool flag = false;

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int c = 0; c < 5; c++)
                {
                    matriz[i,c] = random.Next(51);
                    Console.Write($"{matriz[i,c]}\t");
                }
                System.Console.WriteLine("");
            }

            System.Console.WriteLine("");

            System.Console.WriteLine("Informe o número a ser verificado");
            int numVerif = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                for (int c = 0; c < 5; c++)
                {                   
                    if (numVerif == matriz[i,c])
                    {
                        System.Console.WriteLine($"O número {numVerif} aparece na linha {i} e na coluna {c} da matriz");
                        flag = true;
                        break;
                        // i = 5;
                        // c = 5;
                        // quantVerif++;
                    }
                    // else
                    // {
                    //     System.Console.WriteLine("O número não pertence a esta matriz");
                    // }
                }
                if (flag)
                {
                    break;
                }
            }
            if (flag == false)
            {
                System.Console.WriteLine("O número não pertence a esta matriz");
            }
        }
    }
}
