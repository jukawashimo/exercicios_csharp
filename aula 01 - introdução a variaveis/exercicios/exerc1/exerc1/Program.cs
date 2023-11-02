using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1, num2, num3, num4;
            int n1, n2, n3, n4, soma;

            Console.WriteLine("digite o primeiro número inteiro");
            num1 = Console.ReadLine();

            Console.WriteLine("digite o segundo número inteiro");
            num2 = Console.ReadLine();

            Console.WriteLine("digite o terceiro número inteiro");
            num3 = Console.ReadLine();

            Console.WriteLine("digite o quarto número inteiro");
            num4 = Console.ReadLine();

            n1 = Int32.Parse(num1);
            n2 = Int32.Parse(num2);
            n3 = Int32.Parse(num3);
            n4 = Int32.Parse(num4);

            soma = n1 + n2 + n3 + n4;
            Console.WriteLine("a soma dos quatro números inteiros é: " + soma);

            Console.ReadKey();
        }
    }
}
