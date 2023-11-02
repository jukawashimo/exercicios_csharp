using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raiz_quadrada
{
    class Program
    {
        static void Main(string[] args)
        {

            double valor, resul;

            Console.WriteLine("digite um valor: ");
            valor = double.Parse(Console.ReadLine());

            resul = Math.Sqrt(valor);
            Console.WriteLine("a raiz quadrada de " + valor + " é igual a " + resul);

            Console.ReadKey();
        }
    }
}
