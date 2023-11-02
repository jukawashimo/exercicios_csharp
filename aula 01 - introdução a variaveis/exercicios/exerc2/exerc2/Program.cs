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
            double num1, num2, num3, media;
            string n1, n2, n3;

            Console.WriteLine("escreva a primeira nota");
            n1 = Console.ReadLine();

            Console.WriteLine("escreva a segunda nota");
            n2 = Console.ReadLine();

            Console.WriteLine("escreva a terceira nota");
            n3 = Console.ReadLine();

            num1 = double.Parse(n1);
            num2 = double.Parse(n2);
            num3 = double.Parse(n3);

            media = (num1 + num2 + num3) / 3;
            Console.WriteLine("a média aritmética é: " + media);

            Console.ReadKey();

        }
    }
}
