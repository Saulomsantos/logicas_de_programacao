using System;

namespace Senai.Array.Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cartela = new int[6] {40, 22, 19, 5, 8, 62}; //setando um array de 6 posicoes;
            int acertos = 0, posicao, numero; //entre virgulas para criar mais de uma variavel;

            do {
                Console.WriteLine("Informe um número: ");
                numero = int.Parse(Console.ReadLine());

                posicao = System.Array.IndexOf(cartela, numero); 

                if(posicao >= 0) {
                    acertos++;
                    Console.WriteLine($"Acertou {acertos}, faltam {6 - acertos}");
                }
            } while(acertos < 6);

            Console.WriteLine("BINGOOOOOOOO!!");
        }
    }
}