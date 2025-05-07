using System;

namespace MyApp
{
    // Define uma classe chamada 'Aluno'
    public class Aluno
    {
        // Construtor da classe Aluno, recebe um parâmetro 'nome' e atribui ao campo 'nomeDoAluno'
        public Aluno(string nome)
        {
            nomeDoAluno = nome;
        }

        // Propriedade somente leitura que armazena o nome do aluno
        public string nomeDoAluno { get; }
    }

    // Classe principal que contém o método Main (ponto de entrada do programa)
    internal class Construtor
    {
        static void Main(string[] args)
        {
            // Cria uma instância da classe Aluno com o nome "João"
            Aluno aluno1 = new Aluno("João");

            // Cria outra instância da classe Aluno com o nome "Maria"
            Aluno aluno2 = new Aluno("Maria");

            // Exibe no console o nome do primeiro aluno
            Console.WriteLine("Aluno 1: " + aluno1.nomeDoAluno);

            // Exibe no console o nome do segundo aluno
            Console.WriteLine("Aluno 2: " + aluno2.nomeDoAluno);
        }
    }
}
