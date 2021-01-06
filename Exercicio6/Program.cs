using System;
using System.Globalization;

namespace Exercicio5 {
    class Program {
        static void Main(string[] args) {
            Aluno a = new Aluno();
            

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            a.Notas[0]= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(a.resultadoAluno());

        }
    }
}
