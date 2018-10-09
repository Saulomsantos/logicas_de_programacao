using System;

namespace Senai.Metodos.Exemplo1.Classes {
    public class Carro {
        //Declaracao de variaveis da Classe Carro
        #region Atributos
        public float PotenciaDoMotor {get; set;}
        public float Odometro {get; set;}
        public float KilometroPorLitro {get; set;}
        public float NivelTanque {get; private set;}
        public float CapacidadeTanque {get; set;}
        public bool Ligado {get; set;}
        #endregion

        //Declarando metodos da Classe Carro
        #region Metodos
        /// <summary>
        /// Liga o carro
        /// </summary>
        public void Ligar () {
            Console.WriteLine ("Carro ligado");
            Ligado = true;
        }

       /// <summary>
       /// O carro anda
       /// </summary>
       /// <param name="Kilometragem">Informe um valor de quantos km o carro deverá andar</param>
        public void Andar (float Kilometragem) { //parametro kilometragem - é um valor externo para que o metodo seja executado
            if (Ligado) {
                //Calculando o consumo de litros por km
                float consumo = Kilometragem / KilometroPorLitro;
                if (NivelTanque >= consumo) {
                    //Retira o consumo do nível do tanque
                    NivelTanque -= consumo;
                    //Acrescenta a kilometragem informada ao atributo odometro
                    Odometro += Kilometragem;
                    Console.WriteLine ($"Andou e consumiu {consumo} litros");
                } else {
                    Console.WriteLine ("Carro sem combustível, abasteça.");
                }
            } else {
                Console.WriteLine ("Ligue o carro");
            }
        }

        /// <summary>
        /// Abastece o carro
        /// </summary>
        /// <param name="quantidade">Informe quantos litros devem ser abastecidos</param>
        /// <returns>Retorna o nivel do tanque</returns>
        public float Abastecer(float quantidade) {
            NivelTanque += quantidade;
            return NivelTanque;
        }


        #endregion

    }
}

