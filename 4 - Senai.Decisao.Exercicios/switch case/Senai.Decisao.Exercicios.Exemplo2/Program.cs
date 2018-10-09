using System;

namespace Senai.Decisao.Exercicios.Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o último dígito da placa do seu carro");
            int Placa = int.Parse(Console.ReadLine());

            switch (Placa)
            {
                case 1: case 2:
                {
                    System.Console.WriteLine("Segunda-feira");
                    break;
                }

                case 3: case 4:
                {
                    System.Console.WriteLine("Terça-feira");
                    break;
                }

                case 5: case 6:
                {
                    System.Console.WriteLine("Quarta-feira");
                    break;
                }

                case 7: case 8:
                {
                    System.Console.WriteLine("Quinta-feira");
                    break;
                }

                case 9: case 0:
                {
                    System.Console.WriteLine("Sexta-feira");
                    break;
                }

                default:
                {
                    System.Console.WriteLine("Dígito inválido");
                    break;
                }
            }
        }
    }
}
