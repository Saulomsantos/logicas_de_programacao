using System;

namespace Senai.Decisao.Exercicios.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double SalarioMinimo;
            double ValorHoraTrabalhada;
            double ValorHoraTrabalhadaExtra;
            double SalarioMesBruto;
            double SalarioMesLiquido;
            double IRRF;
            double Gratificacao;
            int QuantHorasTrabalhadas;
            int HorasExtras;
            int Dependentes;


            System.Console.WriteLine("Informe o valor do salário mínimo");
            SalarioMinimo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe a quantidade de horas trabalhadas");
            QuantHorasTrabalhadas = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o número de dependentes");
            Dependentes = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe a quantidade de horas extras trabalhadas");
            HorasExtras = int.Parse(Console.ReadLine());

            ValorHoraTrabalhada = SalarioMinimo / 5;
            ValorHoraTrabalhadaExtra = ValorHoraTrabalhada + (ValorHoraTrabalhada * 0.5);

            if (HorasExtras == 0)
            {
                SalarioMesBruto = (QuantHorasTrabalhadas * ValorHoraTrabalhada) + (Dependentes * 64);
            }
            else
            {
                SalarioMesBruto = (QuantHorasTrabalhadas * ValorHoraTrabalhada) + (HorasExtras * ValorHoraTrabalhadaExtra) 
                + (Dependentes * 64);
            }

            if (SalarioMesBruto < 1750)
            {
                IRRF = 0;
            }
            else
            {
                if (SalarioMesBruto >= 1750 && SalarioMesBruto <= 2500)
                {
                    IRRF = 0.10 * SalarioMesBruto;
                }
                else
                {
                    IRRF = 0.20 * SalarioMesBruto;
                }
            }
            
            SalarioMesLiquido = SalarioMesBruto - IRRF;

            if (SalarioMesLiquido <= 1500)
            {
                Gratificacao = 400;
            }
            else
            {
                Gratificacao = 250;
            }

            System.Console.WriteLine($"\nO salário a receber é de: R$ {(SalarioMesLiquido + Gratificacao).ToString("c")}\n");
        }
    }
}
