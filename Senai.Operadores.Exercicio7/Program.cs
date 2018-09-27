using System;

namespace Senai.Operadores.Exercicio7 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("\nInsira o valor em dolar");
            decimal valorDolar = decimal.Parse (Console.ReadLine ()); //utilizar o tipo de variável decimal para definir moeda

            Console.WriteLine ("\nInsira o valor em real");
            decimal valorReal = decimal.Parse (Console.ReadLine ());

            //decimal conversaoDolarReal = valorDolar * valorReal;

            Console.WriteLine ($"\nO valor inserido em dolar convertido para real é: US$ {valorDolar} * R$ {valorReal} = R$ {valorDolar * valorReal}");
            //colocar o $ faz uma interpolação, isto é, permite colocar variáveis na string
        }
    }
}