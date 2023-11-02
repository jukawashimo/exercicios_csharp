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
            string n1, n2;
            double num1, num2, soma, sub, div, mult;

            Console.WriteLine("escreva o primeiro valor");
            n1 = Console.ReadLine();

            Console.WriteLine("escreva o segundo valor");
            n2 = Console.ReadLine();

            num1 = double.Parse(n1);
            num2 = double.Parse(n2);

            soma = num1 + num2;
            sub = num1 - num2;
            div = num1 / num2;
            mult = num1 * num2;

            Console.WriteLine("soma = " + soma);
            Console.WriteLine("subtração = " + sub);
            Console.WriteLine("divisão = " + div);
            Console.WriteLine("multiplicação = " + mult);
            Console.ReadKey();


        }
    }
}
