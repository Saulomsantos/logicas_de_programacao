using System;

namespace Senai.Decisao.Exercicios.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe o nome");
            string Nome = Console.ReadLine();
            
            System.Console.WriteLine("Informe o salário");
            double Salario = double.Parse(Console.ReadLine());

            System.Console.WriteLine("\nInforme o código correspondente ao cargo:\n" + 
            "\n1 - Escriturário\n" +
            "2 - Secretário\n" +
            "3 - Caixa\n" +
            "4 - Gerente\n" +
            "5 - Diretor\n");

            int Cargo = int.Parse(Console.ReadLine());

            switch (Cargo)
            {
                case 1:
                {
                    double SalarioAjustado = Salario + (Salario * 0.5);
                    System.Console.WriteLine($"\nDados do funcionário\n" + 
                    $"Nome: {Nome}\n" +
                    $"Salário atual: R$ {Salario.ToString("c")}\n" +
                    $"Código: {Cargo}\n" +
                    $"Cargo: Escriturário\n" +
                    $"Percentual de aumento: 50%\n" +
                    $"Salário com aumento: R$ {SalarioAjustado.ToString("c")}\n");
                    break;
                }

                case 2:
                {
                    double SalarioAjustado = Salario + (Salario * 0.35);
                    System.Console.WriteLine($"\nDados do funcionário\n" + 
                    $"Nome: {Nome}\n" +
                    $"Salário atual: R$ {Salario.ToString("c")}\n" +
                    $"Código: {Cargo}\n" +
                    $"Cargo: Secretário\n" +
                    $"Percentual de aumento: 35%\n" +
                    $"Salário com aumento: R$ {SalarioAjustado.ToString("c")}\n");
                    break;
                }

                case 3:
                {
                    double SalarioAjustado = Salario + (Salario * 0.2);
                    System.Console.WriteLine($"\nDados do funcionário\n" + 
                    $"Nome: {Nome}\n" +
                    $"Salário atual: R$ {Salario.ToString("c")}\n" +
                    $"Código: {Cargo}\n" +
                    $"Cargo: Caixa\n" +
                    $"Percentual de aumento: 20%\n" +
                    $"Salário com aumento: R$ {SalarioAjustado.ToString("c")}\n");
                    break;
                }

                case 4:
                {
                    double SalarioAjustado = Salario + (Salario * 0.1);
                    System.Console.WriteLine($"\nDados do funcionário\n" + 
                    $"Nome: {Nome}\n" +
                    $"Salário atual: R$ {Salario.ToString("c")}\n" +
                    $"Código: {Cargo}\n" +
                    $"Cargo: Gerente\n" +
                    $"Percentual de aumento: 10%\n" +
                    $"Salário com aumento: R$ {SalarioAjustado.ToString("c")}\n");
                    break;
                }

                case 5:
                {
                    double SalarioAjustado = Salario;
                    System.Console.WriteLine($"\nDados do funcionário\n" + 
                    $"Nome: {Nome}\n" +
                    $"Salário atual: R$ {Salario.ToString("c")}\n" +
                    $"Código: {Cargo}\n" +
                    $"Cargo: Diretor\n" +
                    $"Percentual de aumento: 0%\n" +
                    $"Salário com aumento: R$ {SalarioAjustado.ToString("c")}\n");
                    break;
                }
                
                default:
                {
                    break;
                }
            }            
        }
    }
}
