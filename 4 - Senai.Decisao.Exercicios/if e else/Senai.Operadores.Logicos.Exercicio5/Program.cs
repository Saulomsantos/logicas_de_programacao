using System;

namespace Senai.Operadores.Logicos.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe o primeiro número:");
            int Valor1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o segundo número:");
            int Valor2 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o terceiro número:");
            int Valor3 = int.Parse(Console.ReadLine());

            /*
            Verifica se o Valor1 é maior que Valor2 "E"
            Valor1 é maior que Valor3, neste caso
            Valor1 é maior que todos
            */

            if (Valor1 > Valor2 && Valor1 > Valor3)
            {
                /*
                Verifica se o Valor2 é maior que Valor3
                Mostra Valor3, Valor2 e Valor1
                Senão mostra Valor2, Valor3 e Valor1
                */
                if (Valor2 > Valor3)
                {
                    System.Console.WriteLine($"A ordem crescente dos valores é: {Valor3}, {Valor2}, {Valor1}");
                }
                else
                {
                    System.Console.WriteLine($"A ordem crescente dos valores é: {Valor2}, {Valor3}, {Valor1}");
                }
            }
            else
            {
                /*
                Verifica se Valor2 é maior que Valor1 "E"
                Valor2 é maior que Valor3, neste caso
                Valor2 é maior que todos
                Senão, Valor3 é maior que todos
                */
                if (Valor2 > Valor1 && Valor2 > Valor3)
                {
                    /*
                    Verifica se Valor3 é maior que Valor1
                    Mostra Valor1, Valor3 e Valor2
                    Senão mostra Valor3, Valor1 e Valor2
                    */
                    if (Valor3 > Valor1)
                    {
                        System.Console.WriteLine($"A ordem crescente dos valores é: {Valor1}, {Valor3}, {Valor2}");
                    }
                    else
                    {
                        System.Console.WriteLine($"A ordem crescente dos valores é: {Valor3}, {Valor1}, {Valor2}");
                    }
                }
                else
                {
                    /*
                    Verifica se Valor1 é maior que Valor2
                    Mostra Valor2, Valor1, Valor3
                    Senão, mostra Valor1, Valor2, Valor3
                    Neste caso Valor3 é maior que todos
                    */
                    if (Valor1 > Valor2)
                    {
                        System.Console.WriteLine($"A ordem crescente dos valores é: {Valor2}, {Valor1}, {Valor3}");
                    }
                    else
                    {
                        System.Console.WriteLine($"A ordem crescente dos valores é: {Valor1}, {Valor2}, {Valor3}");
                    }
                }
            }
        }
    }
}
