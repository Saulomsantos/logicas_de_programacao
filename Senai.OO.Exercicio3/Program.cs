using System;
using Senai.OO.Exercicio3.Classes;

namespace Senai.OO.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Produto 1
            // criação do objeto produtos
            produtos produto1 = new produtos();

            Console.WriteLine("Informe o nome do produto 1");
            produto1.Nome = Console.ReadLine();
            #endregion
        }
    }
}
