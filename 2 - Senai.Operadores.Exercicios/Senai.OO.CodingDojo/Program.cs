using System;
using Senai.OO.CodingDojo.Classes;

namespace Senai.OO.CodingDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos();

            System.Console.WriteLine("Insira o nome do produto");
            p.Nome = Console.ReadLine();
            
            System.Console.WriteLine("Insira o preco:");
            p.Preco = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira as prestacoes: ");
            p.QuantidadePrestacao = int.Parse(Console.ReadLine());

            //Calculo do valor da prestacao
            double vp = p.Preco / p.QuantidadePrestacao;
            double acresc = p.Preco * (5/100*(p.QuantidadePrestacao-1));
            double totalPrestacao = vp + acresc;
            double totalGeral = totalPrestacao * p.QuantidadePrestacao;

            //Relatorio
            System.Console.WriteLine($"Nome: {p.Nome}");
            System.Console.WriteLine($"Valor Real: {p.Preco}");
            System.Console.WriteLine($"Parcelas: {p.QuantidadePrestacao}");
            System.Console.WriteLine($"R$ Parcela (SA): {vp}");
            System.Console.WriteLine($"R$ Acrescimo: {acresc}");
            System.Console.WriteLine($"R$ Parcela (CA): {totalPrestacao}");
            System.Console.WriteLine($"R$ TOTAL: {totalGeral}");
        }
    }
}
