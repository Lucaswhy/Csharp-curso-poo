using System;
using System.Globalization;

namespace ExercicioFixacao {
    class Program {
        static void Main(string[] args) {

            int conta;
            string nome;
            char dep;

            ContaBancaria c;

            Console.Write("Entre o número da conta: ");
            conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();

            Console.Write("Haverá o depósito inicial (s/n)? ");
            dep = char.Parse(Console.ReadLine());

            if(dep.Equals('s')) {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo =  double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                c = new ContaBancaria(conta,nome,saldo);
            }
            else {
                c = new ContaBancaria(conta, nome);
            }

            Console.Write(c);

            Console.WriteLine("Entre um valor para depósito: ");
            c.depositaSaldo(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));

            Console.Write(c);

            Console.WriteLine("Entre um valor para saque: ");
            c.saqueSaldo(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.Write(c);
        }
    }
}
