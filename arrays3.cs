using System;

namespace Arrays_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 estudantes 
            // idade dos estudantes
            // exibir o estudante mais velho e o mais novo

            String[] estudantes = new string[10]; 
            int[] idades = new int[10];
            String[] lista = new string[10];

            Console.WriteLine("Digite o nome dos 10 estudantes e suas idades:");

            // Laço para ler os dados dos estudantes
            for (int p = 0; p < estudantes.Length; p++)
            {
                // Ler o nome e a idade do estudante
                Console.WriteLine("Nome do estudante:");
                estudantes[p] = Console.ReadLine();

                // Ler a idade do estudante
                Console.WriteLine("Idade do estudante:");
                idades[p] = Convert.ToInt16(Console.ReadLine());

                // Adicionar o estudante e a idade na lista
                if (idades[p] < 10)
                {
                    // Adiciona um zero a esquerda
                    lista[p] = "0" + idades[p] + " " + estudantes[p];
                }else
                {
                    // Adiciona o estudante e a idade na lista
                    lista[p] = idades[p] + " " + estudantes[p];
                }
            }
            // Exibir o estudante mais velho e o mais novo
            Array.Sort(lista);
            foreach (String p in lista)
            {
                // Exibir os estudantes ordenados
                Console.WriteLine(p);
            }
            // O estudante mais novo é o primeiro da lista
            Console.WriteLine("O estudante mais novo é: " + lista[0]);
            // O estudante mais velho é o último da lista
            Console.WriteLine("O estudante mais velho é: " + lista[lista.Length - 1]);
        }
    }
} 
