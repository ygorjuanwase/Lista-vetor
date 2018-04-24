using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaVetor
{
    class Exercicio05
    {
        public Exercicio05()
        {
            double[] pesos = new double[5];
            Console.Write("1º Peso: ");
            pesos[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("2º Peso: ");
            pesos[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("3º Peso: ");
            pesos[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("4º Peso: ");
            pesos[3] = Convert.ToDouble(Console.ReadLine());
            Console.Write("5º Peso: ");
            pesos[4] = Convert.ToDouble(Console.ReadLine());
            double somapeso = pesos[0] + pesos[1] +pesos [2] +pesos [3] + pesos[4];
            double media = somapeso / 5;
            Console.WriteLine("Soma Dos Pesos: " + somapeso);
            Console.WriteLine("Média Dos Pesos: " + media);

        }
    }
}
