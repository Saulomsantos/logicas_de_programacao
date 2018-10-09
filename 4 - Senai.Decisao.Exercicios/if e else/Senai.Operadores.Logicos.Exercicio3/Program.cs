using System;

namespace Senai.Operadores.Logicos.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Senha;
            
            Console.WriteLine("Digite a senha");
            Senha = int.Parse(Console.ReadLine());

            if (Senha == 1234)
            {
                System.Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                System.Console.WriteLine("ACESSO NEGADO");
            }
        }
    }
}
