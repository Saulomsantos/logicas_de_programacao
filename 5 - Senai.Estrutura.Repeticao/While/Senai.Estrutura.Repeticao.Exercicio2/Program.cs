using System;

namespace Senai.Estrutura.Repeticao.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe o número de início");
            int inicio = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o número final");
            int final = int.Parse(Console.ReadLine());

            int contador = inicio;

            Console.Clear();

            while (contador < final)
            {
                System.Console.WriteLine($"{contador}");
                contador++;

		//cont++ primeiro processa, depois incrementa
		//++cont primeiro incrementa, depois processa		

            }
            System.Console.WriteLine($"{final}\n");
        }
    }
}
