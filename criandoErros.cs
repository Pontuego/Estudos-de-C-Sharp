using System;

namespace Criando_Erros
{
    // Classe que representa uma conta corrente
    public class ContaCorrente
    {
        // Atributos privados da conta (agência e número da conta)
        private int Agencia;
        private int Numero;

        // Propriedade estática (compartilhada entre todas as contas) para a taxa de operação
        public static double TaxaOperacao { get; private set; }

        // Propriedade estática que contabiliza o total de contas criadas
        public static int TotalContasCriadas { get; private set; }

        // Construtor da conta corrente
        public ContaCorrente(int agencia, int numero)
        {
            // Inicializa os atributos privados
            Agencia = agencia;
            Numero = numero;

            // Lógica para atualizar a taxa de operação e o total de contas criadas
            if(TotalContasCriadas == 0)
            {
                // Se for a primeira conta criada, a taxa de operação é fixa em 30
                TaxaOperacao = 30;

                TotalContasCriadas++;
            } 
            else if (TotalContasCriadas > 0)
            {
                // Para as próximas contas, a taxa de operação é dividida pelo total de contas + 1
                TaxaOperacao = 30 / (TotalContasCriadas + 1);

                TotalContasCriadas++;
            }
        }
    }

    // Classe principal com o ponto de entrada do programa
    class Program
    {
        static void Main(string[] args)
        {
            // Criação de três objetos ContaCorrente
            ContaCorrente conta = new ContaCorrente(1111, 5678);
            ContaCorrente conta2 = new ContaCorrente(2222, 6789);
            ContaCorrente conta3 = new ContaCorrente(3333, 7890);

            // Exibição da taxa de operação atual (será a última calculada)
            Console.WriteLine("Taxa de operação = " + ContaCorrente.TaxaOperacao);

            // Exibição do total de contas criadas
            Console.WriteLine("Total de contas criadas = " + ContaCorrente.TotalContasCriadas);
        }
    }
}
