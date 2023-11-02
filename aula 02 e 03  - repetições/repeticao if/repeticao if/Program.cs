using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeticao_if
{
    class Program
    {
        static void Main(string[] args)
        {

            // condicional simples
            int numero = 10;
            if (numero == 10)
            {
                Console.WriteLine("teste");
            }

            // condicional composta
            int num1 = 20;
            if (num1 == 20)
            {
                Console.WriteLine("verdadeiro");
            }
            else
            {
                Console.WriteLine("falso");
            }

            // alternativa para condicional composta com somente uma
            int number1 = 6;
            Console.WriteLine(number1 > 6 ? "passou" : "reprovou");

            // estrutura encadeada
            int num = 11;
            if (num == 20)
            {
                Console.WriteLine("igual a 20");
            }
            else if (num < 10)
            {
                Console.WriteLine("menor que 10");
            }
            else
            {
                Console.WriteLine("maior que 10");
            }

            num = 15;
            // estrutura condicional com mais de uma alternativa - E logico
            if (num <= 10 && num >= 0)
            {
                Console.WriteLine("valor entre 0 e 10");
            }
            else if (num > 10 && num < 20)
            {
                Console.WriteLine("valor entre 10 e 20");
            }
            else
            {
                Console.WriteLine("nenhum dos valores");
            }

            num = -5;
            // estrutura condicional com mais de uma alternativa - OU logico
            if (num <= 10 || num >= 0)
            {
                Console.WriteLine("valor entre 0 e 10");
            }
            else if (num > 10 || num < 20)
            {
                Console.WriteLine("valor entre 10 e 20");
            }
            else
            {
                Console.WriteLine("nenhum dos valores");
            }



            Console.ReadKey();
        }
    }
}
