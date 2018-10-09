using System;

namespace Senai.Estrutura.Repeticao.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite a senha");
            double senha1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Confirme a senha");
            double senha2 = double.Parse(Console.ReadLine());

            while (senha1 != senha2)
            {
                System.Console.WriteLine("Senha incorreta. A confirmação da senha deve ser igual à senha inicial. Digite novamente");
                senha2 = double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Senha correta. Acesso garantido");
        }
    }
}
