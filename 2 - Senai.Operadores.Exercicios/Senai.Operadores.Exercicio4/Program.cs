using System;

namespace Senai.Operadores.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInforme a temperatura em graus Celsius");
            float tempC = float.Parse(Console.ReadLine());

            float tempF = (9 * tempC + 160) / 5;
            
            Console.WriteLine($"\nA temperatura informada em Celsius convertida em Farenheit é: {tempF} ºF\n");
        }
    }
}
