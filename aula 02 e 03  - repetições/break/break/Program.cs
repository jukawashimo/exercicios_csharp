using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @break
{
    class Program
    {
        static void Main(string[] args)
        {
            // uso do break
            string output = "";
            for (int cont = 1; cont <= 10; cont++)
            {
                if (cont == 5)
                    //pula o codigo restante no laço de cont = 5
                    break;

                output += cont + " ";
                Console.WriteLine("valor - " + output);
            }
            Console.ReadKey();
        }
    }
}
