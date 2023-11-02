using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[3, 3];
            int[,] r = new int[3, 3];

            for (int j=1;j<=2;j++)
            {
                for (int k = 1; k <= 2; k++)
                {
                    Console.Write("digite a linha " + j + " da coluna " + k + ": ");
                    m[j, k] = int.Parse(Console.ReadLine());
                }
            }

            int melemento = m[1, 1];

            for (int j = 1; j <= 2; j++)
            {
                for (int k = 1; k <= 2; k++)
                {
                    if (m[j, k] > melemento)
                    {
                        melemento = m[j, k];
                    }

                }
            }

            for (int j = 1; j <= 2; j++)
            {
                for (int k = 1; k <= 2; k++)
                {
                    r[j, k] = m[j, k] * melemento;

                }
            }

            for (int j = 1; j <= 2; j++)
            {
                for (int k = 1; k <= 2; k++)
                {

                    Console.WriteLine("matriz resultante: " + r[j, k]);
                }
            }
            Console.ReadKey();
        }
    }
}
