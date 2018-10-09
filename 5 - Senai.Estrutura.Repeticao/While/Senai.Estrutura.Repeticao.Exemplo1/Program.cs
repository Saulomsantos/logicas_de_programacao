using System;

namespace Senai.Estrutura.Repeticao.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Qual a tabuada deseja calcular?");
            int tabuada = int.Parse(Console.ReadLine());

            int contador = 1;

            //Criando o laço while
            while (contador <= 10)
            {
                int valor = tabuada * contador;
                System.Console.WriteLine($"{tabuada} x {contador} = {valor}");
                // `teste de ${variavel}` - interpolação em javaScript
                
                //Incrementa (pega o valor atual e adiciona 1)
                contador++;
            }

            //problemas: laco infinito, looping inifinito, deadlock
        }
    }
}
