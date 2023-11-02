using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERC12
{
    class Program
    {
        static void Main(string[] args)
        {

            double cod, sal, aumento, novosal;

            Console.WriteLine("digite seu código");
            cod = double.Parse(Console.ReadLine());

            Console.WriteLine("digite seu salário atual");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            if ( cod == 1)
            {

                Console.WriteLine("escrituário");
                aumento = sal * 0.50;
                novosal = sal + aumento;
                Console.WriteLine("valor do aumento: " + aumento);
                Console.WriteLine("valor do novo salário: " + novosal);
            }
            else if ( cod == 2)
            {
                Console.WriteLine("secretário");
                aumento = sal * 0.35;
                novosal = sal + aumento;
                Console.WriteLine("valor do aumento: " + aumento);
                Console.WriteLine("valor do novo salário: " + novosal);
            }
            else if ( cod == 3)
            {
                Console.WriteLine("caixa");
                aumento = sal * 0.20;
                novosal = sal + aumento;
                Console.WriteLine("valor do aumento: " + aumento);
                Console.WriteLine("valor do novo salário: " + novosal);
            }
            else if (cod == 4)
            {
                Console.WriteLine("gerente");
                aumento = sal * 0.10;
                novosal = sal + aumento;
                Console.WriteLine("valor do aumento: " + aumento);
                Console.WriteLine("valor do novo salário: " + novosal);
            }
            else if (cod == 5)
            {
                Console.WriteLine("diretor");
                Console.WriteLine("não há aumento");
                Console.WriteLine("valor do salário: " + sal);
            }
            else 
            {
                Console.WriteLine("tente novamente.");

            }

            Console.ReadKey();
        }
    }
}
