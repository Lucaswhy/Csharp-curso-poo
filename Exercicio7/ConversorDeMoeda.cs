using System;
using System.Globalization;

namespace Exercicio7 {
    class ConversorDeMoeda {

        public static double totalReais(double c, double d) {
            double x = c * d;
            return x + (x * 0.06) ;
        }

    }
}
