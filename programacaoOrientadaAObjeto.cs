using System;

namespace MyApp
{
    // Define uma classe chamada 'Aluno'
    public class Aluno
    {
        // Atributo público chamado 'nome', com valor padrão "João"
        public string nome = "João";

        // Segundo atributo público chamado 'nome_2', com valor padrão "Maria"
        public string nome_2 = "Maria";

        // Atributo público inteiro chamado 'nota_Anual', com valor padrão 8
        public int nota_Anual = 8;

        // Atributo público inteiro chamado 'cpf', com valor padrão 000111222
        // Atenção: no mundo real, CPF deveria ser string para manter zeros à esquerda
        public int cpf = 000111222;
    }

    // Classe principal para executar o programa
    internal class POO
    {
        static void Main(string[] args)
        {
            // Programação orientada a objetos - POO
            // Classes

            // Cria um objeto (instância) da classe Aluno
            Aluno aluno = new Aluno();

            // Exibe no console o valor do atributo 'nome' do objeto aluno
            Console.WriteLine("Nome: " + aluno.nome);

            // Exibe no console o valor do atributo 'nome_2' do objeto aluno
            Console.WriteLine("Nome 2: " + aluno.nome_2);

            // Exibe no console o valor do atributo 'nota_Anual' do objeto aluno
            Console.WriteLine("Nota anual: " + aluno.nota_Anual);

            // Exibe no console o valor do atributo 'cpf' do objeto aluno
            Console.WriteLine("CPF :" + aluno.cpf);
        }
    }
}
