using System;
using Senai.Estrutura.Repeticao.Exemplo2.Classes;

namespace Senai.Estrutura.Repeticao.Exemplo1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //criando objeto calculadora
            Calculadora calculadora = new Calculadora();
            char resposta = 'S';

           
            while (resposta == 'S') //string são mencionadas com aspas duplas ("), char são mencionadas com aspas simples (')
            {         
                
                System.Console.WriteLine("Qual a tabuada deseja calcular?");
                calculadora.Fator = int.Parse(Console.ReadLine());
                calculadora.Contador = 1;

                //Criando o laço while
                while (calculadora.Contador <= 10)
                {
                    calculadora.Valor = calculadora.Fator * calculadora.Contador;
                    System.Console.WriteLine($"{calculadora.Fator} x {calculadora.Contador} = {calculadora.Valor}");
                    // `teste de ${variavel}` - interpolação em javaScript
                    
                    //Incrementa (pega o valor atual e adiciona 1)
                    calculadora.Contador++;
                }

                //Perguntar se o usuario deseja calcular outra tabuada
                System.Console.WriteLine("Deseja criar uma outra tabuada? [S/N]");
                resposta = char.Parse(Console.ReadLine());

                //Converter o caracter para sempre ser maiúsculo
                resposta = char.ToUpper(resposta);
            }
                //problemas: laco infinito, looping inifinito, deadlock
        }
    }
}
