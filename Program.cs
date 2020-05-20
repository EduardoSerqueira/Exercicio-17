using System;

namespace Exercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("----FOR-----");

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("----WHILE-----");

            int w = 0;

            while (w <= n)
            {
                if (w % 2 != 0)
                {
                    Console.WriteLine(w);
                }
                w++;
            }

            //Exemplo 
            //Entrada
            //8
            //Saída
            //1
            //3
            //5
            //7
        }
    }
}
