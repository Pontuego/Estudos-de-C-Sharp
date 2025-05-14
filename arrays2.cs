using System;

namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Objetivo:
            // - Ler 10 números inteiros maiores que 0
            // - Separar os pares e ímpares em vetores distintos
            // - Exibir todos os vetores em ordem crescente

            int[] numeros = new int[10];  // Armazena os 10 números digitados
            int[] pares = new int[10];    // Armazena os números pares
            int[] impares = new int[10];  // Armazena os números ímpares

            // Leitura dos 10 números
            for (int p = 0; p < numeros.Length; p++)
            {
                Console.WriteLine("Digite um número maior que 0:");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            // Separação dos pares e ímpares
            for (int p = 0; p < numeros.Length; p++)
            {
                if (numeros[p] % 2 == 0)
                {
                    pares[p] = numeros[p]; // Coloca o número na mesma posição no vetor 'pares'
                }
                else
                {
                    impares[p] = numeros[p]; // Coloca o número na mesma posição no vetor 'ímpares'
                }
            }

            // Ordenação dos vetores
            Array.Sort(numeros); // Ordena o vetor principal
            Array.Sort(pares);   // Ordena o vetor de pares (valores 0 ficarão no início)
            Array.Sort(impares); // Ordena o vetor de ímpares (valores 0 ficarão no início)

            // Exibição dos valores
            Console.WriteLine("Números digitados:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Números pares:");
            foreach (int numero in pares)
            {
                // Ignora os valores 0 (porque o array foi pré-preenchido com 0s)
                if (numero != 0)
                {
                    Console.WriteLine(numero);
                }
            }

            Console.WriteLine("Números ímpares:");
            foreach (int numero in impares)
            {
                if (numero != 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
