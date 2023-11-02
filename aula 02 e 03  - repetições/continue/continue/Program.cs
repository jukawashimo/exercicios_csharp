using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @continue
{
        class Program
        {
            static void Main(string[] args)
            {
                string output = "";
                for (int cont = 1; cont <= 10; cont++)
                {
                    if (cont == 5)
                        continue;

                    output += cont + " ";
                    Console.WriteLine("valor - " + output);
                }
                Console.ReadKey();
            }
        }

}
