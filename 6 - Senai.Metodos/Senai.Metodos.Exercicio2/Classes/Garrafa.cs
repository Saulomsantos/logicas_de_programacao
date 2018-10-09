namespace Senai.Metodos.Exercicio2.Classes
{
    public class Garrafa
    {
        //Declaração dos atributos da Classe Garrafa
        #region Atributos
        private float conteudo = 1000;
        #endregion

        //Declaração dos metodos da Classe Garrafa

        ///<sumary>
        ///Encher
        ///</sumary>

        public void Encher(float qtd)
        {
            conteudo += qtd;          
        }

        ///<sumary>
        ///Esvaziar
        ///</sumary>

        public void Esvaziar(float qtd)
        {
            conteudo -= qtd;          
        }

        ///<sumary>
        ///Exibir
        ///</sumary>
        
        public void Mostrar()
        {
            System.Console.WriteLine(conteudo);          
        }
    }
}