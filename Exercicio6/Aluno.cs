using System.Globalization;

namespace Exercicio5 {
    class Aluno {

        public string Nome;
        public double[] Notas = new double[3];
        
        public double totalNotas() {
            return Notas[0] + Notas[1] + Notas[2];
        }

        public string resultadoAluno() {
            if (totalNotas() >= 60.00) {
                return "NOTA FINAL = " + totalNotas().ToString("F2", CultureInfo.InvariantCulture) + "\nAPROVADO"; 
            }
            else {

                double faltante = 60.00 - totalNotas();

                return "NOTA FINAL = " + totalNotas().ToString("F2", CultureInfo.InvariantCulture) 
                    + "\nREPROVADO\nFALTARAM " + faltante.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }
    }
}
