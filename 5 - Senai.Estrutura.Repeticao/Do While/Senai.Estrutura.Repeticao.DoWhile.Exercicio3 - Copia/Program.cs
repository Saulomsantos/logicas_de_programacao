using System;

namespace Senai.Estrutura.Repeticao.DoWhile.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, opcao = 0;
            string repetir = "N";

            System.Console.WriteLine("\nInforme o primeiro número");
            x = int.Parse(Console.ReadLine());

            System.Console.WriteLine("\nInforme o segundo número");
            y = int.Parse(Console.ReadLine());

            do
            {
                System.Console.WriteLine("\nEscolha a operação a ser executada\n" +
                "\n1 - soma\n" +
                "2 - subtração\n" +
                "3 - multiplicação\n" +
                "4 - divisão\n" +
                "5 - potenciação\n" +
                "0 - sair\n"
                );
                opcao = int.Parse(Console.ReadLine());

                



                switch (opcao)
                {
                    case 1:
                    {
                        System.Console.WriteLine($"Resultado: {x + y}\n");
                        break;
                    }

                    case 2:
                    {
                        System.Console.WriteLine($"Resultado: {x - y}\n");
                        break;
                    }

                    case 3:
                    {
                        System.Console.WriteLine($"Resultado: {x * y}\n");
                        break;
                    }

                    case 4:
                    {
                        System.Console.WriteLine($"Resultado: {x / y}\n");
                        break;
                    }

                    case 5:
                    {
                        System.Console.WriteLine($"Resultado: {Math.Pow(x,y)}\n");
                        break;
                    }
                    
                    default:
                    break;
                }
                

            } while (opcao!=0);
            
        }
    }
}
