using System;
using Senai.Metodos.Exercicio1.Classes;

namespace Senai.Metodos.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calc = new Calculadora();
            
            System.Console.WriteLine("Informe o valor 1");
            double valor1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe o valor 2");
            double valor2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("\nQual operação deseja efetuar?" +
            "\n1 - Soma" +
            "\n2 - Subtração" +
            "\n3 - Multiplicação" +
            "\n4 - Divisão\n");
            int opcao = int.Parse(Console.ReadLine());

            //Operações da calculadora
            
            switch (opcao)
            {
                case 1:
                {
                    //Soma
                    double resultSoma = Calc.Somar(valor1,valor2);
                    Console.Clear();
                    System.Console.WriteLine($"Soma:\n{valor1} + {valor2} = {resultSoma}\n");
                    break;
                }

                case 2:
                {
                    //Subtração
                    double resultSubtracao = Calc.Subtrair(valor1,valor2);
                    Console.Clear();
                    System.Console.WriteLine($"Subtração:\n{valor1} + {valor2} = {resultSubtracao}\n");
                    break;
                }

                case 3:
                {
                    //Multiplicação
                    double resulMultiplicacao = Calc.Multiplicar(valor1,valor2);
                    Console.Clear();
                    System.Console.WriteLine($"Multiplicação:\n{valor1} * {valor2} = {resulMultiplicacao}\n");
                    break;
                }

                case 4:
                {
                    //Divisão
                    double resultDivisao = Calc.Dividir(valor1,valor2);
                    Console.Clear();
                    System.Console.WriteLine($"Divisão:\n{valor1} / {valor2} = {resultDivisao}\n");
                    break;
                }

                default:
                {
                    Console.Clear();
                    System.Console.WriteLine("Opção inválida\n");
                    break;
                }
            }
        }
    }
}
