using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            do
            {
                Console.WriteLine(cont);
                cont++;
            } while (cont <= 5);

            Console.ReadKey();


        }
    }
}
