using System;
using Senai.Metodos.Exemplo1.Classes;

namespace Senai.Metodos.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            //carro1.NivelTanque = 50;
            carro1.Ligar();
            carro1.Andar(125);
            carro1.Andar(200);
            carro1.Andar(125);
            carro1.Andar(3);
            carro1.Andar(50);
            Console.WriteLine(carro1.NivelTanque);
            Console.WriteLine("Total km " + carro1.Odometro);

            Carro corsa = new Carro();
            corsa.Ligar();

            float Nivel = corsa.Abastecer(20);
            Nivel = corsa.Abastecer(25);
            Console.WriteLine("Tanque " + Nivel);

        }
    }
}
