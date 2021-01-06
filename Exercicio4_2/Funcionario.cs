using System;
using System.Globalization;

namespace Exercicio4_2 {
    class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double p) {
            SalarioBruto += SalarioBruto * (p/100.0);
        }

        public override string ToString() {
            return Nome + ", $ " + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
