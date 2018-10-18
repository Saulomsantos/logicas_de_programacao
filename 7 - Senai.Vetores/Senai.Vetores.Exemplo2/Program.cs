using System;

namespace Senai.Vetores.Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variável Matriz para armazenar os números da cartela e as marcações
            int[,] cartela = new int [5,3]; //linhas, colunas
            bool[,] marcacoes = new bool [5,3];

            Random random = new Random();

            //Percorre as linhas da cartela
            for (int i = 0; i < 5; i++)
            {
                //Percorre as colunas da cartela
                for (int c = 0; c < 3; c++)
                {
                    cartela[i,c] = random.Next(51);
                    marcacoes[i,c] = false;
                }
            }

            int opcao = 0;

            do
            {

                for (int i = 0; i < 5; i++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        //Se verdadeiro mostra o X na posição
                        //Senão mostra o número
                        if (marcacoes[i,c])
                        {
                            System.Console.Write($"X\t");
                        }
                        else
                        {
                            System.Console.Write($"{cartela[i,c]}\t");
                        }
                    }

                    System.Console.WriteLine("");
                }

                //Menu de opções
                System.Console.WriteLine("1 - Informe as coordenadas");
                System.Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                    {
                        //Pede para o usuário informar as coordenadas da cartela
                        System.Console.WriteLine("Informe a coordenada x");
                        int x = int.Parse(Console.ReadLine());

                        System.Console.WriteLine("Informe a coordenada y");
                        int y = int.Parse(Console.ReadLine());

                        //Verifica se o valor informado de x e y estão dentro das coordendadas
                        if ((x >= 0) && (x < 3) && (y >= 0) && (y < 5))
                        {
                            marcacoes[y,x] = true;
                        }

                        break;
                    }

                    case 0:
                    {
                        System.Console.WriteLine("Obrigado pelo jogo");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Opcao invalida. Tente novamente");
                        break;
                    }
                }
                
            } while (opcao != 0);
        }
    }
}
