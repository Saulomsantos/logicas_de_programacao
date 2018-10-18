using System;

namespace Senai.Estrutura.Repeticao.For.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int limite;

            System.Console.WriteLine("Qual tabuada deseja exibir?");
            numero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("E qual o limmite desta tabuada?");
            limite = int.Parse(Console.ReadLine());

            for (int i = 0; i <= limite; i++)
            {
                System.Console.WriteLine($"{numero} x {i} = {numero*i}");
            }
        }
    }
}
