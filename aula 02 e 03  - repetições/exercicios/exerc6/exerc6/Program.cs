using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc6
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            string number;

            Console.WriteLine("é par ou impar?");
            Console.WriteLine("digite um número");
            num = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("é par");
            }
            else
            {
                Console.WriteLine("é impar");
            }

            Console.ReadKey();
        }
    }
}
