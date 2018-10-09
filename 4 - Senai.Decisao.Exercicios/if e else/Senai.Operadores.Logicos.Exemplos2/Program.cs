using System;

namespace Senai.Operadores.Logicos.Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Idade;
            string Sexo;

            Console.WriteLine("\nInforme a idade");
            Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o sexo [M/F]]");
            Sexo = Console.ReadLine();

            if (Idade >= 18)
            {
                if (Sexo == "M")
                {
                    Console.Clear();
                    System.Console.WriteLine("Está apto a se alistar\n");
                }
                else
                {
                    Console.Clear();
                    System.Console.WriteLine("O alistamento é facultativo para o sexo Feminino\n");
                }
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("O alistamento só é permitido para maiores de 18 anos\n");
            }
        }
    }
}
