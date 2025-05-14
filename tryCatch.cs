using System;

namespace Criando_Erros
{
    // Classe que representa uma conta corrente
    public class ContaCorrente
    {
        // Campos privados da conta: agência e número
        private int Agencia;
        private int Numero;

        // Propriedade estática que representa a taxa de operação (compartilhada por todas as instâncias)
        public static double TaxaOperacao { get; private set; }

        // Propriedade estática que conta quantas contas já foram criadas
        public static int TotalContasCriadas { get; private set; }

        // Construtor da ContaCorrente, chamado ao criar uma nova instância
        public ContaCorrente(int agencia, int numero)
        {
            // Atribui os valores passados para os campos privados
            Agencia = agencia;
            Numero = numero;

            try
            {
                // Incrementa o total de contas criadas
                TotalContasCriadas++;

                // Calcula a taxa de operação dividindo 30 pelo número total de contas
                // ⚠️ OBS: Aqui ocorre divisão inteira porque "30" é um inteiro.
                TaxaOperacao = 30 / TotalContasCriadas;

                // Exibe a taxa de operação e o total de contas no console
                Console.WriteLine("Taxa de operação = " + TaxaOperacao);
                Console.WriteLine("Total de contas criadas = " + ContaCorrente.TotalContasCriadas);
            }
            catch (DivideByZeroException)
            {
                // Em caso de tentativa de divisão por zero, exibe uma mensagem de erro
                Console.WriteLine("Não é possível dividir por zero. A taxa de operação não pode ser calculada.");
            }
        }
    }

    // Classe principal que contém o ponto de entrada do programa
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de três contas correntes
            ContaCorrente conta = new ContaCorrente(1111, 5678);
            ContaCorrente conta2 = new ContaCorrente(2222, 6789);
            ContaCorrente conta3 = new ContaCorrente(3333, 7890);

            // Comentados porque já estamos imprimindo dentro do construtor
            // Console.WriteLine("Taxa de operação = " + ContaCorrente.TaxaOperacao);
            // Console.WriteLine("Total de contas criadas = " + ContaCorrente.TotalContasCriadas);
        }
    }
}
