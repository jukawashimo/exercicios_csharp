using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[21,11];

            //entrada de dados
            for (int j = 1; j<= 20; j++)
            {
                for (int k = 1; k <= 11; k++)
                {
                    Console.Write("digite o valor da linha " + j + " da coluna " + k + ": ");
                    m[j, k] = Int32.Parse(Console.ReadLine());
                }

            }

            //soma colunas
            int[] somaColunas = new int[11];
            for (int j = 1; j <= 20; j++)
            {
                for (int k = 1; k <= 11; k++)
                {
                    somaColunas[k] += m[j,k];

                }

            }

            //multiplicação
            for (int j = 1; j <= 20; j++)
            {
                for (int k = 1; k <= 11; k++)
                {
                    m[j,k] *= somaColunas[k];
                }

            }


            // matrzi resultante
            for (int j = 1; j <= 20; j++)
            {
                for (int k = 1; k <= 11; k++)
                {
                    Console.WriteLine("matriz resultante = " + m[j,k]);
                }

            }

            Console.ReadKey();
        }
    }
}
