using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adição
{
    class Program
    {
        static void Main(string[] args)
        {
            string num_1, num_2;
            int num1, num2, soma;
            Console.WriteLine("entre com o primeiro valor");
            num_1 = Console.ReadLine();

            Console.WriteLine("etre com o segundo valor");
            num_2 = Console.ReadLine();

            // metodo parse - converte a representação de cadeia de 
            num1 = Int32.Parse(num_1);
            num2 = Int32.Parse(num_2);

            soma = num1 + num2;
            Console.WriteLine("a soma dos valores é: " + soma);
            Console.ReadKey();

        }
    }
}
