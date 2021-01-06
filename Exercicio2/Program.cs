using System;
using System.Globalization;

namespace Exercicio2 {
    class Program {
        static void Main(string[] args) {

            double med;

            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            med = (a.salario + b.salario) /2.0;

            Console.WriteLine("Salário médio = " + med.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
