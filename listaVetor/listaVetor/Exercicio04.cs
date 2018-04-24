using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaVetor
{
    class Exercicio04
    {
        public Exercicio04() 
        {
            double[] nota = new double[4];
            Console.Write("Disciplina: ");
            string Disciplina = Console.ReadLine();
            Console.Write("1º Nota: ");
            nota[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("2º Nota: ");
            nota[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("3º Nota: ");
            nota[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("4º Nota: ");
            nota[3] = Convert.ToDouble(Console.ReadLine());
            double somanota = nota[0] + nota[1] + nota[2] + nota[3];
            double media = somanota / 4;
            Console.Write("Média Das notas: " + media);

        }
    }
}
