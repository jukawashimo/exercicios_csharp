using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vet = new int[7];
            int[] array = new int[7];
            int[] array1 = new int[7];
            int  qp=0, qi=0;

            for(int i=1 ; i<=6; i++)
            {
                Console.Write("digite o " + i + "° valor inteiro: ");
                vet[i] = Int32.Parse(Console.ReadLine());

                if (vet[i] % 2 == 0)
                {
                    array[i] = vet[i];
                    qp = qp + 1;
                }
                else
                {
                    array1[i] = vet[i];
                    qi = qi + 1;
                }

            }

            Console.Write("números pares = ");
            foreach (int i in array)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine("");
            Console.WriteLine("quantidade de números pares = " + qp);
            Console.Write("números ímpares = ");
            foreach (int i in array1)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine("");
            Console.WriteLine("quantidade de números ímpares = " + qi);


            Console.ReadKey();
        }
    }
}
