using System;

namespace Senai.Operadores.Exercicio2 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("\nInforme a base do retângulo:");
            float baseRet = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\nInforme a altura do retângulo:");
            float alturaRet = float.Parse (Console.ReadLine ());

            float areaRet = baseRet * alturaRet;

            Console.WriteLine ($"\nA área do retângulo é: {areaRet}\n");
        }
    }
}