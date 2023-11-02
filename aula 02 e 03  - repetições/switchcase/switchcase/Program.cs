using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            int teste = 1;
            Console.WriteLine("1 - inclusão");
            Console.WriteLine("2 - alteração");
            Console.WriteLine("3 - exclusão");
            Console.WriteLine("digite a opção desejada");
            teste = Int32.Parse(Console.ReadLine());

            // estrutura de controle switch
            switch(teste)
            {
                case 1:
                    Console.WriteLine("você escolheu a inclusão");
                    break;
                case 2:
                    Console.WriteLine("você escolheu a alteração");
                    break;
                case 3:
                    Console.WriteLine("você escolheu a exclusão");
                    break;
                default:
                    Console.WriteLine("escolha default");
                    break;
            }

            Console.ReadKey();
        }
    }
}
