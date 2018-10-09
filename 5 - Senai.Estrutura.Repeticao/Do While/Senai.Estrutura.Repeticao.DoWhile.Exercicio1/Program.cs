using System;

namespace Senai.Estrutura.Repeticao.DoWhile.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            do
            {
                System.Console.WriteLine("Informe o e-mail");
                email = Console.ReadLine();
            } while (string.IsNullOrEmpty(email) == true || !email.Contains("@"));
            
            //negação
            //incrementar o "!" antes de uma instrução. ex: !email.contains("@");
            //sem utilizar negação ficaria: email.contains("@") == false;

            System.Console.WriteLine("O e-mail é válido");
            
        }
    }
}
