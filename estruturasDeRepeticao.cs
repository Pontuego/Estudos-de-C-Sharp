using System;

namespace MyApp
{
    internal class COnsoleApp5
    {
        static void Main(string[] args)
        {
            // Estruturas de repetição
            // For
            // Foreach
            // While
            // Do (while)

            // Parte 1 - While
            int n_1 = 0;
            while (n_1 < 10)
            {
                Console.WriteLine(n_1);
                n_1++;
            }

            // Parte 2 - For
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Parte 3 - Do/ Do while
            int n_2 = 0;
            do
            {
                Console.WriteLine(n_2);
                n_2++;
            } while (n_2 < 10);
        }
    }
}
