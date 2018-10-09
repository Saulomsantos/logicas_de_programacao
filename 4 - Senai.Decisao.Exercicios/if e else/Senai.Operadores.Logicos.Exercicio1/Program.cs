using System;

namespace Senai.Operadores.Logicos.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            int Valor1;
            int Valor2;

            System.Console.WriteLine("Informe o Valor 1");
            Valor1 = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Informe o Valor 2");
            Valor2 = int.Parse(Console.ReadLine());

            if (Valor1 != Valor2)
            {
                if (Valor1 > Valor2)
                {
                    Console.Clear();
                    System.Console.WriteLine($"O maior valor inserido é: {Valor1}");
                }
                else
                {
                    Console.Clear();
                    System.Console.WriteLine($"O maior valor inserido é: {Valor2}\n");
                }
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("Os valores precisam ser diferentes");
            }
        }
    }
}
