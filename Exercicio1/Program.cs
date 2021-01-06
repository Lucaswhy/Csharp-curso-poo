using System;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {

            string velha;

            Pessoa a,b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade) {
                velha = a.nome;
            }
            else if (b.idade > a.idade) {
                velha = b.nome;
            }
            else {
                Console.WriteLine("Ambos tem a mesma idade.");
                return;
            }

            Console.WriteLine($"Pessoa mais velha: {velha}");
        }
    }
}
