using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc30
{
    class Program
    {
        static void Main(string[] args)
        {
            double salmin = 1550;
            for (int cont = 1; cont <= 10; cont++)
            {
                Console.WriteLine("");
                Console.Write("digite o salario do " + cont + "° contribuidor: ");
                double sal = double.Parse(Console.ReadLine());
                Console.Write("digite o cpf do " + cont + "° contribuidor: ");
                string cpf = Console.ReadLine();
                Console.Write("digite o número de dependentes do " + cont + "° contribuidor: ");
                int dep = Int32.Parse(Console.ReadLine());

                double desconto = sal * (dep * 0.05);
                double aliquota = 0;
                sal = sal - desconto;
                if (sal <= (2 * salmin))
                {
                    aliquota = sal * 0;
                }
                else if (sal > (2 * salmin) && sal < (3 * salmin))
                {
                    aliquota = 0.05;
                }
                else if (sal >= (3 * salmin) && sal < (5 * salmin))
                {
                    aliquota = 0.10;
                }
                else if (sal >= (5 * salmin) && sal < (7 * salmin))
                {
                    aliquota = 0.15;
                }
                else if (sal >= (7 * salmin))
                {
                    aliquota = 0.20;
                }

                double imposto = sal * aliquota;
                Console.WriteLine("o imposto que o " + cont + "° contribuidor irá pagar é: " + imposto);
            }
                
            Console.ReadKey();
        }
    }
}
