using System;

namespace MyApp
{
    // Define uma classe chamada 'Aluno'
    public class Aluno
    {
        public string nome = "João";
        public int nota_Anual = 8;
        public int cpf = 000111222;
    }
    // Classe principal para executar o programa
    internal class POO
    {
        static void Main(string[] args)
        {
            // Programção orientada a objetos - POO
            // Classes

            Aluno aluno = new Aluno(); // Cria um objeto (instância) da classe Aluno

            Console.WriteLine("Nome: " + aluno.nome);
            Console.WriteLine("Nota anual: " + aluno.nota_Anual);
            Console.WriteLine("CPF :" + aluno.cpf);
        }
    }
}
