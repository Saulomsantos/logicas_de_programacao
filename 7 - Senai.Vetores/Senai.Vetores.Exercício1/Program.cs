using System;

namespace Senai.Vetores.Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe a quantidade de cadastros");
            int quantCadastros = int.Parse(Console.ReadLine());

            string[,] dadosPessoais = new string[quantCadastros,3];

            for (int i = 0; i < quantCadastros; i++)
            {
                System.Console.WriteLine("Informe o nome");
                dadosPessoais[i,0] = Console.ReadLine();

                System.Console.WriteLine("Informe o CPF");
                dadosPessoais[i,1] = Console.ReadLine();
                
                System.Console.WriteLine("Informe o telefone");
                dadosPessoais[i,2] = Console.ReadLine();
            }

            for (int c = 0; c < quantCadastros; c++)
            {
                System.Console.WriteLine($"| {dadosPessoais[c,0]}\t| {dadosPessoais[c,1]}\t| {dadosPessoais[c,2]}\t |");
            }
        }
    }
}
