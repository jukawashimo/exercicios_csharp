using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerc24
{
    class Program
    {
        static void Main(string[] args)
        {;
            int opcao = 0;
            Console.WriteLine("menu de opções");
            Console.WriteLine("1. imposto");
            Console.WriteLine("2. novo salário");
            Console.WriteLine("3. classificação");
            Console.WriteLine("4. finalizar o programa");
            Console.Write("digite a opção desejada: ");
            opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    double imposto = 0;
                    Console.WriteLine("");
                    Console.WriteLine("você escolheu: imposto");
                    Console.WriteLine("");
                    Console.WriteLine("digite o salário base: ");
                    double basesal = double.Parse(Console.ReadLine());
                    if (basesal < 500)
                    {
                        imposto = basesal * 0.05;
                    }
                    else if (basesal >= 500 && basesal <= 850)
                        {
                            imposto = basesal * 0.10;
                        }
                    else if (basesal > 850)
                    {
                        imposto = basesal * 0.15;
                    }
                    Console.WriteLine("imposto = " + imposto);
                    break;
                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("você escolheu: novo salário");
                    Console.WriteLine("");
                    Console.WriteLine("digite o salário base: ");
                    double sal = double.Parse(Console.ReadLine());
                    double novosal = 0;
                    if (sal > 1500)
                    {
                        novosal = sal + 25;
                    }
                    else if (sal >= 750 && sal <= 1500)
                    {
                        novosal = sal + 50;
                    }
                    else if (sal >= 450 && sal < 750)
                    {
                        novosal = sal + 75;
                    }
                    else if (sal < 450)
                    {
                        novosal = sal + 100;
                    }
                    Console.WriteLine("novo salário = " + novosal);
                    break;
                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("você escolheu: clafissicação");
                    Console.WriteLine("");
                    Console.WriteLine("digite o salário base: ");
                    double salbase = double.Parse(Console.ReadLine());
                    if (salbase <= 700)
                    {
                        Console.WriteLine("classificação: mal remunerado");
                    }
                    else if (salbase > 700)
                    {
                        Console.WriteLine("classificação: bem remunerado");
                    }
                    break;
                case 4:
                    break;
                default:
                    break;
            }


            Console.ReadKey();
        }
    }
}
