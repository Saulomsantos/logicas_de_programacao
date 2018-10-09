using System;

namespace Senai.Operadores.Logicos.Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Desenvolva um programa que receba duas notas e retorne a media
              Para ser aprovado, a media do aluno deve ser maior ou igual a 50
              Caso contrário, o aluno sera reprovado
            */

            double nota1;
            double nota2;
            double media;

            System.Console.WriteLine("\nDigite a primeira nota");
            nota1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("\nDigite a segunda nota");
            nota2 = double.Parse(Console.ReadLine());

            if (nota1 > 100)
            {
                System.Console.WriteLine("\nDigite a primeira nota novamente, entre 0 e 100");
                nota1 = double.Parse(Console.ReadLine());
            }
            else
            if (nota1 < 0)
            {
                System.Console.WriteLine("\nDigite a primeira nota novamente, entre 0 e 100");
                nota1 = double.Parse(Console.ReadLine());
            }

            media = (nota1 + nota2) / 2;

            Console.Clear();

            //System.Console.WriteLine($"Nota 1: {nota1}\nNota 2: {nota2}\nMedia: {media}\n");

            System.Console.WriteLine("A média do aluno é: " + media + "\n");

            if (media >= 50)
            {
                System.Console.WriteLine("Situação: Aprovado!\n");
            }
            else
            {
                System.Console.WriteLine("Situação: Reprovado!\n");
            }
        }
    }
}
