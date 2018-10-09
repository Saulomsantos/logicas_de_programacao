using System;

namespace Senai.Operadores.Logicos.Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebe os dados do usuário e faz a conversão para inteiro
            System.Console.WriteLine("Informe o dia de nascimento");
            int DiaNascimento = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o mês de nascimento");
            int MesNascimento = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o ano de nascimento");
            int AnoNascimento = int.Parse(Console.ReadLine());

            if (DiaNascimento < 0 || DiaNascimento > 31)
            {
                System.Console.WriteLine("Dia informado inválido");
            }
            else
            {
                if (MesNascimento < 0 || MesNascimento > 12)
                {
                    System.Console.WriteLine("Mês informado inválido");
                }
                else
                {
                    if (AnoNascimento < 0 || AnoNascimento > 2013)
                    {
                        System.Console.WriteLine("Ano informado inválido");
                    }
                    else
                    {
                        System.Console.WriteLine($"Sua data de nascimento é: {DiaNascimento}/{MesNascimento}/{AnoNascimento}");
                    }
                }
            }
        }
    }
}
