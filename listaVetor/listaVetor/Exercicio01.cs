using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaVetor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            int[] numeros = new int[16];
            Console.Write("Numero 01: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 02: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 03: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 04: ");
            numeros[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 05: ");
            numeros[4] = Convert.ToInt32(Console.ReadLine());
            Console.Write("numero 06: ");
            numeros[5] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 07: ");
            numeros[6] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 08: ");
            numeros[7] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 09: ");
            numeros[8] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 10: ");
            numeros[9] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 11: ");
            numeros[10] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 12: ");
            numeros[11] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 13: ");
            numeros[12] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 14: ");
            numeros[13] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 15: ");
            numeros[14] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 16: ");
            numeros[15] = Convert.ToInt32(Console.ReadLine());
            int somanumero = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5] + numeros[6] + numeros[7] + numeros[8] + numeros[9] + numeros[10] + numeros[11] + numeros[12] + numeros[13] + numeros[14] + numeros[15];

            Console.WriteLine("Soma Dos Numeros: " + somanumero);

        }
    }
}
