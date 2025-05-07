using System;  // Importa o namespace System, necessário para usar Console e outros recursos básicos

namespace Herancas_Interfaces  // Define um namespace chamado Herancas_Interfaces para agrupar essas classes
{
    // Classe pública chamada Iara
    public class Iara
    {
        // Campo privado (somente acessível dentro da classe Iara)
        private int valor = 10;

        // Classe interna (aninhada) chamada Joao, que herda de Iara
        public class Joao : Iara
        {
            // Método público que tenta acessar o campo 'valor' da classe mãe Iara
            public int PegarValor()
            {
                return this.valor;
            }
        }
    }

    // Classe principal para executar o programa
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância de Alessandra.Joao (classe aninhada)
            var Joao = new Iara.Joao();

            // Tenta exibir o valor herdado da classe mãe
            Console.WriteLine("Classe filho, Joao, herda de classe mãe, Iara o valor de " + Joao.PegarValor());
        }
    }
}
