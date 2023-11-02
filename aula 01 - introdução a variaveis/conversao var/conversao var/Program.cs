using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversao_var
{
    class Program
    {
        static void Main(string[] args)
        {
            //conversão implicita
            byte num1 = 10;
            ushort num2;
            num2 = num1;
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            ushort num3 = 100;
            //byte num4 = num3; 
            // observe que se compilar dessa forma apresenta erro
            byte num4 = (byte)num3;
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            //double num5 = 100.45f;
            //float num6 = num5;
            float num5 = 100.4f;
            //double é maior que o float, logo nao é aceitavel
            double num6 = num5;
            Console.WriteLine(num5);
            Console.WriteLine(num6);

            Console.ReadKey();
            Console.ReadLine();

        }
    }
}
