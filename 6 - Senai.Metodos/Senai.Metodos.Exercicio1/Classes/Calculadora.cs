using System;

namespace Senai.Metodos.Exercicio1.Classes
{
    public class Calculadora
    {
        //Declaração de metodos da Classe Calculadora
        #region Metodos

        /// <sumary>
        /// Soma
        /// </sumary>
        /// <param name="valor1">Informe o valor1</param>
        /// <param name="valor2">Informe o valor2</param>
        /// <returns>Retorna o resultado da soma</returns>
        
        public double Somar(double valor1, double valor2)
        {
            //uma forma de retornar a operação, com atribuição de variável para o resultado
            double resultado = valor1 + valor2;
            return resultado;
        }

        /// <sumary>
        /// Subtração
        /// </sumary>
        /// <param name="valor1">Informe o valor1</param>
        /// <param name="valor2">Informe o valor2</param>
        /// <returns>Retorna o resultado da subtração</returns>

        public double Subtrair(double valor1, double valor2)
        {
            //outra forma de retornar a operação, sem atribuição de variável para o resultado
            return valor1 - valor2; 
        }

        /// <sumary>
        /// Multiplicação
        /// </sumary>
        /// <param name="valor1">Informe o valor1</param>
        /// <param name="valor2">Informe o valor2</param>
        /// <returns>Retorna o resultado da multiplicação</returns>

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        /// <sumary>
        /// Divisão
        /// </sumary>
        /// <param name="valor1">Informe o valor1</param>
        /// <param name="valor2">informe o valor2</param>
        /// <returns>Retorna o resultado da divisão</returns>

        public double Dividir(double valor1, double valor2)
        {
            return valor1 / valor2;
        }
        
        #endregion
    }
}