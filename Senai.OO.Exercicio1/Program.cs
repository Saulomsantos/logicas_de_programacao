using System;
using Senai.OO.Exercicio1.classes;

namespace Senai.OO.Exercicio1 {
    class Program {
        static void Main (string[] args) 
        {   
            #region IMC Pessoa 1
            // criação do objeto pessoa
            pessoa pessoa1 = new pessoa();
            
            Console.WriteLine("Informe o nome da pessoa 1");
            // atribui o nome da pessoa ao objeto
            pessoa1.Nome = Console.ReadLine();

            Console.WriteLine("Informe a altura da pessoa 1");
            // atribui a altura da pessoa ao objeto
            pessoa1.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da pessoa 1");
            // atribui o peso da pessoa ao objeto
            pessoa1.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O IMC de {pessoa1.Nome} é: { pessoa1.Peso / Math.Pow(pessoa1.Altura,2) }");
            #endregion

            #region IMC Pessoa 2
            // criação do objeto pessoa
            pessoa pessoa2 = new pessoa();
            
            Console.WriteLine("Informe o nome da pessoa 2");
            // atribui o nome da pessoa ao objeto
            pessoa2.Nome = Console.ReadLine();

            Console.WriteLine("Informe a altura da pessoa 2");
            // atribui a altura da pessoa ao objeto
            pessoa2.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da pessoa 2");
            // atribui o peso da pessoa ao objeto
            pessoa2.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O IMC de {pessoa2.Nome} é: { pessoa2.Peso / Math.Pow(pessoa2.Altura,2) }");
            #endregion

            #region IMC Pessoa 3
            // criação do objeto pessoa
            pessoa pessoa3 = new pessoa();
            
            Console.WriteLine("Informe o nome da pessoa 3");
            // atribui o nome da pessoa ao objeto
            pessoa3.Nome = Console.ReadLine();

            Console.WriteLine("Informe a altura da pessoa 3");
            // atribui a altura da pessoa ao objeto
            pessoa3.Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso da pessoa 3");
            // atribui o peso da pessoa ao objeto
            pessoa3.Peso = float.Parse(Console.ReadLine());

            Console.WriteLine($"O IMC de {pessoa3.Nome} é: { pessoa3.Peso / Math.Pow(pessoa3.Altura,2) }");
            #endregion
        }
    }
}