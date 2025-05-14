using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de um array de strings chamado "nomes"
            string[] nomes;

            // Inicialização do array com tamanho 5 (ou seja, pode armazenar 5 strings)
            nomes = new string[5];

            // Atribuição de valores (nomes) às posições do array
            nomes[0] = "João";      // índice 0
            nomes[1] = "Judite";    // índice 1
            nomes[2] = "Jeremias";  // índice 2
            nomes[3] = "José";      // índice 3
            nomes[4] = "Jonas";     // índice 4

            // Exemplo de como acessar diretamente um item do array (comentado)
            // Console.WriteLine("Nomes:" + nomes[0]); // Imprime apenas o nome da posição 0 ("João")

            // Estrutura de repetição foreach para percorrer todos os nomes do array
            foreach (string nome in nomes)
            {
                // Imprime o nome atual da iteração
                Console.WriteLine("Nome: " + nome);
            }
        }
    }
}
