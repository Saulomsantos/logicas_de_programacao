namespace Senai.OO.Exercicio8.Classes
{
    public class Funcionario //classe
    {
        public string Nome; //atributo
        public double ValorHora; //atributo
        public int HorasTrabalhadas; //atributo

        #region METODOS
        public double CalcularValorProjeto()
        {
            //Calculando o total atraves dos atributos
            double total = HorasTrabalhadas * ValorHora;

            return total;
        }
        #endregion
    }
}