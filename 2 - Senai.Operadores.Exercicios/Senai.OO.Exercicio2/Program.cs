using System;
using Senai.OO.Exercicio2.classes;

namespace Senai.OO.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            Produto produto2 = new Produto();
            Produto produto3 = new Produto();

            #region Produto 1   
            Console.WriteLine("\nInsira o nome do produto 1");
            produto1.Nome = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto 1");
            produto1.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade do produto 1");
            produto1.Quantidade = int.Parse(Console.ReadLine());
            #endregion

            #region Produto 2   
            Console.WriteLine("\nInsira o nome do produto 2");
            produto2.Nome = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto 2");
            produto2.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade do produto 2");
            produto2.Quantidade = int.Parse(Console.ReadLine());
            #endregion

            #region Produto 3   
            Console.WriteLine("\nInsira o nome do produto 3");
            produto3.Nome = Console.ReadLine();

            Console.WriteLine("Insira o preço do produto 3");
            produto3.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade do produto 3");
            produto3.Quantidade = int.Parse(Console.ReadLine());
            #endregion

            Console.Clear();

            Console.WriteLine($"\n{produto1.Nome}:\nR$ {produto1.Preco}\n{produto1.Quantidade} unidades\n");
            Console.WriteLine($"\n{produto2.Nome}:\nR$ {produto2.Preco}\n{produto2.Quantidade} unidades\n");
            Console.WriteLine($"\n{produto3.Nome}:\nR$ {produto3.Preco}\n{produto3.Quantidade} unidades\n");

            Console.WriteLine(
                $"A média de preço dos produtos é de: R$ " +
                $"{ ((produto1.Preco * produto1.Quantidade) + (produto2.Preco * produto2.Quantidade) + (produto3.Preco * produto3.Quantidade)) / (produto1.Quantidade + produto2.Quantidade + produto3.Quantidade) }\n");
        }
    }
}
