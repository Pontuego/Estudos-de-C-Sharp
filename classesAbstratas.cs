using System;  // Importa o namespace System para usar funcionalidades básicas, como Console

namespace Abstrata  // Define o namespace 'Abstrata' para agrupar essas classes e evitar conflitos
{
    // Classe abstrata chamada 'Forma'
    // Não pode ser instanciada diretamente; serve como base para outras classes
    public abstract class Forma
    {
        // Método abstrato (não tem corpo aqui, apenas assinatura)
        // Obliga as subclasses a implementarem esse método
        public abstract int CalcularArea();
    }

    // Classe 'Quadrado' herda de 'Forma'
    class Quadrado : Forma
    {
        int lado;  // Campo privado para armazenar o lado do quadrado

        // Construtor que recebe o tamanho do lado
        public Quadrado(int n) => lado = n;

        // Sobrescreve o método abstrato CalcularArea da classe Forma
        // Calcula a área do quadrado (lado * lado)
        public override int CalcularArea() => lado * lado;
    }

    // Classe principal com o ponto de entrada do programa
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um objeto Quadrado com lado 22
            var qd = new Quadrado(22);

            // Exibe no console a área calculada do quadrado
            Console.WriteLine($"Área do quadrado = " + qd.CalcularArea());
        }
    }
}
