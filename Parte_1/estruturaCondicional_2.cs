
using System;

namespace MyApp
{
    internal class ConsoleApp2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um número: ");
            int numero_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva outro número: ");
            int numero_2 = Convert.ToInt32(Console.ReadLine());

            int total = numero_1 / numero_2; 
            
            Console.WriteLine("O seu total é: \n" + total);
        }
    }
}

