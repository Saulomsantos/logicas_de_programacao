using System;
using Senai.OO.Exercicio5.Classes;
// as pastas criadas para inclusão de código devem iniciar com letras maiúsculas. Por exemplo "Classes"
// Pascal Case maiúscula ou Camel Case minúscula
namespace Senai.OO.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebendo o valor que sera aplicado
            System.Console.WriteLine("Quanto deseja investir?");
            double valorAplicado = double.Parse(Console.ReadLine());

            Aplicacao Aplicacao1 = new Aplicacao();
            System.Console.WriteLine("Insira o nome da aplicacao");
            Aplicacao1.Nome = Console.ReadLine();
            
            System.Console.WriteLine("Insira o periodo de retencao");
            Aplicacao1.Periodo = int.Parse(Console.ReadLine()); // C# é fortemente tipado, isto é, a variável só aceita um tipo de dado

            System.Console.WriteLine("Insira a taxa de juros");
            Aplicacao1.Juros = double.Parse(Console.ReadLine());


            //Exbibindo relatorio 1
            System.Console.WriteLine($"----APLICACAO {Aplicacao1.Nome}----");
            System.Console.WriteLine($"Valor aplicado: R$ {valorAplicado.ToString("c")}");
            System.Console.WriteLine($"Taxa de juros: {Aplicacao1.Juros}%");
            System.Console.WriteLine($"Periodo de retencao: {Aplicacao1.Periodo} mes(es)");

            //Calculando margem de lucro
            double margemLucro = Aplicacao1.Juros / 100 * valorAplicado;
            DateTime hoje = DateTime.Now; //Criando um objeto DT para hoje
            DateTime dataRetorno = hoje.AddMonths(Aplicacao1.Periodo);
            System.Console.WriteLine($"Lucro (Juros): R$ {margemLucro.ToString("c")}");
            System.Console.WriteLine($"Total retorno financeiro: R$ {(valorAplicado + margemLucro).ToString("c")}");
            System.Console.WriteLine($"Data de retirada {dataRetorno.ToShortDateString()}");

            Aplicacao Aplicacao2 = new Aplicacao();
            Aplicacao Aplicacao3 = new Aplicacao();
        }
    }
}
