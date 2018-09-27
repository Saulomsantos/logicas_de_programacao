using System;

namespace Senai.Operadores.Exercicio1 {
    class Program {
        static void Main (string[] args) {

            #region Imc Pessoa 1
            Console.WriteLine ("\n" + "Informe a altura da primeira pessoa");
            float alturaPessoa1 = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\n" + "Informe o peso da primeira pessoa");
            float pesoPessoa1 = float.Parse (Console.ReadLine ());

            float imcPessoa1 = pesoPessoa1 / (alturaPessoa1 * alturaPessoa1);

            Console.WriteLine ("\n" + "Pessoa 1:\nPeso: " + pesoPessoa1 + " kg" +
             ", Altura: " + alturaPessoa1 + " cm" +
             ", IMC = " + imcPessoa1);
            #endregion

            #region Imc Pessoa 2
            Console.WriteLine ("\n" + "Informe a altura da segunda pessoa");
            float alturaPessoa2 = float.Parse (Console.ReadLine ());

            Console.WriteLine ("\n" + "Informe o peso da segunda pessoa");
            float pesoPessoa2 = float.Parse (Console.ReadLine ());

            //(float 4 bytes) = (float 4 bytes)  /  (double 8 bytes)
            float imcPessoa2 = (float) (pesoPessoa2 / Math.Pow (alturaPessoa2, 2));
            //aqui converte o resultado do Math.Pow (double) em float

            Console.WriteLine($"\nPessoa 2:\nPeso: {pesoPessoa2} kg, Altura: {alturaPessoa2} cm, IMC = {imcPessoa2}\n");
            #endregion

        }
    }
}