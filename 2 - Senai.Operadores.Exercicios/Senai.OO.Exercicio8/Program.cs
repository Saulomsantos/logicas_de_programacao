using System;
using Senai.OO.Exercicio8.Classes;

namespace Senai.OO.Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Funcionario 1
            Funcionario f1 = new Funcionario(); //f1 é o objeto

            //Recebendo o nome
            System.Console.WriteLine("Insira o nome do funcionario");
            f1.Nome = Console.ReadLine();
            
            //Recebendo o valor da hora
            //Para fazer um site, cobrar pelo menos 40 horas
            System.Console.WriteLine("Insira o valor/hora");
            f1.ValorHora = double.Parse(Console.ReadLine());

            //Recebendo o numero de horas trabalhadas
            System.Console.WriteLine("Insira a quantidade de horas trabalhadas");
            f1.HorasTrabalhadas = int.Parse(Console.ReadLine());
            #endregion

            System.Console.WriteLine($"Valor a ser pago R$ {f1.CalcularValorProjeto().ToString("c")}");
        }
    }
}