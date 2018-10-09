using System;

namespace Senai.Decisao.Exercicios.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebendo o número do dia da semana e converte para inteiro
            Console.WriteLine("Informe o número do dia da semnana: ");
            int DiaSemana = int.Parse(Console.ReadLine());

            switch (DiaSemana)
            {
                case 1:
                {
                    System.Console.WriteLine("Domingo");
                    break;
                }

                case 2:
                {
                    System.Console.WriteLine("Segunda-feira");
                    break;
                }

                case 3:
                {
                    System.Console.WriteLine("Terça-feira");
                    break;
                }

                case 4:
                {
                    System.Console.WriteLine("Quarta-feira");
                    break;
                }

                case 5:
                {
                    System.Console.WriteLine("Quinta-feira");
                    break;
                }

                case 6:
                {
                    System.Console.WriteLine("Sexta-feira");
                    break;
                }

                case 7:
                {
                    System.Console.WriteLine("Sábado");
                    break;
                }

                default:
                {
                    System.Console.WriteLine("Número do dia da semana inválido");
                    break;
                }
            }
        }
    }
}
