using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaVetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            string[] nomes = new string[7];
            double[] PrecoProduto = new double[7];
            
            Console.Write("Nome Do Produto: ");
            nomes[0] = Console.ReadLine();
            Console.Write("Preço Do Produto: ");
            PrecoProduto[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nome Do Produto: ");
            nomes[1] = Console.ReadLine();
            Console.Write("Preço Do Produto: ");
            PrecoProduto[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nome Do Produto: ");
            nomes[2] = Console.ReadLine();
            Console.Write("Preço Do Produto: ");
            PrecoProduto[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nome Do Produto: ");
            nomes[3] = Console.ReadLine();
            Console.Write("Preço Do Produto: ");
            PrecoProduto[3] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nome Do Produto: ");
            nomes[4] = Console.ReadLine();
            Console.Write("Preço Do Produto: ");
            PrecoProduto[4] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nome Do Produto: ");
            nomes[5] = Console.ReadLine();
            Console.Write("Preço Do Produto: ");
            PrecoProduto[5] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nome Do Produto: ");
            nomes[6] = Console.ReadLine();
            Console.Write("Preço Do Produto: ");
            PrecoProduto[6] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nome Do Produto: ");
            Console.Clear();

            Console.Write(String.Format("Nome Do Produto: {0}\n {1}\n {2}\n {3}\n {4}\n {5}\n {6}", nomes[0], nomes[1], nomes[2], nomes[3], nomes[4], nomes[5], nomes[6]));
            Console.Write("Preço Do Produto: {0}\n {1}\n {2}\n {3}\n {4}\n {5}\n {6}\n ", PrecoProduto[0],
                PrecoProduto[1], PrecoProduto[2], PrecoProduto[3], PrecoProduto[4], PrecoProduto[5], PrecoProduto[6]);

        }
    }
}
