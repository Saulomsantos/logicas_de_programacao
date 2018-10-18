using System;
namespace Senai.OO.Array.Exercicio2.Classes
{
    public class Usuario
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Endereco { get; set; }

        #region Metodos

        public void ReceberDados()
        {
            System.Console.WriteLine("Informe o nome");
            Nome = Console.ReadLine();
                
            System.Console.WriteLine("Informe a idade");
            Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o endereço");
            Endereco = Console.ReadLine();
        }

        #endregion
    }
}