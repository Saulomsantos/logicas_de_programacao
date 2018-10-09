using System;
using Senai.OO.Exercicio6.Classes;

namespace Senai.OO.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Nomes Nomes = new Nomes();

            //Recebendo nome da pessoa
            System.Console.WriteLine("Insira seu nome");
            Nomes.Nome1 = Console.ReadLine();

            System.Console.WriteLine($"Completo: {Nomes.Nome1}");
            //Uma forma de pegar um ou mais caracteres indicando qual e o desejado
            //System.Console.WriteLine($"Primeira letra: {Nomes.Nome1.Substring(0,1)}");
            System.Console.WriteLine($"Primeiro caractere: {Nomes.Nome1[0]}");

            //Calculando o comprimento da string
            int tamanho = Nomes.Nome1.Length;
            System.Console.WriteLine($"Ultimo caractere: {Nomes.Nome1[tamanho-1]}");

            System.Console.WriteLine($"Primeiro caractere ao terceiro caractere: {Nomes.Nome1.Substring(0,3)}");

            System.Console.WriteLine($"Terceiro caractere: {Nomes.Nome1[2]}");

            System.Console.WriteLine($"Todos os caracteres menos o primeiro: {Nomes.Nome1.Substring(1,tamanho-1)}");
            System.Console.WriteLine($"Todos os caracteres menos o primeiro: {Nomes.Nome1.Substring(tamanho-2,2)}");
        }
    }
}
