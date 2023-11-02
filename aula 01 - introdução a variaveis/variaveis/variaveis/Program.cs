using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // variaveis interias com sinais
            sbyte num1 = 100; // 8 bits . 
            short num2 = 32; // 16 bits
            int num3 = 30; // 32 bits
            long num4 = 40L; // 64 bits
            Console.WriteLine("variáveis inteiras com sinal");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine();

            // varaiveis interias sem sinais
            byte num5 = 10; // 8 bits - 0 a 255
            ushort num6 = 20; // 16 bits - 0 a 65.535
            uint num7 = 30; // 32 bits - 
            ulong num8 = 40L; // 64 bits
            Console.WriteLine("variáveis inteiras sem sinal");
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
            Console.WriteLine(num8);
            Console.WriteLine();

            // variaveis com ponto flutuante
            float num9 = 100.75f;
            double num10 = 500.45;
            decimal num11 = 145.75m;
            Console.WriteLine("variáveis com ponto flutuante");
            Console.WriteLine(num9);
            Console.WriteLine(num10);
            Console.WriteLine(num11);
            Console.WriteLine();

            char letra = 'a';
            char escape = '\n';
            char codigo = '\u0041';
            Console.WriteLine("variáveis char");
            Console.WriteLine(letra);
            Console.WriteLine(escape);
            Console.WriteLine(codigo);
            Console.WriteLine();

            string conteudo = "OLA MUNDO";
            Console.WriteLine("variáveis tipo string");
            Console.WriteLine(conteudo);
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
