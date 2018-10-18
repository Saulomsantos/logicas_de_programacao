using System;

namespace Senai.Vetores.Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numerosSorteados = new int[1];

            do
            {
                int numeroRandomico = rnd.Next(51);
                //Verifica se o número existe no array
                int posicao = Array.IndexOf(numerosSorteados, numeroRandomico);

                //Caso não exista no Array, adiciona o valor
                //-1 não foi encontrado
                if (posicao == -1)
                {
                    //Atribui o numero sorteado ao array
                    numerosSorteados[numerosSorteados.Length -1] = numeroRandomico;
                    //Redimensiona o tamanho do array
                    Array.Resize(ref numerosSorteados, numerosSorteados.Length + 1);
                    System.Console.WriteLine("O número sorteado foi " + numeroRandomico);
                    System.Console.WriteLine("Aperte enter para continuar");
                    Console.ReadKey();
                }

            } while (numerosSorteados.Length < 50);
        }
    }
}
