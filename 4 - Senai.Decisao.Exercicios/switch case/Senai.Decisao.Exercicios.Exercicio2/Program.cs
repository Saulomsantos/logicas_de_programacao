using System;

namespace Senai.Decisao.Exercicios.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEscolha a opção abaixo de acordo com o ojeto desejado e digite o número correspondente:\n" + 
            "\n1 - Quadrado\n" +
            "2 - Triângulo\n" +
            "3 - Círculo\n");
            int Objeto = int.Parse(Console.ReadLine());

            switch (Objeto)
            {
                case 1:
                {
                    System.Console.WriteLine("\nQual a medida do lado do quadrado em metros?");
                    int Lado = int.Parse(Console.ReadLine());
                    int AreaQuad = Lado * Lado;
                    System.Console.WriteLine($"\nA área do quadrado é: {AreaQuad} m²\n");
                    break;
                }

                case 2:
                {
                    System.Console.WriteLine("\nQual a medida da base do triângulo em centímetros?");
                    int Base = int.Parse(Console.ReadLine());
                    System.Console.WriteLine("\nQual a altura do triângulo em centímetros?");
                    int Altura = int.Parse(Console.ReadLine());
                    int AreaTri = Base * Altura;
                    System.Console.WriteLine($"\nA área do triângulo é: {AreaTri} cm²\n");
                    break;
                }

                case 3:
                {
                    System.Console.WriteLine("\nQual a medida do raio do círculo em centímetros?");
                    int Raio = int.Parse(Console.ReadLine());
                    double AreaCirc = Math.PI * Raio * Raio;
                    System.Console.WriteLine($"\nA área do círculo é: {AreaCirc} cm²\n");
                    break;
                }

                default:
                {
                    System.Console.WriteLine("Opção inválida");
                    break;
                }
            }   
        }
    }
}
