using System;

namespace Senai.Operadores.Logicos.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int QuantMacas;
            float PrecoMaca;
            float Total;

            Console.WriteLine("Digite a quantidade de maçãs compradas");
            QuantMacas = int.Parse(Console.ReadLine());

            if (QuantMacas <12)
            {
                PrecoMaca = 0.30f; //o f é necessário para uso de número decimais
            }
            else
            {
                PrecoMaca = 0.25f;
            }
            
            Total = QuantMacas * PrecoMaca;

            System.Console.WriteLine($"O valor total a ser pago é: R$ {Total.ToString("c")}");
        }
    }
}
