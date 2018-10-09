using System;

namespace Senai.Operadores.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInforme o preço do produto 1");
            float preco1 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o preço do produto 2");
            float preco2 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o preço do produto 3");
            float preco3 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o preço do produto 4");
            float preco4 = float.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o preço do produto 5");
            float preco5 = float.Parse(Console.ReadLine());

            float mediaPrecos = (preco1 + preco2 + preco3 + preco4 + preco5) / 5;

            Console.WriteLine($"\nO preço médio dos produtos informados é: {mediaPrecos}\n");
        }
    }
}
