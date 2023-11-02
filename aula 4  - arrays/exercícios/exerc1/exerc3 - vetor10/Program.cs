using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc3___vetor10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int soma = 0;

            for(int i = 0; i <= 9; i++)
            {
                Console.Write("digite o valor do " + i + "° vetor - ");
                vet[i] = Int32.Parse(Console.ReadLine());
                soma = soma + vet[i];
            }

            Console.WriteLine("o resultado da soma é = " + soma);

            Console.ReadKey();

        }
    }
}
