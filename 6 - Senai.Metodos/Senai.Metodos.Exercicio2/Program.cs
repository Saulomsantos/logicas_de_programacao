using System;
using  Senai.Metodos.Exercicio2.Classes;

namespace Senai.Metodos.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garrafa Garrafa1 = new Garrafa();
            int opcao = 0;
            float qtd;

            do
            {
                Console.WriteLine("Qual método deseja aplicar à garrafa?");
                Console.WriteLine("1 - encher");
                Console.WriteLine("2 - esvaziar");
                Console.WriteLine("3 - exibir quantidade");
                Console.WriteLine("4 - encerrar");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                    {
                        System.Console.WriteLine("Quanto deseja encher?");
                        qtd = float.Parse(Console.ReadLine());
                        Garrafa1.Encher(qtd);
                        break;
                    }

                    case 2:
                    {
                        System.Console.WriteLine("Quanto deseja esvaziar?");
                        qtd = float.Parse(Console.ReadLine());
                        Garrafa1.Esvaziar(qtd);
                        break;
                    }

                    case 3:
                    {
                        Garrafa1.Mostrar();
                        break;
                    }

                    default:
                    {
                        break;
                    }
                }                
            } while (opcao != 4);
        }
    }
}
