using System;

namespace Senai.Operadores.Logicos.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int AnoNascimento;

            Console.WriteLine("Informe o ano de nascimento");
            AnoNascimento = int.Parse(Console.ReadLine());

            if (AnoNascimento <= 2002)
            {
                System.Console.WriteLine("É possível votar este ano");
            }
            else
            {
                System.Console.WriteLine("Não será possível votar este ano");
            }
        }
    }
}
