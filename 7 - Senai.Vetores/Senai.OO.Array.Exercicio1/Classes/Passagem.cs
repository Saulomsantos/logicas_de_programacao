using System;

namespace Senai.OO.Array.Exercicio1.Classes
{
    public class Passagem
    {
        public int NumeroPassagem { get; set; }

        public string NomePassageiro { get; set; }

        public DateTime DataVoo { get; set; }

        #region Metodos

        public void ReceberDados()
        {
            Console.WriteLine ("Digite o Número da Passagem");
            NumeroPassagem = int.Parse(Console.ReadLine());
            
            Console.WriteLine ("Digite o nome do passageiro");
            NomePassageiro = Console.ReadLine ();
            
            Console.WriteLine ("Digite a data do Voo");
            DataVoo = DateTime.Parse (Console.ReadLine());
        }

        #endregion
    }
}