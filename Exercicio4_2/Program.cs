using System;
using System.Globalization;

namespace Exercicio4_2 {
    class Program {
        static void Main(string[] args) {

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nFuncionário: " +  f);

            Console.Write("\n\nDigite a porcentagem para aumentar o salário: ");

            f.AumentarSalario(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

            Console.WriteLine("\nDados atualizados: " + f);

            
        }
    }
}
