using System;

namespace MyApp
{
    // Classe abstrata chamada Motocicleta
    abstract class Motocicleta
    {
        // Método público: qualquer código (dentro ou fora da classe) pode chamar este método
        public void LigarMoto() { }

        // Método protegido: apenas esta classe e classes derivadas (filhas) podem chamar este método
        protected void AdicionarGasolina(int galoes) { }

        // Método abstrato: não tem implementação aqui, 
        // as classes que herdarem de Motocicleta precisam obrigatoriamente implementar este método
        public abstract double ChegarNaVerlocidadeX();

        // Método virtual: tem implementação padrão (aqui está vazio), 
        // mas pode ser sobrescrito (override) nas classes derivadas se desejado
        public virtual int Dirigir(int quilometros, int velocidade) { }
    }

    // Classe principal para executar o programa
    internal class Metodos
    {
        static void Main(string[] args)
        {
            // Imprime "Hello World!" no console
            Console.WriteLine("Hello World!");
        }
    }
}
