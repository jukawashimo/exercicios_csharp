using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERC8
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("menu de opções");
            Console.WriteLine("1. somar dois números");
            Console.WriteLine("2. raiz quadrada de um número");
            opcao = Int32.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                double n1, n2, soma;
                Console.WriteLine("digite um valor: ");
                n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("digite outro valor: ");
                n2 = double.Parse(Console.ReadLine());

                soma = n1 + n2;
                Console.WriteLine("a soma dos dois números é " + soma);
            }
            else if (opcao == 2)
            {
                double valor, resul;

                Console.WriteLine("digite um valor: ");
                valor = double.Parse(Console.ReadLine());

                resul = Math.Sqrt(valor);
                Console.WriteLine("a raiz quadrada de " + valor + " é igual a " + resul);
            }
            else if (opcao != 1 && opcao != 2)
            {
                Console.WriteLine("tente novamente");
            }

            Console.ReadKey();
        }
    }
}
