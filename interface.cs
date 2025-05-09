using System;

namespace Interface
{
    // Classe principal do programa
    class Program
    {
        // Define uma interface chamada IControle
        // Uma interface só contém a assinatura dos métodos (sem implementação)
        interface IControle
        {
            void ApertarBotao();  // Método que as classes que implementarem a interface deverão definir
        }

        // Define uma interface chamada ITela
        interface ITela
        {
            void Pintar();  // Método que as classes que implementarem a interface deverão definir
        }

        // Classe que implementa (herda) as duas interfaces: IControle e ITela
        class ClasseBase : IControle, ITela
        {
            // Implementação do método da interface IControle
            public void ApertarBotao()
            {
                // Aqui poderia ter código que define o que acontece quando o botão é apertado
                Console.WriteLine("Botão apertado!");  // Exibe mensagem no console
            }

            // Implementação do método da interface ITela
            public void Pintar()
            {
                // Aqui poderia ter código que define como a tela é pintada/desenhada
                Console.WriteLine("Tela pintada!");  // Exibe mensagem no console
            }
        }

        // Método principal do programa (ponto de entrada)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");  // Exibe mensagem no console
        }
    }
}
