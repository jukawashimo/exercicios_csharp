using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            // laço de repetição
            int total = 0, gradeCounter = 0, gradeValue = 0;
            while (gradeValue != -1)
            {
                total = total + gradeValue;
                gradeCounter = gradeCounter + 1;

                Console.Write("digite números inteiros, -1 para parar: ");
                gradeValue = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("a soma dos valores: " + total);

            Console.ReadLine();
        }
    }
}
