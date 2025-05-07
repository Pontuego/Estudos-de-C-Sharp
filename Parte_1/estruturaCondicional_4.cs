
using System;

namespace MyApp
{
    internal class ConsoleApp4
    {
        static void Main(string[] args)
        {
            // ||
            // &&
            // !

            Console.WriteLine("Digite um número:\n");
            int numero = Convert.ToInt32(Console.ReadLine());
            int numero_2 = 6;
            bool resultado = false;

            if (numero == 6 || numero >= 6)
            {
                Console.WriteLine("É verdade");
            }
            else
            {
                Console.WriteLine("É mentira");
            }
        }
    }
}

