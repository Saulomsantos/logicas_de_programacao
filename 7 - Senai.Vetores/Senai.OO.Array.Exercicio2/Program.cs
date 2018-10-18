using System;
using Senai.OO.Array.Exercicio2.Classes;

namespace Senai.OO.Array.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntCadastros;

            System.Console.WriteLine("Informe a quantidade de cadastros");
            qntCadastros = int.Parse(Console.ReadLine());

            Usuario[] usuarios = new Usuario[qntCadastros];

            for (int i = 0; i < qntCadastros; i++)
            {
                usuarios[i] = new Usuario();

                usuarios[i].ReceberDados();                
            }

            System.Console.WriteLine("");

            for (int c = qntCadastros-1; c >= 0; c--)
            {
                System.Console.WriteLine($"\n{c+1}º - {usuarios[c].Nome}, {usuarios[c].Idade}, {usuarios[c].Endereco}");
            }

            System.Console.WriteLine("");
        }
    }
}
