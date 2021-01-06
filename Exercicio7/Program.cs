using System;
using System.Globalization;

namespace Exercicio7 {
    class Program {
        static void Main(string[] args) {

            double cotacao;
            double dolar;

            Console.Write("Qual é a cotação do dólar? ");
            cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares você vai comprar? ");
            dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.totalReais(cotacao, dolar).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
