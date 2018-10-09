using System;

namespace Senai.Exemplo.Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis
            string Nome;
            sbyte Idade;
            float Altura;
            DateTime dataNascimento;
            char Sexo;

            Console.WriteLine("Informe o seu nome");
            Nome = Console.ReadLine(); //armazena os dados coletados em uma variável

            Console.WriteLine("Informe sua idade");
            Idade = Convert.ToSByte(Console.ReadLine()); //converte os dados coletados em texto do usuário para byte

            Console.WriteLine("Informe sua altura");
            Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua data e horário de nascimento");
            dataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu sexo [M/F]");
            Sexo = char.Parse(Console.ReadLine()); 
            //é necessária a conversão pois o dado obtido pelo console é em string (4 bytes) e a variável char somente aceita dois bytes
            //usando essa conversão é armazenado dois bytes da string e dispensado o restante

            Console.Clear();

            Console.WriteLine("Nome: " + Nome + 
            ", Idade: " + Idade + 
            ", Altura: " + Altura + 
            ", Data de nascimento: " + dataNascimento.ToShortDateString() + //ToShortDateString formata a exibição para não mostrar hora
            ", Sexo: " + Sexo + "\n"); //mostra na tela o valor das variáveis
        }
    }
}
