using System;
using System.Globalization;

namespace ExercicioFixacao {
    class ContaBancaria {
        public int NumConta { get; private set; }
        public string _nome { get; set; }
        public double _saldo { get; private set; }

        public ContaBancaria(int num, string nome) {
            NumConta = num;
            _nome = nome;
            _saldo = 0.0;
        }

        public ContaBancaria(int num, string nome, double saldo) {
            NumConta = num;
            _nome = nome;
            depositaSaldo(saldo);
        }

        public void depositaSaldo(double x) {
            _saldo += x;
        }

        public void saqueSaldo(double x) {
            _saldo = (_saldo - x) - 5.0;
        }

        public override string ToString() {
            return "\nDados da conta atualizados:\n" +
            "Conta " + NumConta + ", Titular: " + _nome + ", Saldo: $ " + _saldo.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }
    }
}
