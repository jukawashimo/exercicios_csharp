using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays1
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaraçao de array
            int[] xpto;

            //atribuiçao de tamanho
            xpto = new int[10];

            //declaracao com atribuiçao de tamanho
            int[] xpto1 = new int[10];

            //declaraçao com atribuiçao de lista de inicialização
            int[] xpto2 = { 10, 20, 30, 40 };

            //declaração de array com uso de variavel de valor constante
            const int arraytam = 10;
            int[] xpto3 = new int[arraytam];

            //declaração de inicialização a partir de lista da matriz
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };

            //propriedade de arrays
            int tam = xpto2.Length; //comrprimento de uma matriz
            Console.WriteLine("o comprimento da matriz xpto2 é: " + tam);

            int dim = xpto2.Rank; //dimensão de uma matriz
            Console.WriteLine("a dimensão da matriz xpto2 é: " + dim);

            Console.WriteLine("");

            // uso do Foreach - maneira simples e facil de fazer iteração
            foreach (int i in xpto2)
            {
                Console.Write(" {0} ", i); //mostrar a variavel
            }
            Console.WriteLine("");

            //procura um valor em um array
            int obj = 30; 
            int valor = Array.BinarySearch(xpto2, obj);
            if (valor < 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" o objeto {0} não foi encontrado", obj, valor);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("o objeto {0} está no índice {1}.", obj, valor);
            }

            Console.WriteLine("");

            //limpando o conteudo de uma matriz
            Array.Clear(array1, 2, 1); // a array, a posição, quantidade que deseja apagar
            foreach (int i in array1)
            {
                Console.Write(" {0} ", i);
            }

            Console.WriteLine("");
            Console.WriteLine("");

            // copia os elementos de uma array para outra
            Console.WriteLine("copia de array");
            int[] array2 = new int[5];
            Array.Copy(array1, array2, 2);
            foreach(int i in array2)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine("");
            Console.WriteLine("fim da copia de array");


            Console.WriteLine("");
            Console.WriteLine("");

            // classifica a matriz
            int[] xpto4 = { 45, 10, 7, 9, 36, 48, 101, 56, 8, 8 };
            Array.Sort(xpto4);
            Console.WriteLine("colocando os números em ordem (unidimensional");
            foreach(int i in xpto4)
            {
                Console.Write(" {0} ", i);
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
