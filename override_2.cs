using System;  // Importa o namespace System para usar funcionalidades como Console

namespace Virtual_Override  // Define um namespace para agrupar essas classes e evitar conflitos
{
    // Classe base Trabalhador
    public class Trabalhador
    {
        public string nome;           // Nome do trabalhador (acessível publicamente)
        protected decimal salarioBase; // Salário base (acessível apenas dentro da classe e em subclasses)

        // Construtor da classe Trabalhador
        public Trabalhador(string nome, decimal salarioBase)
        {
            this.nome = nome;                  // Inicializa o nome com o valor passado
            this.salarioBase = salarioBase;   // Inicializa o salário base com o valor passado
        }

        // Método virtual que calcula o salário (pode ser sobrescrito por subclasses)
        public virtual decimal CalcularSalario()
        {
            return salarioBase;  // Por padrão, só retorna o salário base
        }
    }

    // Classe vendasTrabalhador que herda de Trabalhador
    public class vendasTrabalhador : Trabalhador
    {
        private decimal bonusDeVendas; // Valor do bônus de vendas (somente acessível dentro da classe)

        // Construtor da classe vendasTrabalhador
        public vendasTrabalhador(string nome, decimal salarioBase, decimal bonusDeVendas)
            : base(nome, salarioBase)  // Chama o construtor da classe mãe (Trabalhador)
        {
            this.bonusDeVendas = bonusDeVendas; // Inicializa o bônus de vendas
        }

        // Sobrescreve (override) o método CalcularSalario da classe mãe
        public override decimal CalcularSalario()
        {
            return salarioBase + bonusDeVendas;  // Calcula salário com o bônus incluso
        }
    }

    // Classe principal que contém o ponto de entrada do programa
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria um objeto vendasTrabalhador (João) com salário base e bônus
            var trabalhador1 = new vendasTrabalhador("João", 1400, 500);

            // Cria um objeto Trabalhador (Maria) apenas com salário base
            var trabalhador2 = new Trabalhador("Maria", 1200);

            // Exibe no console os salários calculados de cada trabalhador
            Console.WriteLine($"Salário de {trabalhador1.nome}: R${trabalhador1.CalcularSalario()}");
            Console.WriteLine($"Salário de {trabalhador2.nome}: R${trabalhador2.CalcularSalario()}");
        }
    }
}
