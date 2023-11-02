using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_aluno
{
    class Program
    {
        static void Main(string[] args)
        {

            string num1, num2, num3, num4;
            int n1, n2, n3, media, falta;

            Console.WriteLine("digite a primeira nota");
            num1 = Console.ReadLine();

            Console.WriteLine("digite a segunda nota");
            num2 = Console.ReadLine();

            Console.WriteLine("digite a terceira nota");
            num3 = Console.ReadLine();

            n1 = Int32.Parse(num1);
            n2 = Int32.Parse(num2);
            n3 = Int32.Parse(num3);

            media = (n1 + n2 + n2) / 3;
            Console.WriteLine("média: " + media);

            if (media >= 0 && media <3)
            {
                Console.WriteLine("reprovado");
            }
            else if (media >= 3 && media < 7)
            {
                Console.WriteLine("exame");
                falta = 6 - media;
                Console.WriteLine("a nota que precisa para passar é: " + falta);
            }
            else if (media >= 7 && media <= 10)
            {
                Console.WriteLine("aprovado");
            }
            Console.ReadKey();

        }
    }
}
