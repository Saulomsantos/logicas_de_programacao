using System;
namespace Senai.OO.Array.Exercicio3.Classes
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        bool flag = false;
        bool flagSenha = false;

        #region Metodos
        public void ReceberDados()
        {
            System.Console.WriteLine("Informe o nome");
            Nome = Console.ReadLine();

            while (flag == false)
            {
                System.Console.WriteLine("Informe o e-mail");
                Email = Console.ReadLine();
                if (Email.Contains("@"))
                {
                   flag = true;
                }
                else
                {
                    System.Console.WriteLine("\nE-mail inválido!\n");
                }
            }

            while (flagSenha == false)
            {
                System.Console.WriteLine("Informe a senha com no mínimo 4 dígitos");
                Senha = Console.ReadLine();
                if (Senha.Length >= 4)
                {
                    flagSenha = true;
                }
                else
                {
                    System.Console.WriteLine("\nSenha inserida não atende os requisitos!\n");
                }
            }    
            
        }
        #endregion
    }
}