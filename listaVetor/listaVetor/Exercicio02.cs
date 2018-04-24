using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaVetor
{
    class Exercicio02
    {
        public Exercicio02()
        {
            string[] nomes = new string[10];
            Console.Write("Nome 1: ");
            nomes[0] = Console.ReadLine();
            Console.Write("Nome 2: ");
            nomes[1] = Console.ReadLine(); 
            Console.Write("Nome 3: ");
            nomes[2] = Console.ReadLine(); 
            Console.Write("Nome 4: ");
            nomes[3] = Console.ReadLine(); 
            Console.Write("Nome 5: ");
            nomes[4] = Console.ReadLine(); 
            Console.Write("Nome 6: ");
            nomes[5] = Console.ReadLine(); 
            Console.Write("Nome 7: ");
            nomes[6] = Console.ReadLine(); 
            Console.Write("Nome 8: ");
            nomes[4] = Console.ReadLine(); 
            Console.Write("Nome 9: ");
            nomes[8] = Console.ReadLine(); 
            Console.Write("Nome 10: ");
            nomes[9] = Console.ReadLine();
            Console.Clear();

            Console.Write(String.Format("nomes: {0}\n {1}\n {2}\n {3}\n {4}\n {5}\n {6}\n {7}\n {8}\n {9}\n ", nomes[0], nomes[1], nomes[2], nomes[3], nomes[4], nomes[5], nomes[6], nomes[7], nomes[8], nomes[9]));

        }
    }
}
