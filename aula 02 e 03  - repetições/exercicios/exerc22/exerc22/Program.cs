using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc22
{
    class Program
    {
        static void Main(string[] args)
        {

            double tempo, basesal, imposto = 0, gratifica = 0, salliq;

            Console.WriteLine("digite o salário base: ");
            basesal = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o tempo de serviço em anos: ");
            tempo = double.Parse(Console.ReadLine());

            // imposto
            if (basesal < 200)
            {
                imposto = basesal * 0;
                Console.WriteLine("valor do imposto: " + imposto);
            }
            else if (basesal >= 200 && basesal <= 450)
            {
                imposto = basesal * 0.03;
                Console.WriteLine("valor do imposto: " + imposto);
            }
            else if (basesal > 450 && basesal < 700)
            {
                imposto = basesal * 0.08;
                Console.WriteLine("valor do imposto: " + imposto);
            }
            else if (basesal >= 700)
            {
                imposto = basesal * 0.12;
                Console.WriteLine("valor do imposto: " + imposto);
            }

            // gratificação
            if (basesal >500 && tempo <= 3)
            {
                gratifica = 20;
            }
            else if (basesal > 500 && tempo > 3)
            {
                gratifica = 30;

            }
            else if (basesal <= 500 && tempo <= 3)
            {
                gratifica = 23;
            }
            else if (basesal <= 500 && tempo > 3 && tempo <6)
            {
                gratifica = 35;
            }
            else if (basesal <= 500 && tempo > 6)
            {
                gratifica = 33;
            }

            Console.WriteLine("valor da gratificação: " + gratifica);
            salliq = basesal - imposto + gratifica;
            Console.WriteLine("valor do salário líquido: " + salliq);

            // classificação
            if (salliq <= 350)
            {
                Console.WriteLine("categoria A");
            }
            else if (salliq > 350 && salliq <600)
            {
                Console.WriteLine("categoria B");
            }
            else if (salliq >= 600)
            {
                Console.WriteLine("categoria C");
            }

            Console.ReadKey();
        }
    }
}
